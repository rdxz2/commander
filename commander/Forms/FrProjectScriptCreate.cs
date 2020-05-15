using commander.ViewModels;
using System;
using System.Windows.Forms;

namespace commander.Forms
{
    public partial class FrProjectScriptCreate : Form
    {
        private readonly VMHome.Project project;

        public string TbxNameValue;
        public string TbxScriptValue;

        public FrProjectScriptCreate(VMHome.Project project)
        {
            InitializeComponent();

            this.project = project;

            //set window name
            Text = $"Create script for '{project.Name}'";
        }

        private void FrProjectScriptCreate_Load(object sender, EventArgs e)
        {

        }

        //START -- BUTTONS

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            HandleCancel();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            HandleSubmit();
        }

        //END -- BUTTONS

        //START -- HELPERS

        private void HandleSubmit()
        {
            //set internal value
            TbxNameValue = tbxName.Text;
            TbxScriptValue = tbxScript.Text;

            //set ok dialog result
            DialogResult = DialogResult.OK;

            //close this form
            Close();
        }

        private void HandleCancel()
        {
            //set cancel dialog result
            DialogResult = DialogResult.Cancel;

            //close this form
            Close();
        }

        //END -- HELPERS
    }
}
