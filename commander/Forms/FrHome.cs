using commander.Constants;
using commander.Models;
using commander.Utilities;
using commander.ViewModels;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace commander.Forms
{
    public partial class FrHome : Form
    {
        //db entity
        private readonly EttCommander ettCommander;

        //utilites
        private readonly UtlFile utlFile;

        private string applicationPath;


        public FrHome()
        {
            InitializeComponent();

            //initialize db entity
            ettCommander = new EttCommander();

            //initialize utilities
            utlFile = new UtlFile();

            //get application base path
            applicationPath = AppDomain.CurrentDomain.BaseDirectory;
        }

        private void FrHome_Load(object sender, EventArgs e)
        {
            //set application version label
            string appVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            labelAppVersion.Text = $"v{appVersion}";

            //load project list box with user's projects
            ListBoxProjects_Populate();

            //load project scripts
            DataGridProjectScripts_Populate();
        }

        //START -- BUTTONS

        private void ButtonProjectAdd_Click(object sender, EventArgs e)
        {
            using (FrProjectCreate frProjectCreate = new FrProjectCreate())
            {
                var result = frProjectCreate.ShowDialog();

                // make sure user is submitting form
                if (result != DialogResult.OK) return;

                //create database model
                project tbiProject = new project
                {
                    name = frProjectCreate.TextBoxNameValue,
                    cd = DateTime.Now,
                    is_active = true
                };

                //insert model
                ettCommander.projects.Add(tbiProject);

                //commit
                ettCommander.SaveChanges();

                //repopulate project list box
                ListBoxProjects_Populate();
            }
        }

        private void ButtonProjectRemove_Click(object sender, EventArgs e)
        {
            //get selected project from listbox
            VMHome.Project listBoxProjectsSelectedItem = ListBoxProjects_GetSelectedItem();

            //get selected project's entity from database
            project repoProject = ettCommander.projects.SingleOrDefault(m => m.id == listBoxProjectsSelectedItem.Id);

            //make sure data is exist in database
            if(repoProject == null)
            {
                MessageBox.Show($"project '{listBoxProjectsSelectedItem.Name}' not found in database");

                return;
            }

            //update
            repoProject.ud = DateTime.Now;
            repoProject.is_active = false;

            //commit
            ettCommander.SaveChanges();

            //reload list box
            ListBoxProjects_Populate();
        }

        private void ButtonProjectScriptAdd_Click(object sender, EventArgs e)
        {
            //get selected project from listbox
            VMHome.Project listBoxProjectsSelectedItem = ListBoxProjects_GetSelectedItem();

            using (FrProjectScriptCreate frProjectScriptCreate = new FrProjectScriptCreate(listBoxProjectsSelectedItem))
            {
                //open dialog and get its closed result
                DialogResult result = frProjectScriptCreate.ShowDialog();

                // make sure user is submitting form
                if (result != DialogResult.OK) return;

                //get selected projcet's entity from database
                project tbuProject = ettCommander.projects.SingleOrDefault(m => m.id == listBoxProjectsSelectedItem.Id);

                //make sure data is exist in database
                if (tbuProject == null)
                {
                    MessageBox.Show($"project '{listBoxProjectsSelectedItem.Name}' not found in database");

                    return;
                }

                //create file name
                string fileName = $"{tbuProject.name} {frProjectScriptCreate.TextBoxNameValue}.cmd".Replace(" ", "_");
                string filePath = Path.Combine(applicationPath, CNSTSTRING.FOLDERNAME_USERSCRIPTS, fileName);

                //create file
                bool isSuccess = utlFile.CreateAndWrite(filePath, frProjectScriptCreate.TextBoxScriptValue);

                //make sure file creation is success
                if(!isSuccess)
                {
                    MessageBox.Show($"file creation to {filePath} failed");

                    return;
                }

                //create database model
                project_script tbiRepoProjectScript = new project_script
                {
                    name = frProjectScriptCreate.TextBoxNameValue,
                    path = fileName,
                    cd = DateTime.Now,
                };

                //update
                tbuProject.project_script.Add(tbiRepoProjectScript);
                tbuProject.ud = DateTime.Now;

                //commit
                ettCommander.SaveChanges();

                //create file with the script


                //repopulate project script data grid
                DataGridProjectScripts_Populate();
            }
        }

        private void ButtonProjectScriptRemove_Click(object sender, EventArgs e)
        {
            //get selected row from data grid
            VMHome.ProjectScript dataGridProjectScriptsSelectedRow = DataGridProjectScripts_GetSelectedRow();

            //make sure the selected item is available
            if (dataGridProjectScriptsSelectedRow == null) return;

            //get selected row's entity from databsae
            project_script repoProjectScript = ettCommander.project_script.SingleOrDefault(m => m.id == dataGridProjectScriptsSelectedRow.Id);

            //make sure data is exist in database
            if(repoProjectScript == null)
            {
                MessageBox.Show($"project script '{dataGridProjectScriptsSelectedRow.Name}' not found in database");

                return;
            }

            //delete
            ettCommander.project_script.Remove(repoProjectScript);

            //commit
            ettCommander.SaveChanges();

            //reload data grid
            DataGridProjectScripts_Populate();
        }

        //END -- BUTTONS

        //START -- LIST BOXES

        private VMHome.Project ListBoxProjects_GetSelectedItem() {
            if(ListBoxProject_IsAnyItemSelected()) return (VMHome.Project)listBoxProjects.SelectedItem;

            MessageBox.Show("no project is selected");

            return null;
        }

        private bool ListBoxProject_IsAnyItemSelected() => listBoxProjects.SelectedItems.Count > 0;

        private void ListBoxProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridProjectScripts_Populate();
        }

        private void ListBoxProjects_Populate()
        {
            var repoProjects = ettCommander.projects
                .Where(m => m.is_active)
                .ToList();

            listBoxProjects.DataSource = repoProjects
                .Select(m => new VMHome.Project
                {
                    Id = m.id,
                    Name = m.name,
                })
                .ToList();

            //toggle remove script button & toggle add script button
            buttonProjectRemove.Enabled = buttonProjectScriptAdd.Enabled = repoProjects.Count > 0;
        }

        //END -- LIST BOXES

        //START -- DATA GRIDS

        private VMHome.ProjectScript DataGridProjectScripts_GetSelectedRow()
        {
            if (DataGridProjectScripts_IsAnyRowSelected()) return (VMHome.ProjectScript) dataGridProjectScripts.CurrentRow.DataBoundItem;

            MessageBox.Show("no project script row is selected");

            return null;
        }

        private bool DataGridProjectScripts_IsAnyRowSelected() => dataGridProjectScripts.SelectedRows.Count > 0;

        private VMHome.ProjectScript DataGridProjectScripts_GetSelectedRowByCell()
        {
            if (DataGridProjectScripts_IsAnyCellSelected()) return (VMHome.ProjectScript) dataGridProjectScripts.Rows[dataGridProjectScripts.CurrentCell.RowIndex].DataBoundItem;

            MessageBox.Show("no project script cell is selected");

            return null;
        }

        private bool DataGridProjectScripts_IsAnyCellSelected() => dataGridProjectScripts.SelectedCells.Count > 0;

        private void DataGridProjectScripts_SelectionChanged(object sender, EventArgs e)
        {
            //toggle delete project script button
            buttonProjectScriptRemove.Enabled = DataGridProjectScripts_IsAnyRowSelected();
        }

        private void DataGridProjectScripts_Populate()
        {
            //get selected project from listbox
            VMHome.Project listBoxProjectsSelectedItem = ListBoxProjects_GetSelectedItem();

            bool isProjectFound = listBoxProjectsSelectedItem != null;

            //toggle add script button
            buttonProjectScriptAdd.Enabled = isProjectFound;

            //make sure project is exist in list box
            if (!isProjectFound) return;

            //get selected project
            var project = ettCommander.projects.SingleOrDefault(m => m.is_active && m.id == listBoxProjectsSelectedItem.Id);
            if (project == null) return;

            //set project script label
            labelProjectScripts.Text = $"Scripts for '{project.name}'";

            //create binding list
            BindingList<VMHome.ProjectScript> bindingProjectScripts = new BindingList<VMHome.ProjectScript>();
            project.project_script
               .Select(m => {
                    //get script from file
                    string script = utlFile.Read(Path.Combine(applicationPath, CNSTSTRING.FOLDERNAME_USERSCRIPTS, m.path));

                    return VMHome.ProjectScript.CreateNew(m.id, m.name, script);

                    //return new VMHome.ProjectScript
                    //{
                    //    Id = m.id,
                    //    Name = m.name,
                    //    Script = script,
                    //};
               })
               .ToList()
               .ForEach(m => 
                    bindingProjectScripts.Add(m)
                );

            projectScriptBindingSource.DataSource = bindingProjectScripts;

            dataGridProjectScripts.DataSource = projectScriptBindingSource;

            ////populate data grid
            //dataGridProjectScripts.DataSource = project.project_script
            //    .Select(m => {
            //        //get script from file
            //        string script = utlFile.Read(Path.Combine(applicationPath, CNSTSTRING.FOLDERNAME_USERSCRIPTS, m.path));

            //        return new VMHome.ProjectScript
            //        {
            //            Id = m.id,
            //            Name = m.name,
            //            Script = script,
            //        };
            //    })
            //    .ToList();
        }

        private void DataGridProjectScripts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //get selected row from data grid
            VMHome.ProjectScript dataGridProjectScriptsSelectedRow = DataGridProjectScripts_GetSelectedRowByCell();

            //make sure the selected item is available
            if (dataGridProjectScriptsSelectedRow == null) return;

            //make sure the script is not being run
            if (dataGridProjectScriptsSelectedRow.Pid.HasValue)
            {
                MessageBox.Show($"script '{dataGridProjectScriptsSelectedRow.Name}' is already active");

                return;
            }

            //get selected script entity's from database
            var repoProjectScript = ettCommander.project_script.SingleOrDefault(m => m.id == dataGridProjectScriptsSelectedRow.Id);

            //make sure data is exist in database
            if(repoProjectScript == null)
            {
                MessageBox.Show($"script '{dataGridProjectScriptsSelectedRow.Name}' is not found");

                return;
            }

            //START -- RUN SCRIPT

            //define process start configuration
            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = Path.Combine(applicationPath, CNSTSTRING.FOLDERNAME_USERSCRIPTS, repoProjectScript.path),
                UseShellExecute = false,
            };

            //initialize process
            Process process = new Process
            {
                StartInfo = processStartInfo,
                EnableRaisingEvents = true,
                
            };

            //add event handler when process is exited
            process.Exited += (object _sender,EventArgs _e) =>
            {
                //remove pid for this script
                dataGridProjectScriptsSelectedRow.Pid = null;
            };

            //start process
            process.Start();

            //set pid for this script
            dataGridProjectScriptsSelectedRow.Pid = process.Id;

            //END -- RUN SCRIPT
        }

        //END -- DATA GRIDS
    }
}
