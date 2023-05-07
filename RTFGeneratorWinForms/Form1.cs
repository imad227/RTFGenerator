using RTFGeneratorLibrary;
using RTFGeneratorWinForms.Models;
using System;

namespace RTFGeneratorWinForms
{
    public partial class Form1 : Form
    {

        private Person person = new();

        public Form1()
        {
            InitializeComponent();
        }


        private void GeneratePaymenOrderBbutton_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Ready . . .";
            // Generate Payment Order Here.
            //MessageBox.Show("Generate Not implemented yet.", "Generate RTF not avaliable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            MessageBox.Show(CreateRTF.ClientData(person));

            CreateRTF.MaleSingelContract(person);
            //MessageBox.Show($"Test if person info is passed: ({person.FirstName} Postal Code: {person.FirstAddress.PostalCode})");
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Registring User information . . .";
            person.FirstName = firstNameTextBox.Text;
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Registring User information . . .";
            person.LastName = lastNameTextBox.Text;
        }

        private void fatherNameTextBox_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Registring User information . . .";
            person.FatherName = fatherNameTextBox.Text;
        }

        private void taxNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Registring User information . . .";
            person.TaxNumber = taxNumberTextBox.Text;
        }

        private void streetTextBox_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Registring User information . . .";
            person.FirstAddress.Street = streetTextBox.Text;
        }

        private void streetNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Registring User information . . .";
            person.FirstAddress.StrNumber = streetNumberTextBox.Text;
        }

        private void streetNameTextBox_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Registring User information . . .";
            person.FirstAddress.City = streetNameTextBox.Text;
        }

        private void zipCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Registring User information . . .";
            person.FirstAddress.PostalCode = zipCodeTextBox.Text;
        }

        private void maleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            person.Gender = gender.Male;
        }

        private void femaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            person.Gender = gender.Female;
        }
    }
}