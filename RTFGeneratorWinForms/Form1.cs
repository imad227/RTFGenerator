//using DocumentFormat.OpenXml.Office2010.PowerPoint;
using RTFGeneratorLibrary;
using RTFGeneratorWinForms.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace RTFGeneratorWinForms
{
    public partial class Form1 : Form
    {

        private Person person = new();
        private List<Lawyer> LawyersList = RTFGen.LoadLawyers();
        private List<string> ContractDuration = RTFGen.LoadContractsDuration();
        private List<string> CompaniesTypes = RTFGen.LoadCompaniesTypes();
        private List<Court> CourtsList = RTFGen.LoadCourts();

        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            companyTitelLabel.Hide();
            companyTitelTextBox.Hide();


            lawyerSelectionComboBox.DisplayMember = "Show";
            lawyerSelectionComboBox.DataSource = LawyersList;
            lawyerSelectionComboBox.SelectedIndex = -1;


            contractDurationComboBox.DataSource = ContractDuration;
            contractDurationComboBox.SelectedIndex = -1;


            courtSelectionComboBox.DisplayMember = "Show";
            courtSelectionComboBox.DataSource = CourtsList;
            courtSelectionComboBox.SelectedIndex = -1;
            courtSelectionComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            courtSelectionComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // TODO: FIX THIS
            // after autocomplete, selectd the correspoding item.
            AutoCompleteStringCollection courtAutoComleteList = new AutoCompleteStringCollection();
            foreach (var v in CourtsList)
            {
                courtAutoComleteList.Add(v.CapitalName);
            }

            courtSelectionComboBox.AutoCompleteCustomSource = courtAutoComleteList;
            // UNTIL HERE...

            CompanyTypeComboBox.DataSource = CompaniesTypes;
            CompanyTypeComboBox.SelectedIndex = -1;
        }

        //private void courtSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    courtSelectionComboBox.SelectedIndex = CourtsList.FindIndex(r => r.CapitalName == courtSelectionComboBox.Text);
        //}



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

        private void companyTitelTextBox_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Registring User information . . .";
            person.Title = companyTitelTextBox.Text;
        }

        private void judicialStampTextBox_TextChanged(object sender, EventArgs e)
        {
            //ΤΝ, ΤΠΔΑ, ΤΑΧΔΙΚ(Α264794) και γραμμάτιο προείσπραξης Δ.Σ.Α. (Π4350411).
            person.orderforPayment.TAXDIK = judicialStampTextBox.Text;
        }

        private void promissoryNoteTextBox_TextChanged(object sender, EventArgs e)
        {
            //ΤΝ, ΤΠΔΑ, ΤΑΧΔΙΚ(Α264794) και γραμμάτιο προείσπραξης Δ.Σ.Α. (Π4350411).
            person.orderforPayment.DSA = promissoryNoteTextBox.Text;
        }

        private void athensJurisdictionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (athensJurisdictionCheckBox.Checked)
            {
                person.orderforPayment.AthensJurisdiction = true;
            }
            else if (!athensJurisdictionCheckBox.Checked)
            {
                person.orderforPayment.AthensJurisdiction = false;
            }
        }

        private void challengeRequestCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (challengeRequestCheckBox.Checked)
            {
                person.orderforPayment.ChallengeRequest = true;
            }
            else if (!challengeRequestCheckBox.Checked)
            {
                person.orderforPayment.ChallengeRequest = false;
            }
        }

        private void courtSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Add the selected court to the person.orderforPayment class to the Court name memeber.
            if (courtSelectionComboBox.SelectedIndex != -1)
            {
                person.orderforPayment.CourtName = CourtsList[courtSelectionComboBox.SelectedIndex];
            }
        }

        private void lawyerSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lawyerSelectionComboBox.SelectedIndex != -1)
            {
                person.orderforPayment.LawyerName = LawyersList[lawyerSelectionComboBox.SelectedIndex];
            }
        }

        private void totalAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            // TODO
            // Fix the comma seperation issue.
            double amount = new();
            string str = new(totalAmountTextBox.Text.Replace(',', '.'));
            bool amountParseResult = double.TryParse(str, out amount);
            if (amountParseResult)
            {
                person.orderforPayment.Debt = amount;
            }
            else
            {
                MessageBox.Show("Unable to read Amount value", "unrecognizable Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CompanyTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Fix this later if we need the company prefix. Otherwise remove the prefix from the file.
            if (companyRadioButton.Checked)
            {
                string line = CompaniesTypes[CompanyTypeComboBox.SelectedIndex];
                string[] entries = line.Split(',');
                person.orderforPayment.CompanyType = entries[0];
                //person.orderforPayment.CompanyType = CompanyTypeComboBox.SelectedItem;
            }

        }

        //private void searchCourtTextBox_TextChanged(object sender, EventArgs e)
        //{

        //    // TODO - FIX THIS: works only when typing the full name, I want it to start finding as soon as users types the info.
        //    var v = CourtsList.Find(r => r.CapitalName == searchCourtTextBox.Text);
        //    int index = new();
        //    if (v != null)
        //    {
        //        int loopIndex = 0;
        //        foreach (var entry in CourtsList)
        //        {
        //            if (v.CapitalName == entry.CapitalName)
        //            {
        //                index = loopIndex; break;
        //            }
        //            loopIndex++;
        //        }
        //        courtSelectionComboBox.SelectedIndex = index;
        //    }
        //    else
        //    {
        //        courtSelectionComboBox.SelectedIndex = -1;
        //    }

        //}

        //private void searchLawyerTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    // TODO - FIX THIS: works only when typing the full name, I want it to start finding as soon as users types the info.
        //    var v = Lawyers.Find(r => r.LastName == searchLawyerTextBox.Text);
        //    int index = new();
        //    if (v != null)
        //    {
        //        int loopIndex = 0;
        //        foreach (var entry in Lawyers)
        //        {
        //            if (v.LastName == entry.LastName)
        //            {
        //                index = loopIndex; break;
        //            }
        //            loopIndex++;
        //        }
        //        lawyerSelectionComboBox.SelectedIndex = index;
        //    }
        //    else
        //    {
        //        lawyerSelectionComboBox.SelectedIndex = -1;
        //    }
        //}

        /// <summary>
        /// Add user Gender or Company type.
        /// </summary>
        /// 
        private void maleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            person.Gender = gender.Male;
            //CompanyTypeComboBox.Items.Clear();
            //CompanyTypeComboBox.Items.Add("");
            CompanyTypeComboBox.SelectedIndex = -1;

            companyTitelLabel.Hide();
            companyTitelTextBox.Hide();
            companyTitelTextBox.Text = "";
        }

        private void femaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            person.Gender = gender.Female;
            //CompanyTypeComboBox.Items.Clear();
            //CompanyTypeComboBox.Items.Add("");
            CompanyTypeComboBox.SelectedIndex = -1;

            companyTitelLabel.Hide();
            companyTitelTextBox.Hide();
            companyTitelTextBox.Text = "";
        }

        private void companyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            person.Gender = gender.Company;

            // TODO (Enable ComboBox here, and disable elsewhere.
            // Enable ComboBox here to enable user to select the company type.
            // temporary solution.
            //ConstValues constValues = new ConstValues();


            companyTitelLabel.Show();
            companyTitelTextBox.Show();

        }


        /// <summary>
        /// Add user Contracts.
        /// </summary>
        /// 
        private void addContractButton_Click(object sender, EventArgs e)
        {
            if (phoneNumberContractTextBox.Text == "" || contractNumberTextBox.Text == "" || contractDateTextBox.Text == "" || contractDurationComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please provide a phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Contract cont = new()
                {
                    PhoneNumber = phoneNumberContractTextBox.Text,
                    Number = contractNumberTextBox.Text,
                    Durration = ContractDuration[contractDurationComboBox.SelectedIndex]
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
                    MessageBox.Show("Unable to read Date value", "unrecognizable Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                person.orderforPayment.contracts.Add(cont);


                phoneContractsListBox.Items.Clear();
                // update the list box
                foreach (Contract p in person.orderforPayment.contracts)
                {
                    phoneContractsListBox.Items.Add(p.Show);
                }

                // clear the boxs in anticpation for new contract
                // TODO
                // move this to a function
                phoneNumberContractTextBox.Text = null;
                contractNumberTextBox.Text = null;
                contractDateTextBox.Text = null;
                contractDurationComboBox.SelectedIndex = -1;
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
            foreach (Contract p in person.orderforPayment.contracts)
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
                Bills cont = new();
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
                        double amount = new();
                        string str = new(billAmountTextBox.Text.Replace(',', '.'));
                        bool amountParseResult = double.TryParse(str, out amount);
                        if (amountParseResult)
                        {
                            cont.IssueDate = date;
                            cont.Amount = amount;
                            person.orderforPayment.bills.Add(cont);
                        }
                        else
                        {
                            MessageBox.Show("Unable to read Amount value", "unrecognizable Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Unable to read Date value", "unrecognizable Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Unable to read Date value", "unrecognizable Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            Form1 NewForm = new();
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
            //throw new NotImplementedException();
            //RTFOptions.SetRTFOptions(person);
            //MessageBox.Show($"{person.orderforPayment.CompanyType} {CompanyTypeComboBox.SelectedIndex.ToString()} ");
            //MessageBox.Show(person.orderforPayment.Debt.ToString());

            //CreateRTF.Test(person);

            //MessageBox.Show(RTFGen.NumberToText(person.orderforPayment.Debt));

            //MessageBox.Show($"First bill: {RTFGen.FirstBill(person).IssueDate.ToShortDateString()}, Last bill: {RTFGen.LastBill(person).IssueDate.ToShortDateString()}");

            MessageBox.Show(person.orderforPayment.PrintDebt);

        }

        /// <summary>
        /// Menu Bar Items.
        /// </summary>
        /// 
        private void addCourtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourt addcourt = new AddCourt();
            this.Hide();
            addcourt.ShowDialog();
            this.Show();
            if (addcourt.newCourt != null)
            {
                CourtsList.Add(addcourt.newCourt);
                RTFGen.SaveCourts(CourtsList);
                CourtsList.Clear();
                CourtsList = RTFGen.LoadCourts();

                //courtSelectionComboBox.Items.Clear();
                courtSelectionComboBox.DataSource = CourtsList;
                courtSelectionComboBox.SelectedIndex = -1;
                //foreach (var court in CourtsList)
                //{
                //    courtSelectionComboBox.Items.Add(court.Show);
                //}

            }


            addcourt.Dispose();
        }

        private void addLawyerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLawyer addlawyer = new AddLawyer();
            this.Hide();
            addlawyer.ShowDialog();
            this.Show();
            if (addlawyer.newLawyer != null)
            {
                LawyersList.Add(addlawyer.newLawyer);
                RTFGen.SaveLawyers(LawyersList);
                LawyersList = RTFGen.LoadLawyers();

                lawyerSelectionComboBox.DataSource = LawyersList;
                lawyerSelectionComboBox.SelectedIndex = -1;
            }
        }

        // Change of Address Application
        private void AddressChangeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AddressChangeCheckBox.Checked)
            {
                person.orderforPayment.AddressChange = true;
            }
            else if (!AddressChangeCheckBox.Checked)
            {
                person.orderforPayment.AddressChange = false;
            }
        }

        private void addressChangeApplicationNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            person.orderforPayment.ChangeOfAddressApplication.ApplicationNumber = addressChangeApplicationNumberTextBox.Text;
        }

        private void addressChangeApplicationDateTextBox_TextChanged(object sender, EventArgs e)
        {
            DateTime date = DateTime.MinValue;
            bool parseResult = DateTime.TryParse(addressChangeApplicationDateTextBox.Text, out date);
            if (parseResult)
            {
                //parse was successful, continue
                person.orderforPayment.ChangeOfAddressApplication.ApplicationDate = date;
            }
            else
            {
                MessageBox.Show("Unable to read Date value", "unrecognizable Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}