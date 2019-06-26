using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_LESSION8B
{
    public partial class Lab8Form : Form
    {
        //Class Properties
        public string UserName { get; set; }
        public float UserAge { get; set; }
        /// <summary>
        /// This is the Constructor for Lab08Form
        /// </summary>
        public Lab8Form()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the Event Handler for the Submit Button Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            UserName = NameTextBox.Text;

            UserAge = float.Parse(AgetextBox.Text);

            OutPutLabel.Text = NameTextBox.Text + " " + AgetextBox.Text;
         
            ClearForm();

            ////option B
            //NameTextBox.Text = "";
            //AgetextBox.Text = "";


        }
        /// <summary>
        /// This method clears the text boxes on the form
        /// </summary>
        private void ClearForm()
        {
            NameTextBox.Clear();
            AgetextBox.Clear();
            SubmitButton.Enabled = false;
        }

        /// <summary>
        /// This is the Event Handler for the AgeTextBox TextChanged Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgetextBox_TextChanged(object sender, EventArgs e)
        {
           //simple input validation
                try
                {
                    float.Parse(AgetextBox.Text);
                    SubmitButton.Enabled = true;
                }
                catch 
                {
                    SubmitButton.Enabled = false;
                }
               
            
            
        }

        private void Lab8Form_Load(object sender, EventArgs e)
        {
            ClearForm();
        }
        /// <summary>
        /// This is the Event Handler for the NameTextBox TextChange event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            SubmitButton.Enabled = (NameTextBox.Text.Length < 2) ? false : true;
        }
    }
}
