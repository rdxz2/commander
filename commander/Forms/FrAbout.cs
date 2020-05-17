using commander.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace commander.Forms
{
    public partial class FrAbout : Form
    {
        private readonly string _appVersion;
        private readonly string _applicationPath;

        public FrAbout(string appVersion)
        {
            //set application version
            _appVersion = appVersion;

            //get application base path
            _applicationPath = AppDomain.CurrentDomain.BaseDirectory;

            InitializeComponent();
        }

        private void FrAbout_Load(object sender, EventArgs e)
        {
            //set application version text
            llblAppVersion.Text = _appVersion;
        }

        //START -- LABELS

        private void LllblAppVersion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //open changelog file
            OpenFile(CNSTSTRING.FILENAME_README);
        }

        private void LlblHowToUse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //open readme file
            OpenFile(CNSTSTRING.FILENAME_README);
        }

        //END -- LABELS

        //START -- HELPERS

        private void OpenFile(string fileName)
        {
            //construct file path
            string filePath = Path.Combine(_applicationPath, fileName);

            //open file if exist
            if (File.Exists(filePath)) Process.Start(filePath);
            else MessageBox.Show($"{CNSTSTRING.FILENAME_CHANGELOG} does not exist in the application directory");
        }

        //END -- HELPERS
    }
}
