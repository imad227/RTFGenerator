using RTFGeneratorLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTFGeneratorWinForms
{
    public partial class AddLawyer : Form
    {
        public Lawyer newLawyer { get; set; }
        public AddLawyer()
        {
            InitializeComponent();

            newLawyer = new Lawyer();
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            newLawyer.FirstName = firstNameTextBox.Text;
        }

        private void preFixTextBox_TextChanged(object sender, EventArgs e)
        {
            newLawyer.Prfix = preFixTextBox.Text;
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            newLawyer.LastName = lastNameTextBox.Text;
        }

        private void amdsaTextBox_TextChanged(object sender, EventArgs e)
        {
            int num;
            if (int.TryParse(amdsaTextBox.Text, out num))
            {
                newLawyer.AMDSA = num;
            }
            else
            {
                MessageBox.Show("Error", "AMDSA: Numbers only!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void maleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            newLawyer.Gender = gender.Male;
        }

        private void femaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            newLawyer.Gender = gender.Female;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // TODO - Implement Save here.
            // for now this button closes the window, and return newCourt to caller.
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // TODO - Implement better method.
            newLawyer = null;
        }
    }
}
