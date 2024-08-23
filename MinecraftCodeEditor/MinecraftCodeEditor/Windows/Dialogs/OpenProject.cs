using CodeEditor.Actions.FileHandler.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeEditor.Windows.Dialogs
{
    public partial class OpenProject : Form
    {

        //Grab default Project Location, and if the Location of the text does not contain it, decline the request
        public String projectDirectory;

        public OpenProject()
        {
            InitializeComponent();

            this.projectDirectory = locationTxt.Text;
            MessageBox.Show(projectDirectory + " / " + locationTxt.Text);
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (locationTxt.Text.Contains(this.Name))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                //Make error messagebox displaying project location is invalid and to try again with a valid location (this.Name)
                MessageBox.Show("Invalid Project Location. Please try again with a valid location:"
                    + Environment.NewLine + Environment.NewLine +
                    this.Name);

                //Set locationTxt.Text to this.Name
                locationTxt.Text = this.Name; 
            }
        }
    }
}
