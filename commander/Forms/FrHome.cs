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
            lblAppVersion.Text = $"v{appVersion}";

            //load project list box with user's projects
            LbxProjects_Populate();

            ////load project scripts
            //DataGridProjectScripts_Populate();
        }

        //START -- BUTTONS

        private void BtnProjectAdd_Click(object sender, EventArgs e)
        {
            using (FrProjectCreate frProjectCreate = new FrProjectCreate())
            {
                var result = frProjectCreate.ShowDialog();

                // make sure user is submitting form
                if (result != DialogResult.OK) return;

                //create database model
                project tbiProject = new project
                {
                    name = frProjectCreate.TbxNameValue,
                    cd = DateTime.Now,
                    is_active = true
                };

                //insert model
                ettCommander.projects.Add(tbiProject);

                //commit
                ettCommander.SaveChanges();

                //repopulate project list box
                LbxProjects_Populate();
            }
        }

        private void BtnProjectRemove_Click(object sender, EventArgs e)
        {
            //get selected project from listbox
            VMHome.Project lbxProjectsSelectedItem = LbxProjects_GetSelectedItem();

            //get selected project's entity from database
            project repoProject = ettCommander.projects.SingleOrDefault(m => m.id == lbxProjectsSelectedItem.Id);

            //make sure data is exist in database
            if (repoProject == null)
            {
                MessageBox.Show($"project '{lbxProjectsSelectedItem.Name}' not found in database");

                return;
            }

            //update
            repoProject.ud = DateTime.Now;
            repoProject.is_active = false;

            //commit
            ettCommander.SaveChanges();

            //reload list box
            LbxProjects_Populate();
        }

        private void BtnProjectScriptAdd_Click(object sender, EventArgs e)
        {
            //get selected project from listbox
            VMHome.Project lbxProjectsSelectedItem = LbxProjects_GetSelectedItem();

            using (FrProjectScriptCreate frProjectScriptCreate = new FrProjectScriptCreate(lbxProjectsSelectedItem))
            {
                //open dialog and get its closed result
                DialogResult result = frProjectScriptCreate.ShowDialog();

                // make sure user is submitting form
                if (result != DialogResult.OK) return;

                //get selected projcet's entity from database
                project tbuProject = ettCommander.projects.SingleOrDefault(m => m.id == lbxProjectsSelectedItem.Id);

                //make sure data is exist in database
                if (tbuProject == null)
                {
                    MessageBox.Show($"project '{lbxProjectsSelectedItem.Name}' not found in database");

                    return;
                }

                //create database model
                project_script tbiRepoProjectScript = new project_script
                {
                    name = frProjectScriptCreate.TbxNameValue,
                    script = frProjectScriptCreate.TbxScriptValue,
                    cd = DateTime.Now,
                };

                //update
                tbuProject.project_script.Add(tbiRepoProjectScript);
                tbuProject.ud = DateTime.Now;

                //commit
                ettCommander.SaveChanges();

                //create file with the script


                //repopulate project script data grid
                DgvProjectScripts_Populate();
            }
        }

        private void BtnProjectScriptRemove_Click(object sender, EventArgs e)
        {
            //get selected row from data grid
            VMHome.ProjectScript dgvProjectScriptsSelectedRow = DgvProjectScripts_GetSelectedRow();

            //make sure the selected item is available
            if (dgvProjectScriptsSelectedRow == null) return;

            //get selected row's entity from databsae
            project_script repoProjectScript = ettCommander.project_script.SingleOrDefault(m => m.id == dgvProjectScriptsSelectedRow.Id);

            //make sure data is exist in database
            if (repoProjectScript == null)
            {
                MessageBox.Show($"project script '{dgvProjectScriptsSelectedRow.Name}' not found in database");

                return;
            }

            //delete
            ettCommander.project_script.Remove(repoProjectScript);

            //commit
            ettCommander.SaveChanges();

            //reload data grid
            DgvProjectScripts_Populate();
        }

        //END -- BUTTONS

        //START -- LIST BOXES

        private VMHome.Project LbxProjects_GetSelectedItem()
        {
            if (LbxProject_IsAnyItemSelected()) return (VMHome.Project)lbxProjects.SelectedItem;

            MessageBox.Show("no project is selected");

            return null;
        }

        private bool LbxProject_IsAnyItemSelected() => lbxProjects.SelectedItems.Count > 0;

        private void LbxProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            DgvProjectScripts_Populate();
        }

        private void LbxProjects_Populate()
        {
            var repoProjects = ettCommander.projects
                .Where(m => m.is_active)
                .ToList();

            lbxProjects.DataSource = repoProjects
                .Select(m => new VMHome.Project
                {
                    Id = m.id,
                    Name = m.name,
                })
                .ToList();

            //toggle remove script button & toggle add script button
            btnProjectRemove.Enabled = btnProjectScriptAdd.Enabled = repoProjects.Count > 0;
        }

        //END -- LIST BOXES

        //START -- DATA GRIDS

        private VMHome.ProjectScript DgvProjectScripts_GetSelectedRow()
        {
            if (DgvProjectScripts_IsAnyRowSelected()) return (VMHome.ProjectScript)dgvProjectScripts.CurrentRow.DataBoundItem;

            MessageBox.Show("no project script row is selected");

            return null;
        }

        private bool DgvProjectScripts_IsAnyRowSelected() => dgvProjectScripts.SelectedRows.Count > 0;

        private VMHome.ProjectScript DgvProjectScripts_GetSelectedRowByCell()
        {
            if (DgvProjectScripts_IsAnyCellSelected()) return (VMHome.ProjectScript)dgvProjectScripts.Rows[dgvProjectScripts.CurrentCell.RowIndex].DataBoundItem;

            MessageBox.Show("no project script cell is selected");

            return null;
        }

        private bool DgvProjectScripts_IsAnyCellSelected() => dgvProjectScripts.SelectedCells.Count > 0;

        private void DgvProjectScripts_SelectionChanged(object sender, EventArgs e)
        {
            //toggle delete project script button
            btnProjectScriptRemove.Enabled = DgvProjectScripts_IsAnyRowSelected();
        }

        private void DgvProjectScripts_Populate()
        {
            //get selected project from listbox
            VMHome.Project lbxProjectsSelectedItem = LbxProjects_GetSelectedItem();

            bool isProjectFound = lbxProjectsSelectedItem != null;

            //toggle add script button
            btnProjectScriptAdd.Enabled = isProjectFound;

            //make sure project is exist in list box
            if (!isProjectFound) return;

            //get selected project
            var project = ettCommander.projects.SingleOrDefault(m => m.is_active && m.id == lbxProjectsSelectedItem.Id);
            if (project == null) return;

            //set project script label
            lblProjectScripts.Text = $"Scripts for '{project.name}'";

            //create binding list
            BindingList<VMHome.ProjectScript> bindingProjectScripts = new BindingList<VMHome.ProjectScript>();
            project.project_script
                .Select(m =>
                    VMHome.ProjectScript.CreateNew(m.id, m.name, m.script, m.last_executed)
                )
                .ToList()
                .ForEach(m =>
                    bindingProjectScripts.Add(m)
                );

            //bind to binding source
            dgvBindsrcProjectScripts.DataSource = bindingProjectScripts;

            //bind to data grid
            dgvProjectScripts.DataSource = dgvBindsrcProjectScripts;
        }

        private void DgvProjectScripts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //get selected row from data grid
            VMHome.ProjectScript dgvProjectScriptsSelectedRow = DgvProjectScripts_GetSelectedRowByCell();

            //make sure the selected item is available
            if (dgvProjectScriptsSelectedRow == null) return;

            //make sure the script is not being run
            if (dgvProjectScriptsSelectedRow.Pid.HasValue)
            {
                MessageBox.Show($"script '{dgvProjectScriptsSelectedRow.Name}' is already active");

                return;
            }

            //get selected script entity's from database
            var repoProjectScript = ettCommander.project_script.SingleOrDefault(m => m.id == dgvProjectScriptsSelectedRow.Id);

            //make sure data is exist in database
            if (repoProjectScript == null)
            {
                MessageBox.Show($"script '{dgvProjectScriptsSelectedRow.Name}' is not found");

                return;
            }

            //START -- RUN SCRIPT

            //create temporary file
            string filePath = CombineScriptDirectoryWithFileName(CombineProjectNameWithScriptName(repoProjectScript.project.name, repoProjectScript.name));
            bool isCreatingFileSuccess = utlFile.CreateAndWrite(filePath, repoProjectScript.script);
            if (!isCreatingFileSuccess)
            {
                MessageBox.Show("failed creating temporary comand file");

                return;
            }

            //get current time
            DateTime now = DateTime.Now;

            //define process start configuration
            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = filePath,
                UseShellExecute = false,
            };

            //initialize process
            Process process = new Process
            {
                StartInfo = processStartInfo,
                EnableRaisingEvents = true,
            };

            //add event handler when process is exited
            process.Exited += (object _sender, EventArgs _e) =>
            {
                //remove pid for this script
                dgvProjectScriptsSelectedRow.Pid = null;

                //delete temporary file
                utlFile.Delete(filePath);
            };

            //start process
            process.Start();

            //set and last executed date for this script
            dgvProjectScriptsSelectedRow.Pid = process.Id;
            dgvProjectScriptsSelectedRow.LastExecuted = now;

            //END -- RUN SCRIPT

            //update
            repoProjectScript.last_executed = now;

            //commit
            ettCommander.SaveChanges();
        }

        private void DgvProjectScripts_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //string newCellValue = dataGridProjectScripts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            //get selected row from data grid
            VMHome.ProjectScript dgvProjectScriptsSelectedRow = DgvProjectScripts_GetSelectedRowByCell();

            //make sure the selected item is available
            if (dgvProjectScriptsSelectedRow == null) return;

            //get selected script entity's from database
            var repoProjectScript = ettCommander.project_script.SingleOrDefault(m => m.id == dgvProjectScriptsSelectedRow.Id);

            //make sure data is exist in database
            if (repoProjectScript == null)
            {
                MessageBox.Show($"script '{dgvProjectScriptsSelectedRow.Name}' is not found");

                return;
            }

            //update
            repoProjectScript.name = dgvProjectScriptsSelectedRow.Name;
            repoProjectScript.script = dgvProjectScriptsSelectedRow.Script;

            //commit
            ettCommander.SaveChanges();

            //reload project script data grid
            DgvProjectScripts_Populate();
        }

        //END -- DATA GRIDS

        //START -- HELPERS

        private string CombineScriptDirectoryWithFileName(string databasePath) => Path.Combine(applicationPath, CNSTSTRING.FOLDERNAME_USERSCRIPTS, databasePath);

        private string CombineProjectNameWithScriptName(string projectName, string scriptName) => $"{projectName} {scriptName}.{CNSTSTRING.FILEEXTENSION_CMD}".Replace(" ", "_");

        //END -- HELPERS
    }
}
