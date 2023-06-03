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
using System.Globalization;

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

            contractTypeLabel.Visible = false;
            contractTypeTextBox.Visible = false;


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

            toolStripStatusLabel.Text = "Ready . . .";
            toolStripProgressBar.Value = 0;
        }




        #region Add User Information.
        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            person.FirstName = firstNameTextBox.Text;
            if (toolStripProgressBar.Value < 100)
            {
                toolStripStatusLabel.Text = $"Registring User information, First Name: {person.FirstName} . . .";
                toolStripProgressBar.Value += 1;
            }
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            person.LastName = lastNameTextBox.Text;
            if (toolStripProgressBar.Value < 100)
            {
                toolStripStatusLabel.Text = $"Registring User information, Last Name: {person.LastName} . . .";
                toolStripProgressBar.Value += 1;
            }
        }

        private void fatherNameTextBox_TextChanged(object sender, EventArgs e)
        {
            person.FatherName = fatherNameTextBox.Text;
            if (toolStripProgressBar.Value < 100)
            {
                toolStripStatusLabel.Text = $"Registring User information, Father Name: {person.FatherName} . . .";
                toolStripProgressBar.Value += 1;
            }
        }

        private void taxNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            person.TaxNumber = taxNumberTextBox.Text;
            if (toolStripProgressBar.Value < 100)
            {
                toolStripStatusLabel.Text = $"Registring User information, Tax Number: {person.TaxNumber} . . .";
                toolStripProgressBar.Value += 1;
            }
        }

        private void streetTextBox_TextChanged(object sender, EventArgs e)
        {
            person.FirstAddress.Street = streetTextBox.Text;
            if (toolStripProgressBar.Value < 100)
            {
                toolStripStatusLabel.Text = $"Registring User information, Street: {person.FirstAddress.Street} . . .";
                toolStripProgressBar.Value += 1;
            }
        }

        private void streetNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            person.FirstAddress.StrNumber = streetNumberTextBox.Text;
            if (toolStripProgressBar.Value < 100)
            {
                toolStripStatusLabel.Text = $"Registring User information, Street Number: {person.FirstAddress.StrNumber} . . .";
                toolStripProgressBar.Value += 1;
            }
        }

        private void streetNameTextBox_TextChanged(object sender, EventArgs e)
        {
            person.FirstAddress.City = streetNameTextBox.Text;
            if (toolStripProgressBar.Value < 100)
            {
                toolStripStatusLabel.Text = $"Registring User information, Street Name: {person.FirstAddress.City} . . .";
                toolStripProgressBar.Value += 1;
            }
        }

        private void zipCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            person.FirstAddress.PostalCode = zipCodeTextBox.Text;

            if (toolStripProgressBar.Value < 100)
            {
                toolStripStatusLabel.Text = $"Registring User information, POSTAL CODE: {person.FirstAddress.PostalCode} . . .";
                toolStripProgressBar.Value += 1;
            }
        }

        private void companyTitelTextBox_TextChanged(object sender, EventArgs e)
        {
            person.Title = companyTitelTextBox.Text;

            if (toolStripProgressBar.Value < 100)
            {
                toolStripStatusLabel.Text = $"Registring User information Company Title: {person.Title} . . .";
                toolStripProgressBar.Value += 1;
            }
        }
        private void maleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (toolStripProgressBar.Value < 100)
            {
                toolStripStatusLabel.Text = "Registring User information . . .";
                toolStripProgressBar.Value += 1;
            }
            person.Gender = gender.Male;

            CompanyTypeComboBox.SelectedIndex = -1;

            companyTitelLabel.Hide();
            companyTitelTextBox.Hide();
            companyTitelTextBox.Text = "";
        }

        private void femaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (toolStripProgressBar.Value < 100)
            {
                toolStripStatusLabel.Text = "Registring User information . . .";
                toolStripProgressBar.Value += 1;
            }
            person.Gender = gender.Female;

            CompanyTypeComboBox.SelectedIndex = -1;

            companyTitelLabel.Hide();
            companyTitelTextBox.Hide();
            companyTitelTextBox.Text = "";
        }

        private void companyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            person.Gender = gender.Company;

            if (toolStripProgressBar.Value < 100)
            {
                toolStripStatusLabel.Text = "Registring User Company Information . . .";
                toolStripProgressBar.Value += 1;
            }

            companyTitelLabel.Show();
            companyTitelTextBox.Show();
        }
        #endregion Add User Information.

        #region Order For Payment Advanced Options.
        private void judicialStampTextBox_TextChanged(object sender, EventArgs e)
        {
            //ΤΝ, ΤΠΔΑ, ΤΑΧΔΙΚ(Α264794) και γραμμάτιο προείσπραξης Δ.Σ.Α. (Π4350411).
            if (toolStripProgressBar.Value < 100)
            {
                toolStripStatusLabel.Text = "Modifying the Order For Payment oprions . . .";
                toolStripProgressBar.Value += 1;
            }
            person.orderforPayment.TAXDIK = judicialStampTextBox.Text;
        }

        private void promissoryNoteTextBox_TextChanged(object sender, EventArgs e)
        {
            //ΤΝ, ΤΠΔΑ, ΤΑΧΔΙΚ(Α264794) και γραμμάτιο προείσπραξης Δ.Σ.Α. (Π4350411).
            if (toolStripProgressBar.Value < 100)
            {
                toolStripStatusLabel.Text = "Modifying the Order For Payment oprions . . .";
                toolStripProgressBar.Value += 1;
            }

            person.orderforPayment.DSA = promissoryNoteTextBox.Text;
        }

        private void athensJurisdictionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (toolStripProgressBar.Value < 100)
            {
                toolStripStatusLabel.Text = "Modifying the Order For Payment oprions . . .";
                toolStripProgressBar.Value += 1;
            }

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
            if (toolStripProgressBar.Value < 100)
            {
                toolStripStatusLabel.Text = "Modifying the Order For Payment oprions . . .";
                toolStripProgressBar.Value += 1;
            }

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

                if (toolStripProgressBar.Value < 100)
                {
                    toolStripStatusLabel.Text = $"Selecting Court {person.orderforPayment.CourtName.CapitalName}. . .";
                    toolStripProgressBar.Value += 1;
                }
            }
        }

        private void lawyerSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lawyerSelectionComboBox.SelectedIndex != -1)
            {
                person.orderforPayment.LawyerName = LawyersList[lawyerSelectionComboBox.SelectedIndex];

                if (toolStripProgressBar.Value < 100)
                {
                    toolStripStatusLabel.Text = $"Selecting Lawyer {person.orderforPayment.LawyerName.Show}. . .";
                    toolStripProgressBar.Value += 1;
                }
            }
        }

        private void totalAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            double amount;
            string str = totalAmountTextBox.Text;
            bool amountParseResult = double.TryParse(str, NumberStyles.Currency, CultureInfo.GetCultureInfo("el-GR"), out amount);

            if (amountParseResult)
            {
                person.orderforPayment.Debt = amount;

                if (toolStripProgressBar.Value < 100)
                {
                    toolStripStatusLabel.Text = $"Adding the Dept amount: {person.orderforPayment.Debt}. . .";
                    toolStripProgressBar.Value += 1;
                }
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

                if (toolStripProgressBar.Value < 100)
                {
                    toolStripStatusLabel.Text = $"Selecting Company Type {person.orderforPayment.CompanyType}. . .";
                    toolStripProgressBar.Value += 1;
                }
            }

        }

        // Change of Address Application
        private void AddressChangeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (toolStripProgressBar.Value < 100)
            {
                toolStripStatusLabel.Text = "Modifying Court Options . . .";
                toolStripProgressBar.Value += 1;
            }

            if (AddressChangeCheckBox.Checked)
            {
                person.orderforPayment.AddressChange = true;
            }
            else if (!AddressChangeCheckBox.Checked)
            {
                person.orderforPayment.AddressChange = false;
            }
        }

        private void IdChangeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (toolStripProgressBar.Value < 100)
            {
                toolStripStatusLabel.Text = "Modifying Court Options . . .";
                toolStripProgressBar.Value += 1;
            }

            if (IdChangeCheckBox.Checked)
            {
                person.orderforPayment.IdChange = true;
            }
            else if (!IdChangeCheckBox.Checked)
            {
                person.orderforPayment.IdChange = false;
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
        }

        private void remunerationFromTextBox_TextChanged(object sender, EventArgs e)
        {
            DateTime date = DateTime.MinValue;
            Bills bill = new Bills();
            bool parseResult = DateTime.TryParse(remunerationFromTextBox.Text, out date);
            if (parseResult)
            {
                bill.IssueDate = date;
                person.orderforPayment.RemunerationDate.Add(bill);
            }
        }

        private void remunerationToTextBox_TextChanged(object sender, EventArgs e)
        {
            DateTime date = DateTime.MinValue;
            Bills bill = new Bills();
            bool parseResult = DateTime.TryParse(remunerationToTextBox.Text, out date);
            if (parseResult)
            {
                bill.IssueDate = date;
                person.orderforPayment.RemunerationDate.Add(bill);
            }
        }

        #endregion Order For Payment Advanced Options.

        #region Modify Contracts.
        private void addContractButton_Click(object sender, EventArgs e)
        {
            if (phoneNumberContractTextBox.Text == "" || contractNumberTextBox.Text == "" || contractDateTextBox.Text == "" || contractDurationComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please provide a phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // In casee to Add with a Sim Card instade of phone number.
            else if (contractTypeLabel.Visible == true)
            {

                Contract cont = new()
                {
                    PhoneNumber = phoneNumberContractTextBox.Text,
                    Number = contractNumberTextBox.Text,
                    Durration = ContractDuration[contractDurationComboBox.SelectedIndex],
                    ContractType = contractTypeTextBox.Text
                };

                DateTime date = DateTime.MinValue;
                bool parseResult = DateTime.TryParse(contractDateTextBox.Text, out date);
                if (parseResult)
                {
                    //parse was successful, continue
                    cont.Date = date;
                }

                person.orderforPayment.contracts.Add(cont);

                if (toolStripProgressBar.Value < 100)
                {
                    toolStripStatusLabel.Text = $"Adding New Contract With SIM number: {cont.Show} . . .";
                    toolStripProgressBar.Value += 2;
                }


                phoneContractsListBox.Items.Clear();
                // update the list box
                foreach (Contract p in person.orderforPayment.contracts)
                {
                    phoneContractsListBox.Items.Add(p.Show);
                }

                phoneNumberContractTextBox.Text = null;
                contractNumberTextBox.Text = null;
                contractDateTextBox.Text = null;
                contractDurationComboBox.SelectedIndex = -1;

                contractTypeLabel.Visible = false;
                contractTypeTextBox.Visible = false;

            }
            else
            {

                Contract cont = new()
                {
                    PhoneNumber = phoneNumberContractTextBox.Text,
                    Number = contractNumberTextBox.Text,
                    Durration = ContractDuration[contractDurationComboBox.SelectedIndex]
                };

                DateTime date = DateTime.MinValue;
                bool parseResult = DateTime.TryParse(contractDateTextBox.Text, out date);
                if (parseResult)
                {
                    //parse was successful, continue
                    cont.Date = date;
                }

                person.orderforPayment.contracts.Add(cont);
                if (toolStripProgressBar.Value < 100)
                {
                    toolStripStatusLabel.Text = $"Adding New Contract: {cont.Show} . . .";
                    toolStripProgressBar.Value += 2;
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
                contractDurationComboBox.SelectedIndex = -1;

                contractTypeLabel.Visible = false;
                contractTypeTextBox.Visible = false;
            }
        }

        private void removeContractButton_Click(object sender, EventArgs e)
        {
            if (phoneContractsListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select a contract to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //var toRemove = person.orderforPayment.contracts.RemoveAll(r => r.PhoneNumber == phoneNumberContractTextBox.Text);
                person.orderforPayment.contracts.RemoveAt(phoneContractsListBox.SelectedIndex);
                if (toolStripProgressBar.Value < 100)
                {
                    toolStripStatusLabel.Text = $"Removing Contract: {phoneNumberContractTextBox.Text}. . .";
                    toolStripProgressBar.Value -= 2;
                }
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
        #endregion Modify Contracts.

        #region Modify Bills.
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

                        if (toolStripProgressBar.Value < 100)
                        {
                            toolStripStatusLabel.Text = $"Adding New Bill {cont.Show}. . .";
                            toolStripProgressBar.Value += 2;
                        }
                    }
                    else
                    {
                        double amount;
                        string str = billAmountTextBox.Text;
                        bool amountParseResult = double.TryParse(str, NumberStyles.Currency, CultureInfo.GetCultureInfo("el-GR"), out amount);
                        if (amountParseResult)
                        {
                            cont.IssueDate = date;
                            cont.Amount = amount;
                            person.orderforPayment.bills.Add(cont);

                            if (toolStripProgressBar.Value < 100)
                            {
                                toolStripStatusLabel.Text = $"Adding New Bill {cont.Show}. . .";
                                toolStripProgressBar.Value += 2;
                            }

                            // SHOW THE REMUNERATION GROUP IF AN AMOUNT WAS PROVIDED.
                            remunerationGroupBox.Visible = true;
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

                // show remunerationGroupBox if the user give amount.


            }
        }

        private void removeBillButton_Click(object sender, EventArgs e)
        {
            if (billsListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Bill to be removed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                person.orderforPayment.bills.RemoveAt(billsListBox.SelectedIndex);

                if (toolStripProgressBar.Value < 100)
                {
                    toolStripStatusLabel.Text = $"Removing Bill {billDateTextBox.Text}. . .";
                    toolStripProgressBar.Value -= 2;
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
        private void addSimNumberButton_Click(object sender, EventArgs e)
        {
            contractTypeLabel.Visible = true;
            contractTypeTextBox.Visible = true;
        }

        #endregion Modify Bills.

        #region Menu Bar.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripProgressBar.Value < 100)
            {
                toolStripStatusLabel.Text = "Exiting Application . . .";
                toolStripProgressBar.Value = 0;
            }
            if (MessageBox.Show("Are you sure you want to close", "Leave Program?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

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

                courtSelectionComboBox.DataSource = CourtsList;
                courtSelectionComboBox.SelectedIndex = -1;

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

        #endregion Menu Bar.

        #region Buttons.
        private void GeneratePaymenOrderBbutton_Click(object sender, EventArgs e)
        {
            if(cosmoteRadioButton.Checked)
            {
                //toolStripStatusLabel.Text = "Ready . . .";
                // Generate Payment Order Here.
                toolStripStatusLabel.Text = "Generating Cosmote OFP . . .";


                CreateRTFCMS.Generate(person);
                //MessageBox.Show($"Test if person info is passed: ({person.FirstName} Postal Code: {person.FirstAddress.PostalCode})");
                toolStripStatusLabel.Text = "Done . . .";
                toolStripProgressBar.Value = 100;
            }
            else if(oteRadioButton.Checked)
            {
                //toolStripStatusLabel.Text = "Ready . . .";
                // Generate Payment Order Here.
                toolStripStatusLabel.Text = "Generating OTE OFP . . .";


                CreateRTFOTE.Generate(person);
                //MessageBox.Show($"Test if person info is passed: ({person.FirstName} Postal Code: {person.FirstAddress.PostalCode})");
                toolStripStatusLabel.Text = "Done . . .";
                toolStripProgressBar.Value = 100;
            }
            else
            {
                MessageBox.Show("You must Select the Order Type (Cosmote or OTE)!", "OFP type not selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {

            person = new Person();

            // Clear Text Boxes
            firstNameTextBox.Text = "";
            fatherNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            taxNumberTextBox.Text = "";
            companyTitelTextBox.Text = "";
            totalAmountTextBox.Text = "";
            judicialStampTextBox.Text = "";
            promissoryNoteTextBox.Text = "";
            remunerationFromTextBox.Text = "";
            remunerationToTextBox.Text = "";
            addressChangeApplicationDateTextBox.Text = "";
            addressChangeApplicationNumberTextBox.Text = "";
            streetNameTextBox.Text = "";
            streetTextBox.Text = "";
            streetNumberTextBox.Text = "";
            zipCodeTextBox.Text = "";
            
            // Clear Selected Radio buttons
            maleRadioButton.Checked = false;
            femaleRadioButton.Checked = false;
            companyRadioButton.Checked = false;
            cosmoteRadioButton.Checked = false;
            oteRadioButton.Checked = false;

            // Clear CheckBox
            athensJurisdictionCheckBox.Checked = false;
            challengeRequestCheckBox.Checked = false;
            AddressChangeCheckBox.Checked = false;
            IdChangeCheckBox.Checked = false;

            courtSelectionComboBox.SelectedIndex = -1;
            lawyerSelectionComboBox.SelectedIndex = -1;
            CompanyTypeComboBox.SelectedIndex = -1;

            phoneContractsListBox.Items.Clear();
            billsListBox.Items.Clear();

            remunerationGroupBox.Visible = false;
            companyTitelTextBox.Visible = false;
            companyTitelLabel.Visible = false;
        }

        /// <summary>
        /// TEST BUTTON. TO BE REMOVED LATER.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void testButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(person.Print(), "User Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        #endregion Buttons.


        private void removeCourtButton_Click(object sender, EventArgs e)
        {
            if (courtSelectionComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Plese select a court to remove", "Unable to Remove Court", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult d =MessageBox.Show("Are you sure you want to delete the selected Court from the list?", "Test Titel", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                if (d == DialogResult.Yes)
                {
                    // Delete the selected Court
                    CourtsList.RemoveAt(courtSelectionComboBox.SelectedIndex);
                    RTFGen.SaveCourts(CourtsList);
                    
                    courtSelectionComboBox.DataBindings.Clear();
                    CourtsList = RTFGen.LoadCourts();
                    courtSelectionComboBox.DataSource = CourtsList;
                    courtSelectionComboBox.SelectedIndex = -1;
                    
                }
            }
        }

        private void removeLawyerButton_Click(object sender, EventArgs e)
        {
            if (lawyerSelectionComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Plese select a lawyer to remove", "Unable to Remove Lawer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult d = MessageBox.Show("Are you sure you want to delete the selected Lawyer from the list?", "Test Titel", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                if(d == DialogResult.Yes)
                {
                    // Delete the selecte Lawyer
                    LawyersList.RemoveAt(lawyerSelectionComboBox.SelectedIndex);
                    RTFGen.SaveLawyers(LawyersList);

                    lawyerSelectionComboBox.DataBindings.Clear();
                    LawyersList = RTFGen.LoadLawyers();
                    lawyerSelectionComboBox.DataSource = LawyersList;
                    lawyerSelectionComboBox.SelectedIndex= -1;
                    
                }
            }
            
        }
    }

}