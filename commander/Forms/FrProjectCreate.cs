using commander.Models;
using System;
using System.Windows.Forms;

namespace commander.Forms
{
    public partial class FrProjectCreate : Form
    {
        public string TextBoxNameValue;

        public FrProjectCreate()
        {
            InitializeComponent();
        }

        private void FrProjectCreate_Load(object sender, EventArgs e)
        {

        }

        //START -- BUTTONS

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            HandleCancel();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            HandleSubmit();
        }

        //END -- BUTTONS

        //START -- TEXT BOXES

        private void TextBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                //submit on enter
                case (char)Keys.Return:
                    HandleSubmit();
                    break;
                //close on escape
                case (char)Keys.Escape:
                    HandleCancel();
                    break;
                default:

                    break;
            }
        }

        //END -- TEXT BOXES

        //START -- HELPERS

        private void HandleSubmit()
        {
            //set internal value
            TextBoxNameValue = textBoxName.Text;

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
