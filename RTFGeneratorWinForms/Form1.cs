using DocumentFormat.OpenXml.Office2010.PowerPoint;
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
            CompanyTypeComboBox.Items.Clear();
        }

        private void femaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            person.Gender = gender.Female;
            CompanyTypeComboBox.Items.Clear();
        }

        private void companyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            person.Gender = gender.Company;

            // TODO (Enable ComboBox here, and disable elsewhere.
            // Enable ComboBox here to enable user to select the company type.
            // temporary solution.
            //ConstValues constValues = new ConstValues();
            
            //CompanyTypeComboBox.Items.Add("ATOMIKI");
            //CompanyTypeComboBox.Items.Add("IDIOTIKI KEFALEOYXA");
            //CompanyTypeComboBox.Items.Add("MONOPROSOPI");
        }

        private void addContractButton_Click(object sender, EventArgs e)
        {
            if (phoneNumberContractTextBox.Text == "" || contractNumberTextBox.Text == "" || contractDateTextBox.Text == "")
            {
                MessageBox.Show("Please provide a phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Contracts cont = new()
                {
                    PhoneNumber = phoneNumberContractTextBox.Text,
                    Number = contractNumberTextBox.Text
                };
                // TODO
                // Convert string to date.
                //cont.Date = contractDateTextBox.Text.Todate();

                DateTime date = DateTime.MinValue;
                bool parseResult = DateTime.TryParse(contractDateTextBox.Text, out date);
                if (parseResult)
                {
                    //parse was successful, continue
                    cont.Date = date;
                }
                else
                {
                    MessageBox.Show("Unable to read Date value", "unrecognizable Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                person.orderforPayment.contracts.Add(cont);


                phoneContractsListBox.Items.Clear();
                // update the list box
                foreach (Contracts p in person.orderforPayment.contracts)
                {
                    phoneContractsListBox.Items.Add(p.Show);
                }

                // clear the boxs in anticpation for new contract
                // TODO
                // move this to a function
                phoneNumberContractTextBox.Text = null;
                contractNumberTextBox.Text = null;
                contractDateTextBox.Text = null;
            }
        }

        private void removeContractButton_Click(object sender, EventArgs e)
        {
            if (phoneNumberContractTextBox.Text == "")
            {
                MessageBox.Show("Please provide a phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var toRemove = person.orderforPayment.contracts.RemoveAll(r => r.PhoneNumber == phoneNumberContractTextBox.Text);
            }

            phoneContractsListBox.Items.Clear();
            // update the list box
            foreach (Contracts p in person.orderforPayment.contracts)
            {
                phoneContractsListBox.Items.Add(p.Show);
            }

            // clear the boxs in anticpation for new contract
            // TODO
            // move this to a function
            phoneNumberContractTextBox.Text = null;
            contractNumberTextBox.Text = null;
            contractDateTextBox.Text = null;
        }

    }

}