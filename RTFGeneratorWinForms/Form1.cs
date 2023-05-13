//using DocumentFormat.OpenXml.Office2010.PowerPoint;
using RTFGeneratorLibrary;
using RTFGeneratorWinForms.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Windows.Forms;

namespace RTFGeneratorWinForms
{
    public partial class Form1 : Form
    {

        private Person person = new();
        private List<Lawyer> Lawyers = RTFGen.LoadLawyers();
        private List<string> ContractDuration = RTFGen.LoadContractsDuration();
        private List<string> ComppaniesTypes = RTFGen.LoadCompaniesTypes();

        public Form1()
        {
            InitializeComponent();

            // TODO
            // Remove from here.
            foreach (var lawyer in Lawyers)
            {
                lawyerSelectionComboBox.Items.Add(lawyer.Show);
            }

            // TODO
            // Remove This from here.
            foreach (var s in ContractDuration)
            {
                contractDurationComboBox.Items.Add(s);
            }

        }


        /// <summary>
        /// Add User Information
        /// </summary>
        /// 

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

        /// <summary>
        /// Add user Gender or Company type.
        /// </summary>
        /// 
        private void maleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            person.Gender = gender.Male;
            CompanyTypeComboBox.Items.Clear();
            CompanyTypeComboBox.Items.Add("");
            CompanyTypeComboBox.SelectedIndex = 0;
        }

        private void femaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            person.Gender = gender.Female;
            CompanyTypeComboBox.Items.Clear();
            CompanyTypeComboBox.Items.Add("");
            CompanyTypeComboBox.SelectedIndex = 0;
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

            foreach (var s in ComppaniesTypes)
            {
                CompanyTypeComboBox.Items.Add(s);
            }
        }


        /// <summary>
        /// Add user Contracts.
        /// </summary>
        /// 
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

        /// <summary>
        /// Add User Bills
        /// </summary>
        /// 

        private void addBillButton_Click(object sender, EventArgs e)
        {
            if (billDateTextBox.Text == "")
            {
                MessageBox.Show("Please provide the Bill issue date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Bills cont = new Bills();
                DateTime date = DateTime.MinValue;
                bool parseResult = DateTime.TryParse(billDateTextBox.Text, out date);
                if (parseResult)
                {
                    //parse was successful, continue
                    if (billAmountTextBox.Text == "")
                    {
                        cont.IssueDate = date;
                        person.orderforPayment.bills.Add(cont);
                    }
                    else
                    {

                        // TODO
                        // Fix the comma seperation issue.
                        double amount = new double();
                        string str = new string(billAmountTextBox.Text.Replace(',', '.'));
                        bool amountParseResult = double.TryParse(str, out amount);
                        if (amountParseResult)
                        {
                            cont.IssueDate = date;
                            cont.Amount = amount;
                            person.orderforPayment.bills.Add(cont);
                        }
                        else
                        {
                            MessageBox.Show("Unable to read Amount value", "unrecognizable Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Unable to read Date value", "unrecognizable Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                billsListBox.Items.Clear();
                foreach (Bills b in person.orderforPayment.bills)
                {
                    billsListBox.Items.Add(b.Show);
                }

                billDateTextBox.Text = null;
                billAmountTextBox.Text = null;

            }
        }

        private void removeBillButton_Click(object sender, EventArgs e)
        {
            if (billDateTextBox.Text == "")
            {
                MessageBox.Show("Please provide the Bill issue date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DateTime date = DateTime.MinValue;
                bool parseResult = DateTime.TryParse(billDateTextBox.Text, out date);
                if (parseResult)
                {
                    //parse was successful, continue
                    var toRemove = person.orderforPayment.bills.RemoveAll(r => r.IssueDate == date);
                }
                else
                {
                    MessageBox.Show("Unable to read Date value", "unrecognizable Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                billsListBox.Items.Clear();
                foreach (Bills b in person.orderforPayment.bills)
                {
                    billsListBox.Items.Add(b.Show);
                }

                billDateTextBox.Text = null;
                billAmountTextBox.Text = null;

            }
        }

        /// <summary>
        /// Menu Strip options.
        /// </summary>
        /// 

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close", "Leave Program?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }



        /// <summary>
        /// Buttons 
        /// </summary>
        /// 

        private void GeneratePaymenOrderBbutton_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Ready . . .";
            // Generate Payment Order Here.
            //MessageBox.Show("Generate Not implemented yet.", "Generate RTF not avaliable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            MessageBox.Show(CreateRTF.ClientData(person));

            CreateRTF.MaleSingelContract(person);
            //MessageBox.Show($"Test if person info is passed: ({person.FirstName} Postal Code: {person.FirstAddress.PostalCode})");
        }


        private void clearAllButton_Click(object sender, EventArgs e)
        {
            // Delete Person otions.

            // Clear textBox data

            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);

        }

        /// <summary>
        /// TEST BUTTON. TO BE REMOVED LATER.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void testButton_Click(object sender, EventArgs e)
        {

            //
        }
    }

}