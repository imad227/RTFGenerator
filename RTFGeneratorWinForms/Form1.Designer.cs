using RTFGeneratorLibrary;

namespace RTFGeneratorWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            statusStrip1 = new StatusStrip();
            toolStripProgressBar = new ToolStripProgressBar();
            toolStripStatusLabel = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            loadFromFileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            addCourtToolStripMenuItem = new ToolStripMenuItem();
            addLawyerToolStripMenuItem = new ToolStripMenuItem();
            addContractsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            checkForUpdateToolStripMenuItem = new ToolStripMenuItem();
            userInfoGroupBox = new GroupBox();
            zipCodeTextBox = new TextBox();
            zipCodeLabel = new Label();
            streetNameTextBox = new TextBox();
            CityNameLabel = new Label();
            streetNumberTextBox = new TextBox();
            streetNumberLabel = new Label();
            streetTextBox = new TextBox();
            streetLabel = new Label();
            label1 = new Label();
            taxNumberTextBox = new TextBox();
            taxNumberLabel = new Label();
            fatherNameTextBox = new TextBox();
            fatherNameLabel = new Label();
            lastNameTextBox = new TextBox();
            lasNameLabel = new Label();
            firstNameTextBox = new TextBox();
            firstNameLabel = new Label();
            GeneratePaymenOrderBbutton = new Button();
            genderGroupBox = new GroupBox();
            companyTitelLabel = new Label();
            companyTitelTextBox = new TextBox();
            CompanyTypeComboBox = new ComboBox();
            companyRadioButton = new RadioButton();
            femaleRadioButton = new RadioButton();
            maleRadioButton = new RadioButton();
            contractsGroupBox = new GroupBox();
            contractTypeTextBox = new TextBox();
            contractTypeLabel = new Label();
            contractDurationComboBox = new ComboBox();
            addSimNumberButton = new Button();
            phoneContractsListBox = new ListBox();
            removeContractButton = new Button();
            addContractButton = new Button();
            contractDateTextBox = new TextBox();
            phoneNumberContractTextBox = new TextBox();
            ContractDateLabel = new Label();
            phnoeNumberLabel = new Label();
            contractNumberTextBox = new TextBox();
            contractNumberLabel = new Label();
            billsGroupBox = new GroupBox();
            billAmountTextBox = new TextBox();
            billAmountLabel = new Label();
            billsListBox = new ListBox();
            removeBillButton = new Button();
            billDateTextBox = new TextBox();
            addBillButton = new Button();
            billDateLabel = new Label();
            clearAllButton = new Button();
            typeGroupBox = new GroupBox();
            removeLawyerButton = new Button();
            removeCourtButton = new Button();
            selectLawyerLabel = new Label();
            lawyerSelectionComboBox = new ComboBox();
            selectCourtLabel = new Label();
            courtSelectionComboBox = new ComboBox();
            oteRadioButton = new RadioButton();
            cosmoteRadioButton = new RadioButton();
            advancedOptionsGroupBox = new GroupBox();
            addressChangeGroupBox = new GroupBox();
            IdChangeCheckBox = new CheckBox();
            addressChangeApplicationDateTextBox = new TextBox();
            addressChangeApplicationDateLabel = new Label();
            addressChangeApplicationNumberTextBox = new TextBox();
            addressChangeApplicationNumberLabel = new Label();
            AddressChangeCheckBox = new CheckBox();
            challengeRequestCheckBox = new CheckBox();
            athensJurisdictionCheckBox = new CheckBox();
            totalAmountTextBox = new TextBox();
            totalAmountLabel = new Label();
            testButton = new Button();
            promissoryNoteTextBox = new TextBox();
            promissoryNoteLabel = new Label();
            judicialStampTextBox = new TextBox();
            judicialStampLabel = new Label();
            remunerationGroupBox = new GroupBox();
            remunerationToTextBox = new TextBox();
            remunerationToLabel = new Label();
            remunerationFromTextBox = new TextBox();
            remunerationFromLabel = new Label();
            searchGroupBox = new GroupBox();
            searchButton = new Button();
            caseNumberTextBox = new TextBox();
            caseNumberLabel = new Label();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            userInfoGroupBox.SuspendLayout();
            genderGroupBox.SuspendLayout();
            contractsGroupBox.SuspendLayout();
            billsGroupBox.SuspendLayout();
            typeGroupBox.SuspendLayout();
            advancedOptionsGroupBox.SuspendLayout();
            addressChangeGroupBox.SuspendLayout();
            remunerationGroupBox.SuspendLayout();
            searchGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripProgressBar, toolStripStatusLabel });
            statusStrip1.Location = new Point(0, 937);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1081, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar
            // 
            toolStripProgressBar.Name = "toolStripProgressBar";
            toolStripProgressBar.Size = new Size(100, 16);
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(57, 17);
            toolStripStatusLabel.Text = "Ready .....";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1081, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadFromFileToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // loadFromFileToolStripMenuItem
            // 
            loadFromFileToolStripMenuItem.Name = "loadFromFileToolStripMenuItem";
            loadFromFileToolStripMenuItem.Size = new Size(150, 22);
            loadFromFileToolStripMenuItem.Text = "&Load from File";
            loadFromFileToolStripMenuItem.Click += loadFromFileToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(150, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addCourtToolStripMenuItem, addLawyerToolStripMenuItem, addContractsToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(46, 20);
            toolsToolStripMenuItem.Text = "&Tools";
            // 
            // addCourtToolStripMenuItem
            // 
            addCourtToolStripMenuItem.Name = "addCourtToolStripMenuItem";
            addCourtToolStripMenuItem.Size = new Size(150, 22);
            addCourtToolStripMenuItem.Text = "Add &Court";
            addCourtToolStripMenuItem.Click += addCourtToolStripMenuItem_Click;
            // 
            // addLawyerToolStripMenuItem
            // 
            addLawyerToolStripMenuItem.Name = "addLawyerToolStripMenuItem";
            addLawyerToolStripMenuItem.Size = new Size(150, 22);
            addLawyerToolStripMenuItem.Text = "Add &Lawyer";
            addLawyerToolStripMenuItem.Click += addLawyerToolStripMenuItem_Click;
            // 
            // addContractsToolStripMenuItem
            // 
            addContractsToolStripMenuItem.Name = "addContractsToolStripMenuItem";
            addContractsToolStripMenuItem.Size = new Size(150, 22);
            addContractsToolStripMenuItem.Text = "Add C&ontracts";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, checkForUpdateToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(166, 22);
            aboutToolStripMenuItem.Text = "&About";
            // 
            // checkForUpdateToolStripMenuItem
            // 
            checkForUpdateToolStripMenuItem.Name = "checkForUpdateToolStripMenuItem";
            checkForUpdateToolStripMenuItem.Size = new Size(166, 22);
            checkForUpdateToolStripMenuItem.Text = "Check for &Update";
            // 
            // userInfoGroupBox
            // 
            userInfoGroupBox.Controls.Add(zipCodeTextBox);
            userInfoGroupBox.Controls.Add(zipCodeLabel);
            userInfoGroupBox.Controls.Add(streetNameTextBox);
            userInfoGroupBox.Controls.Add(CityNameLabel);
            userInfoGroupBox.Controls.Add(streetNumberTextBox);
            userInfoGroupBox.Controls.Add(streetNumberLabel);
            userInfoGroupBox.Controls.Add(streetTextBox);
            userInfoGroupBox.Controls.Add(streetLabel);
            userInfoGroupBox.Controls.Add(label1);
            userInfoGroupBox.Controls.Add(taxNumberTextBox);
            userInfoGroupBox.Controls.Add(taxNumberLabel);
            userInfoGroupBox.Controls.Add(fatherNameTextBox);
            userInfoGroupBox.Controls.Add(fatherNameLabel);
            userInfoGroupBox.Controls.Add(lastNameTextBox);
            userInfoGroupBox.Controls.Add(lasNameLabel);
            userInfoGroupBox.Controls.Add(firstNameTextBox);
            userInfoGroupBox.Controls.Add(firstNameLabel);
            userInfoGroupBox.ForeColor = SystemColors.ControlText;
            userInfoGroupBox.Location = new Point(8, 45);
            userInfoGroupBox.Name = "userInfoGroupBox";
            userInfoGroupBox.Size = new Size(293, 291);
            userInfoGroupBox.TabIndex = 0;
            userInfoGroupBox.TabStop = false;
            userInfoGroupBox.Text = "ΣΤΟΙΧΕΙΑ ΟΦΕΙΛΕΤΗ";
            // 
            // zipCodeTextBox
            // 
            zipCodeTextBox.Location = new Point(210, 245);
            zipCodeTextBox.Name = "zipCodeTextBox";
            zipCodeTextBox.Size = new Size(77, 27);
            zipCodeTextBox.TabIndex = 9;
            zipCodeTextBox.TextChanged += zipCodeTextBox_TextChanged;
            // 
            // zipCodeLabel
            // 
            zipCodeLabel.AutoSize = true;
            zipCodeLabel.Location = new Point(168, 248);
            zipCodeLabel.Name = "zipCodeLabel";
            zipCodeLabel.Size = new Size(32, 20);
            zipCodeLabel.TabIndex = 0;
            zipCodeLabel.Text = "Τ.Κ.";
            // 
            // streetNameTextBox
            // 
            streetNameTextBox.Location = new Point(48, 245);
            streetNameTextBox.Name = "streetNameTextBox";
            streetNameTextBox.Size = new Size(114, 27);
            streetNameTextBox.TabIndex = 8;
            streetNameTextBox.TextChanged += streetNameTextBox_TextChanged;
            // 
            // CityNameLabel
            // 
            CityNameLabel.AutoSize = true;
            CityNameLabel.Location = new Point(4, 248);
            CityNameLabel.Name = "CityNameLabel";
            CityNameLabel.Size = new Size(51, 20);
            CityNameLabel.TabIndex = 0;
            CityNameLabel.Text = "ΠΟΛΗ";
            // 
            // streetNumberTextBox
            // 
            streetNumberTextBox.Location = new Point(210, 212);
            streetNumberTextBox.Name = "streetNumberTextBox";
            streetNumberTextBox.Size = new Size(77, 27);
            streetNumberTextBox.TabIndex = 7;
            streetNumberTextBox.TextChanged += streetNumberTextBox_TextChanged;
            // 
            // streetNumberLabel
            // 
            streetNumberLabel.AutoSize = true;
            streetNumberLabel.Location = new Point(168, 215);
            streetNumberLabel.Name = "streetNumberLabel";
            streetNumberLabel.Size = new Size(45, 20);
            streetNumberLabel.TabIndex = 0;
            streetNumberLabel.Text = "ΑΡΙΘ.";
            // 
            // streetTextBox
            // 
            streetTextBox.Location = new Point(48, 212);
            streetTextBox.Name = "streetTextBox";
            streetTextBox.Size = new Size(114, 27);
            streetTextBox.TabIndex = 6;
            streetTextBox.TextChanged += streetTextBox_TextChanged;
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new Point(4, 215);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new Size(49, 20);
            streetLabel.TabIndex = 0;
            streetLabel.Text = "ΟΔΟΣ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 189);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 0;
            label1.Text = "ΔΙΕΥΘΥΝΣΗ";
            // 
            // taxNumberTextBox
            // 
            taxNumberTextBox.Location = new Point(98, 148);
            taxNumberTextBox.Name = "taxNumberTextBox";
            taxNumberTextBox.Size = new Size(189, 27);
            taxNumberTextBox.TabIndex = 10;
            taxNumberTextBox.TextChanged += taxNumberTextBox_TextChanged;
            // 
            // taxNumberLabel
            // 
            taxNumberLabel.AutoSize = true;
            taxNumberLabel.Location = new Point(2, 151);
            taxNumberLabel.Name = "taxNumberLabel";
            taxNumberLabel.Size = new Size(43, 20);
            taxNumberLabel.TabIndex = 0;
            taxNumberLabel.Text = "ΑΦΜ";
            // 
            // fatherNameTextBox
            // 
            fatherNameTextBox.Location = new Point(98, 92);
            fatherNameTextBox.Name = "fatherNameTextBox";
            fatherNameTextBox.Size = new Size(189, 27);
            fatherNameTextBox.TabIndex = 5;
            fatherNameTextBox.TextChanged += fatherNameTextBox_TextChanged;
            // 
            // fatherNameLabel
            // 
            fatherNameLabel.AutoSize = true;
            fatherNameLabel.Location = new Point(0, 95);
            fatherNameLabel.Name = "fatherNameLabel";
            fatherNameLabel.Size = new Size(101, 20);
            fatherNameLabel.TabIndex = 0;
            fatherNameLabel.Text = "ΟΝ. ΠΑΤΕΡΑΣ";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(98, 59);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(189, 27);
            lastNameTextBox.TabIndex = 4;
            lastNameTextBox.TextChanged += lastNameTextBox_TextChanged;
            // 
            // lasNameLabel
            // 
            lasNameLabel.AutoSize = true;
            lasNameLabel.Location = new Point(2, 62);
            lasNameLabel.Name = "lasNameLabel";
            lasNameLabel.Size = new Size(83, 20);
            lasNameLabel.TabIndex = 0;
            lasNameLabel.Text = "ΕΠΏΝΥΜΟ";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(98, 26);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(189, 27);
            firstNameTextBox.TabIndex = 3;
            firstNameTextBox.TextChanged += firstNameTextBox_TextChanged;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(2, 29);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(65, 20);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "ΟΝΟΜΑ";
            // 
            // GeneratePaymenOrderBbutton
            // 
            GeneratePaymenOrderBbutton.Location = new Point(941, 875);
            GeneratePaymenOrderBbutton.Name = "GeneratePaymenOrderBbutton";
            GeneratePaymenOrderBbutton.Size = new Size(107, 45);
            GeneratePaymenOrderBbutton.TabIndex = 43;
            GeneratePaymenOrderBbutton.Text = "Generate";
            GeneratePaymenOrderBbutton.UseVisualStyleBackColor = true;
            GeneratePaymenOrderBbutton.Click += GeneratePaymenOrderBbutton_Click;
            // 
            // genderGroupBox
            // 
            genderGroupBox.Controls.Add(companyTitelLabel);
            genderGroupBox.Controls.Add(companyTitelTextBox);
            genderGroupBox.Controls.Add(CompanyTypeComboBox);
            genderGroupBox.Controls.Add(companyRadioButton);
            genderGroupBox.Controls.Add(femaleRadioButton);
            genderGroupBox.Controls.Add(maleRadioButton);
            genderGroupBox.Location = new Point(8, 342);
            genderGroupBox.Name = "genderGroupBox";
            genderGroupBox.Size = new Size(293, 171);
            genderGroupBox.TabIndex = 0;
            genderGroupBox.TabStop = false;
            genderGroupBox.Text = "Gender";
            // 
            // companyTitelLabel
            // 
            companyTitelLabel.AutoSize = true;
            companyTitelLabel.Location = new Point(10, 99);
            companyTitelLabel.Name = "companyTitelLabel";
            companyTitelLabel.Size = new Size(129, 20);
            companyTitelLabel.TabIndex = 210;
            companyTitelLabel.Text = "ΤΙΤΛΟΣ ΕΤΑΙΡΕΙΑΣ";
            // 
            // companyTitelTextBox
            // 
            companyTitelTextBox.Location = new Point(10, 122);
            companyTitelTextBox.Name = "companyTitelTextBox";
            companyTitelTextBox.Size = new Size(260, 27);
            companyTitelTextBox.TabIndex = 15;
            companyTitelTextBox.TextChanged += companyTitelTextBox_TextChanged;
            // 
            // CompanyTypeComboBox
            // 
            CompanyTypeComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CompanyTypeComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            CompanyTypeComboBox.FormattingEnabled = true;
            CompanyTypeComboBox.Location = new Point(10, 56);
            CompanyTypeComboBox.Name = "CompanyTypeComboBox";
            CompanyTypeComboBox.Size = new Size(260, 28);
            CompanyTypeComboBox.TabIndex = 14;
            CompanyTypeComboBox.SelectedIndexChanged += CompanyTypeComboBox_SelectedIndexChanged;
            // 
            // companyRadioButton
            // 
            companyRadioButton.AutoSize = true;
            companyRadioButton.Location = new Point(182, 26);
            companyRadioButton.Name = "companyRadioButton";
            companyRadioButton.Size = new Size(87, 24);
            companyRadioButton.TabIndex = 13;
            companyRadioButton.TabStop = true;
            companyRadioButton.Text = "ΕΤΑΙΡΕΙΑ";
            companyRadioButton.UseVisualStyleBackColor = true;
            companyRadioButton.CheckedChanged += companyRadioButton_CheckedChanged;
            // 
            // femaleRadioButton
            // 
            femaleRadioButton.AutoSize = true;
            femaleRadioButton.Location = new Point(84, 26);
            femaleRadioButton.Name = "femaleRadioButton";
            femaleRadioButton.Size = new Size(70, 24);
            femaleRadioButton.TabIndex = 12;
            femaleRadioButton.TabStop = true;
            femaleRadioButton.Text = "ΘΗΛΉ";
            femaleRadioButton.UseVisualStyleBackColor = true;
            femaleRadioButton.CheckedChanged += femaleRadioButton_CheckedChanged;
            // 
            // maleRadioButton
            // 
            maleRadioButton.AutoSize = true;
            maleRadioButton.Location = new Point(6, 26);
            maleRadioButton.Name = "maleRadioButton";
            maleRadioButton.Size = new Size(72, 24);
            maleRadioButton.TabIndex = 11;
            maleRadioButton.TabStop = true;
            maleRadioButton.Text = "ΑΡΡΕΝ";
            maleRadioButton.UseVisualStyleBackColor = true;
            maleRadioButton.CheckedChanged += maleRadioButton_CheckedChanged;
            // 
            // contractsGroupBox
            // 
            contractsGroupBox.Controls.Add(contractTypeTextBox);
            contractsGroupBox.Controls.Add(contractTypeLabel);
            contractsGroupBox.Controls.Add(contractDurationComboBox);
            contractsGroupBox.Controls.Add(addSimNumberButton);
            contractsGroupBox.Controls.Add(phoneContractsListBox);
            contractsGroupBox.Controls.Add(removeContractButton);
            contractsGroupBox.Controls.Add(addContractButton);
            contractsGroupBox.Controls.Add(contractDateTextBox);
            contractsGroupBox.Controls.Add(phoneNumberContractTextBox);
            contractsGroupBox.Controls.Add(ContractDateLabel);
            contractsGroupBox.Controls.Add(phnoeNumberLabel);
            contractsGroupBox.Controls.Add(contractNumberTextBox);
            contractsGroupBox.Controls.Add(contractNumberLabel);
            contractsGroupBox.Location = new Point(12, 534);
            contractsGroupBox.Name = "contractsGroupBox";
            contractsGroupBox.Size = new Size(437, 386);
            contractsGroupBox.TabIndex = 201;
            contractsGroupBox.TabStop = false;
            contractsGroupBox.Text = "ΣΥΜΒΑΣΕΙΣ";
            // 
            // contractTypeTextBox
            // 
            contractTypeTextBox.Location = new Point(136, 120);
            contractTypeTextBox.Name = "contractTypeTextBox";
            contractTypeTextBox.Size = new Size(271, 27);
            contractTypeTextBox.TabIndex = 23;
            // 
            // contractTypeLabel
            // 
            contractTypeLabel.AutoSize = true;
            contractTypeLabel.Location = new Point(9, 123);
            contractTypeLabel.Name = "contractTypeLabel";
            contractTypeLabel.Size = new Size(92, 20);
            contractTypeLabel.TabIndex = 204;
            contractTypeLabel.Text = "ΣΥΜΒΟΛΑΙΟ";
            // 
            // contractDurationComboBox
            // 
            contractDurationComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            contractDurationComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            contractDurationComboBox.FormattingEnabled = true;
            contractDurationComboBox.Location = new Point(9, 86);
            contractDurationComboBox.Name = "contractDurationComboBox";
            contractDurationComboBox.Size = new Size(246, 28);
            contractDurationComboBox.TabIndex = 19;
            // 
            // addSimNumberButton
            // 
            addSimNumberButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addSimNumberButton.Location = new Point(261, 86);
            addSimNumberButton.Name = "addSimNumberButton";
            addSimNumberButton.Size = new Size(55, 25);
            addSimNumberButton.TabIndex = 22;
            addSimNumberButton.Text = "SIM";
            addSimNumberButton.UseVisualStyleBackColor = true;
            addSimNumberButton.Click += addSimNumberButton_Click;
            // 
            // phoneContractsListBox
            // 
            phoneContractsListBox.FormattingEnabled = true;
            phoneContractsListBox.ItemHeight = 20;
            phoneContractsListBox.Location = new Point(9, 161);
            phoneContractsListBox.Name = "phoneContractsListBox";
            phoneContractsListBox.Size = new Size(398, 204);
            phoneContractsListBox.TabIndex = 202;
            // 
            // removeContractButton
            // 
            removeContractButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            removeContractButton.Location = new Point(329, 87);
            removeContractButton.Name = "removeContractButton";
            removeContractButton.Size = new Size(29, 25);
            removeContractButton.TabIndex = 21;
            removeContractButton.Text = "-";
            removeContractButton.UseVisualStyleBackColor = true;
            removeContractButton.Click += removeContractButton_Click;
            // 
            // addContractButton
            // 
            addContractButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            addContractButton.Location = new Point(378, 87);
            addContractButton.Name = "addContractButton";
            addContractButton.Size = new Size(29, 25);
            addContractButton.TabIndex = 20;
            addContractButton.Text = "+";
            addContractButton.UseVisualStyleBackColor = true;
            addContractButton.Click += addContractButton_Click;
            // 
            // contractDateTextBox
            // 
            contractDateTextBox.Location = new Point(321, 56);
            contractDateTextBox.Name = "contractDateTextBox";
            contractDateTextBox.Size = new Size(86, 27);
            contractDateTextBox.TabIndex = 18;
            // 
            // phoneNumberContractTextBox
            // 
            phoneNumberContractTextBox.Location = new Point(136, 21);
            phoneNumberContractTextBox.Name = "phoneNumberContractTextBox";
            phoneNumberContractTextBox.Size = new Size(271, 27);
            phoneNumberContractTextBox.TabIndex = 16;
            // 
            // ContractDateLabel
            // 
            ContractDateLabel.AutoSize = true;
            ContractDateLabel.Location = new Point(261, 59);
            ContractDateLabel.Name = "ContractDateLabel";
            ContractDateLabel.Size = new Size(54, 20);
            ContractDateLabel.TabIndex = 202;
            ContractDateLabel.Text = "ημ/νία";
            // 
            // phnoeNumberLabel
            // 
            phnoeNumberLabel.AutoSize = true;
            phnoeNumberLabel.Location = new Point(1, 26);
            phnoeNumberLabel.Name = "phnoeNumberLabel";
            phnoeNumberLabel.Size = new Size(137, 20);
            phnoeNumberLabel.TabIndex = 0;
            phnoeNumberLabel.Text = "ΑΡΙΘ. ΤΗΛΕΦΩΝΟΥ";
            // 
            // contractNumberTextBox
            // 
            contractNumberTextBox.Location = new Point(133, 56);
            contractNumberTextBox.Name = "contractNumberTextBox";
            contractNumberTextBox.Size = new Size(122, 27);
            contractNumberTextBox.TabIndex = 17;
            // 
            // contractNumberLabel
            // 
            contractNumberLabel.AutoSize = true;
            contractNumberLabel.Location = new Point(3, 59);
            contractNumberLabel.Name = "contractNumberLabel";
            contractNumberLabel.Size = new Size(124, 20);
            contractNumberLabel.TabIndex = 203;
            contractNumberLabel.Text = "ΑΡΙΘ. ΣΥΜΒΑΣΗΣ";
            // 
            // billsGroupBox
            // 
            billsGroupBox.BackColor = SystemColors.Control;
            billsGroupBox.Controls.Add(billAmountTextBox);
            billsGroupBox.Controls.Add(billAmountLabel);
            billsGroupBox.Controls.Add(billsListBox);
            billsGroupBox.Controls.Add(removeBillButton);
            billsGroupBox.Controls.Add(billDateTextBox);
            billsGroupBox.Controls.Add(addBillButton);
            billsGroupBox.Controls.Add(billDateLabel);
            billsGroupBox.Location = new Point(455, 534);
            billsGroupBox.Name = "billsGroupBox";
            billsGroupBox.Size = new Size(207, 386);
            billsGroupBox.TabIndex = 0;
            billsGroupBox.TabStop = false;
            billsGroupBox.Text = "ΤΙΜΟΛΟΓΙΑ";
            // 
            // billAmountTextBox
            // 
            billAmountTextBox.Location = new Point(51, 59);
            billAmountTextBox.Name = "billAmountTextBox";
            billAmountTextBox.Size = new Size(139, 27);
            billAmountTextBox.TabIndex = 25;
            // 
            // billAmountLabel
            // 
            billAmountLabel.AutoSize = true;
            billAmountLabel.Location = new Point(1, 60);
            billAmountLabel.Name = "billAmountLabel";
            billAmountLabel.Size = new Size(50, 20);
            billAmountLabel.TabIndex = 206;
            billAmountLabel.Text = "ΠΟΣΟ";
            // 
            // billsListBox
            // 
            billsListBox.FormattingEnabled = true;
            billsListBox.ItemHeight = 20;
            billsListBox.Location = new Point(10, 161);
            billsListBox.Name = "billsListBox";
            billsListBox.Size = new Size(180, 204);
            billsListBox.TabIndex = 204;
            // 
            // removeBillButton
            // 
            removeBillButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            removeBillButton.Location = new Point(51, 92);
            removeBillButton.Name = "removeBillButton";
            removeBillButton.Size = new Size(59, 29);
            removeBillButton.TabIndex = 27;
            removeBillButton.Text = "-";
            removeBillButton.UseVisualStyleBackColor = true;
            removeBillButton.Click += removeBillButton_Click;
            // 
            // billDateTextBox
            // 
            billDateTextBox.Location = new Point(51, 26);
            billDateTextBox.Name = "billDateTextBox";
            billDateTextBox.Size = new Size(139, 27);
            billDateTextBox.TabIndex = 24;
            // 
            // addBillButton
            // 
            addBillButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            addBillButton.Location = new Point(116, 92);
            addBillButton.Name = "addBillButton";
            addBillButton.Size = new Size(74, 30);
            addBillButton.TabIndex = 26;
            addBillButton.Text = "+";
            addBillButton.UseVisualStyleBackColor = true;
            addBillButton.Click += addBillButton_Click;
            // 
            // billDateLabel
            // 
            billDateLabel.AutoSize = true;
            billDateLabel.Location = new Point(1, 29);
            billDateLabel.Name = "billDateLabel";
            billDateLabel.Size = new Size(54, 20);
            billDateLabel.TabIndex = 204;
            billDateLabel.Text = "ημ/νία";
            // 
            // clearAllButton
            // 
            clearAllButton.Location = new Point(813, 875);
            clearAllButton.Name = "clearAllButton";
            clearAllButton.Size = new Size(107, 45);
            clearAllButton.TabIndex = 44;
            clearAllButton.Text = "Clear All";
            clearAllButton.UseVisualStyleBackColor = true;
            clearAllButton.Click += clearAllButton_Click;
            // 
            // typeGroupBox
            // 
            typeGroupBox.Controls.Add(removeLawyerButton);
            typeGroupBox.Controls.Add(removeCourtButton);
            typeGroupBox.Controls.Add(selectLawyerLabel);
            typeGroupBox.Controls.Add(lawyerSelectionComboBox);
            typeGroupBox.Controls.Add(selectCourtLabel);
            typeGroupBox.Controls.Add(courtSelectionComboBox);
            typeGroupBox.Controls.Add(oteRadioButton);
            typeGroupBox.Controls.Add(cosmoteRadioButton);
            typeGroupBox.Location = new Point(307, 126);
            typeGroupBox.Name = "typeGroupBox";
            typeGroupBox.Size = new Size(738, 114);
            typeGroupBox.TabIndex = 203;
            typeGroupBox.TabStop = false;
            typeGroupBox.Text = "ΕΙΔΟΣ ΔΙΑΤΑΓΗΣ";
            // 
            // removeLawyerButton
            // 
            removeLawyerButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            removeLawyerButton.Location = new Point(694, 58);
            removeLawyerButton.Name = "removeLawyerButton";
            removeLawyerButton.Size = new Size(38, 30);
            removeLawyerButton.TabIndex = 207;
            removeLawyerButton.Text = "-";
            removeLawyerButton.UseVisualStyleBackColor = true;
            removeLawyerButton.Click += removeLawyerButton_Click;
            // 
            // removeCourtButton
            // 
            removeCourtButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            removeCourtButton.Location = new Point(694, 20);
            removeCourtButton.Name = "removeCourtButton";
            removeCourtButton.Size = new Size(38, 29);
            removeCourtButton.TabIndex = 206;
            removeCourtButton.Text = "-";
            removeCourtButton.UseVisualStyleBackColor = true;
            removeCourtButton.Click += removeCourtButton_Click;
            // 
            // selectLawyerLabel
            // 
            selectLawyerLabel.AutoSize = true;
            selectLawyerLabel.Location = new Point(182, 64);
            selectLawyerLabel.Name = "selectLawyerLabel";
            selectLawyerLabel.Size = new Size(156, 20);
            selectLawyerLabel.TabIndex = 28;
            selectLawyerLabel.Text = "ΕΠΙΛΟΓΗ ΔΙΚΗΓΟΡΟΥ:";
            // 
            // lawyerSelectionComboBox
            // 
            lawyerSelectionComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            lawyerSelectionComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            lawyerSelectionComboBox.FormattingEnabled = true;
            lawyerSelectionComboBox.Location = new Point(374, 60);
            lawyerSelectionComboBox.Name = "lawyerSelectionComboBox";
            lawyerSelectionComboBox.Size = new Size(302, 28);
            lawyerSelectionComboBox.TabIndex = 42;
            lawyerSelectionComboBox.SelectedIndexChanged += lawyerSelectionComboBox_SelectedIndexChanged;
            // 
            // selectCourtLabel
            // 
            selectCourtLabel.AutoSize = true;
            selectCourtLabel.Location = new Point(182, 25);
            selectCourtLabel.Name = "selectCourtLabel";
            selectCourtLabel.Size = new Size(184, 20);
            selectCourtLabel.TabIndex = 9;
            selectCourtLabel.Text = "ΕΠΙΛΟΓΗ ΕΙΡΗΝΟΔΙΚΕΙΟΥ:";
            // 
            // courtSelectionComboBox
            // 
            courtSelectionComboBox.FormattingEnabled = true;
            courtSelectionComboBox.Location = new Point(374, 20);
            courtSelectionComboBox.Name = "courtSelectionComboBox";
            courtSelectionComboBox.Size = new Size(302, 28);
            courtSelectionComboBox.TabIndex = 41;
            courtSelectionComboBox.SelectedIndexChanged += courtSelectionComboBox_SelectedIndexChanged;
            // 
            // oteRadioButton
            // 
            oteRadioButton.AutoSize = true;
            oteRadioButton.Location = new Point(10, 58);
            oteRadioButton.Name = "oteRadioButton";
            oteRadioButton.Size = new Size(53, 24);
            oteRadioButton.TabIndex = 40;
            oteRadioButton.TabStop = true;
            oteRadioButton.Text = "OTE";
            oteRadioButton.UseVisualStyleBackColor = true;
            // 
            // cosmoteRadioButton
            // 
            cosmoteRadioButton.AutoSize = true;
            cosmoteRadioButton.Location = new Point(10, 23);
            cosmoteRadioButton.Name = "cosmoteRadioButton";
            cosmoteRadioButton.Size = new Size(86, 24);
            cosmoteRadioButton.TabIndex = 39;
            cosmoteRadioButton.TabStop = true;
            cosmoteRadioButton.Text = "Cosomte";
            cosmoteRadioButton.UseVisualStyleBackColor = true;
            // 
            // advancedOptionsGroupBox
            // 
            advancedOptionsGroupBox.Controls.Add(addressChangeGroupBox);
            advancedOptionsGroupBox.Controls.Add(challengeRequestCheckBox);
            advancedOptionsGroupBox.Controls.Add(athensJurisdictionCheckBox);
            advancedOptionsGroupBox.Location = new Point(307, 246);
            advancedOptionsGroupBox.Name = "advancedOptionsGroupBox";
            advancedOptionsGroupBox.Size = new Size(738, 267);
            advancedOptionsGroupBox.TabIndex = 204;
            advancedOptionsGroupBox.TabStop = false;
            advancedOptionsGroupBox.Text = "Advanced Options";
            // 
            // addressChangeGroupBox
            // 
            addressChangeGroupBox.Controls.Add(IdChangeCheckBox);
            addressChangeGroupBox.Controls.Add(addressChangeApplicationDateTextBox);
            addressChangeGroupBox.Controls.Add(addressChangeApplicationDateLabel);
            addressChangeGroupBox.Controls.Add(addressChangeApplicationNumberTextBox);
            addressChangeGroupBox.Controls.Add(addressChangeApplicationNumberLabel);
            addressChangeGroupBox.Controls.Add(AddressChangeCheckBox);
            addressChangeGroupBox.Location = new Point(480, 16);
            addressChangeGroupBox.Name = "addressChangeGroupBox";
            addressChangeGroupBox.Size = new Size(241, 245);
            addressChangeGroupBox.TabIndex = 205;
            addressChangeGroupBox.TabStop = false;
            addressChangeGroupBox.Text = "ΣΧΕΤΙΚΟ 4";
            // 
            // IdChangeCheckBox
            // 
            IdChangeCheckBox.AutoSize = true;
            IdChangeCheckBox.Location = new Point(8, 64);
            IdChangeCheckBox.Name = "IdChangeCheckBox";
            IdChangeCheckBox.Size = new Size(178, 24);
            IdChangeCheckBox.TabIndex = 34;
            IdChangeCheckBox.Text = "ΑΛΛΑΓΗ ΤΑΥΤΟΤΗΤΑΣ";
            IdChangeCheckBox.UseVisualStyleBackColor = true;
            IdChangeCheckBox.CheckedChanged += IdChangeCheckBox_CheckedChanged;
            // 
            // addressChangeApplicationDateTextBox
            // 
            addressChangeApplicationDateTextBox.Location = new Point(14, 196);
            addressChangeApplicationDateTextBox.Name = "addressChangeApplicationDateTextBox";
            addressChangeApplicationDateTextBox.Size = new Size(221, 27);
            addressChangeApplicationDateTextBox.TabIndex = 36;
            addressChangeApplicationDateTextBox.TextChanged += addressChangeApplicationDateTextBox_TextChanged;
            // 
            // addressChangeApplicationDateLabel
            // 
            addressChangeApplicationDateLabel.AutoSize = true;
            addressChangeApplicationDateLabel.Location = new Point(8, 168);
            addressChangeApplicationDateLabel.Name = "addressChangeApplicationDateLabel";
            addressChangeApplicationDateLabel.Size = new Size(173, 20);
            addressChangeApplicationDateLabel.TabIndex = 10;
            addressChangeApplicationDateLabel.Text = "ΗΜΕΡΟΜΗΝΙΑ ΑΙΤΗΣΗΣ";
            // 
            // addressChangeApplicationNumberTextBox
            // 
            addressChangeApplicationNumberTextBox.Location = new Point(14, 128);
            addressChangeApplicationNumberTextBox.Name = "addressChangeApplicationNumberTextBox";
            addressChangeApplicationNumberTextBox.Size = new Size(221, 27);
            addressChangeApplicationNumberTextBox.TabIndex = 35;
            addressChangeApplicationNumberTextBox.TextChanged += addressChangeApplicationNumberTextBox_TextChanged;
            // 
            // addressChangeApplicationNumberLabel
            // 
            addressChangeApplicationNumberLabel.AutoSize = true;
            addressChangeApplicationNumberLabel.Location = new Point(14, 105);
            addressChangeApplicationNumberLabel.Name = "addressChangeApplicationNumberLabel";
            addressChangeApplicationNumberLabel.Size = new Size(109, 20);
            addressChangeApplicationNumberLabel.TabIndex = 1;
            addressChangeApplicationNumberLabel.Text = "ΑΡΙΘ. ΑΙΤΗΣΗΣ";
            // 
            // AddressChangeCheckBox
            // 
            AddressChangeCheckBox.AutoSize = true;
            AddressChangeCheckBox.Location = new Point(8, 32);
            AddressChangeCheckBox.Name = "AddressChangeCheckBox";
            AddressChangeCheckBox.Size = new Size(175, 24);
            AddressChangeCheckBox.TabIndex = 33;
            AddressChangeCheckBox.Text = "ΑΛΛΑΓΗ ΔΙΕΥΘΥΝΣΗΣ";
            AddressChangeCheckBox.UseVisualStyleBackColor = true;
            AddressChangeCheckBox.CheckedChanged += AddressChangeCheckBox_CheckedChanged;
            // 
            // challengeRequestCheckBox
            // 
            challengeRequestCheckBox.AutoSize = true;
            challengeRequestCheckBox.Location = new Point(14, 66);
            challengeRequestCheckBox.Name = "challengeRequestCheckBox";
            challengeRequestCheckBox.Size = new Size(200, 24);
            challengeRequestCheckBox.TabIndex = 38;
            challengeRequestCheckBox.Text = "ΑΙΤΗΜΑ ΑΜΦΙΣΒΗΤΗΣΗΣ";
            challengeRequestCheckBox.UseVisualStyleBackColor = true;
            challengeRequestCheckBox.CheckedChanged += challengeRequestCheckBox_CheckedChanged;
            // 
            // athensJurisdictionCheckBox
            // 
            athensJurisdictionCheckBox.AutoSize = true;
            athensJurisdictionCheckBox.Location = new Point(14, 36);
            athensJurisdictionCheckBox.Name = "athensJurisdictionCheckBox";
            athensJurisdictionCheckBox.Size = new Size(136, 24);
            athensJurisdictionCheckBox.TabIndex = 37;
            athensJurisdictionCheckBox.Text = "ΜΕ ΠΑΡΕΚΤΑΣΗ";
            athensJurisdictionCheckBox.UseVisualStyleBackColor = true;
            athensJurisdictionCheckBox.CheckedChanged += athensJurisdictionCheckBox_CheckedChanged;
            // 
            // totalAmountTextBox
            // 
            totalAmountTextBox.Location = new Point(795, 560);
            totalAmountTextBox.Name = "totalAmountTextBox";
            totalAmountTextBox.Size = new Size(255, 27);
            totalAmountTextBox.TabIndex = 30;
            totalAmountTextBox.TextChanged += totalAmountTextBox_TextChanged;
            // 
            // totalAmountLabel
            // 
            totalAmountLabel.AutoSize = true;
            totalAmountLabel.Location = new Point(673, 563);
            totalAmountLabel.Name = "totalAmountLabel";
            totalAmountLabel.Size = new Size(116, 20);
            totalAmountLabel.TabIndex = 208;
            totalAmountLabel.Text = "ΠΟΣΟ ΟΦΕΙΛΗΣ";
            // 
            // testButton
            // 
            testButton.Location = new Point(693, 875);
            testButton.Name = "testButton";
            testButton.Size = new Size(107, 45);
            testButton.TabIndex = 45;
            testButton.Text = "TEST";
            testButton.UseVisualStyleBackColor = true;
            testButton.Click += testButton_Click;
            // 
            // promissoryNoteTextBox
            // 
            promissoryNoteTextBox.Location = new Point(795, 654);
            promissoryNoteTextBox.Name = "promissoryNoteTextBox";
            promissoryNoteTextBox.Size = new Size(255, 27);
            promissoryNoteTextBox.TabIndex = 32;
            promissoryNoteTextBox.TextChanged += promissoryNoteTextBox_TextChanged;
            // 
            // promissoryNoteLabel
            // 
            promissoryNoteLabel.AutoSize = true;
            promissoryNoteLabel.Location = new Point(701, 657);
            promissoryNoteLabel.Name = "promissoryNoteLabel";
            promissoryNoteLabel.Size = new Size(96, 20);
            promissoryNoteLabel.TabIndex = 9;
            promissoryNoteLabel.Text = "ΓΡΑΜΜΑΤΙΟ:";
            // 
            // judicialStampTextBox
            // 
            judicialStampTextBox.Location = new Point(795, 621);
            judicialStampTextBox.Name = "judicialStampTextBox";
            judicialStampTextBox.Size = new Size(255, 27);
            judicialStampTextBox.TabIndex = 31;
            judicialStampTextBox.TextChanged += judicialStampTextBox_TextChanged;
            // 
            // judicialStampLabel
            // 
            judicialStampLabel.AutoSize = true;
            judicialStampLabel.Location = new Point(701, 624);
            judicialStampLabel.Name = "judicialStampLabel";
            judicialStampLabel.Size = new Size(74, 20);
            judicialStampLabel.TabIndex = 10;
            judicialStampLabel.Text = "ΕΝΣΗΜΟ:";
            // 
            // remunerationGroupBox
            // 
            remunerationGroupBox.BackColor = SystemColors.Control;
            remunerationGroupBox.Controls.Add(remunerationToTextBox);
            remunerationGroupBox.Controls.Add(remunerationToLabel);
            remunerationGroupBox.Controls.Add(remunerationFromTextBox);
            remunerationGroupBox.Controls.Add(remunerationFromLabel);
            remunerationGroupBox.Location = new Point(681, 758);
            remunerationGroupBox.Name = "remunerationGroupBox";
            remunerationGroupBox.Size = new Size(367, 66);
            remunerationGroupBox.TabIndex = 207;
            remunerationGroupBox.TabStop = false;
            remunerationGroupBox.Text = "ΕΝΑΝΤΙ";
            remunerationGroupBox.Visible = false;
            // 
            // remunerationToTextBox
            // 
            remunerationToTextBox.Location = new Point(243, 26);
            remunerationToTextBox.Name = "remunerationToTextBox";
            remunerationToTextBox.Size = new Size(92, 27);
            remunerationToTextBox.TabIndex = 29;
            remunerationToTextBox.TextChanged += remunerationToTextBox_TextChanged;
            // 
            // remunerationToLabel
            // 
            remunerationToLabel.AutoSize = true;
            remunerationToLabel.Location = new Point(193, 26);
            remunerationToLabel.Name = "remunerationToLabel";
            remunerationToLabel.Size = new Size(39, 20);
            remunerationToLabel.TabIndex = 206;
            remunerationToLabel.Text = "ΕΩΣ:";
            // 
            // remunerationFromTextBox
            // 
            remunerationFromTextBox.Location = new Point(52, 26);
            remunerationFromTextBox.Name = "remunerationFromTextBox";
            remunerationFromTextBox.Size = new Size(92, 27);
            remunerationFromTextBox.TabIndex = 28;
            remunerationFromTextBox.TextChanged += remunerationFromTextBox_TextChanged;
            // 
            // remunerationFromLabel
            // 
            remunerationFromLabel.AutoSize = true;
            remunerationFromLabel.Location = new Point(1, 29);
            remunerationFromLabel.Name = "remunerationFromLabel";
            remunerationFromLabel.Size = new Size(44, 20);
            remunerationFromLabel.TabIndex = 204;
            remunerationFromLabel.Text = "ΑΠΟ:";
            // 
            // searchGroupBox
            // 
            searchGroupBox.Controls.Add(searchButton);
            searchGroupBox.Controls.Add(caseNumberTextBox);
            searchGroupBox.Controls.Add(caseNumberLabel);
            searchGroupBox.ForeColor = SystemColors.MenuHighlight;
            searchGroupBox.Location = new Point(307, 45);
            searchGroupBox.Name = "searchGroupBox";
            searchGroupBox.Size = new Size(738, 72);
            searchGroupBox.TabIndex = 210;
            searchGroupBox.TabStop = false;
            searchGroupBox.Text = "Search";
            // 
            // searchButton
            // 
            searchButton.Location = new Point(403, 29);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 27);
            searchButton.TabIndex = 2;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            // 
            // caseNumberTextBox
            // 
            caseNumberTextBox.Location = new Point(236, 29);
            caseNumberTextBox.Name = "caseNumberTextBox";
            caseNumberTextBox.Size = new Size(161, 27);
            caseNumberTextBox.TabIndex = 1;
            // 
            // caseNumberLabel
            // 
            caseNumberLabel.AutoSize = true;
            caseNumberLabel.Location = new Point(129, 32);
            caseNumberLabel.Name = "caseNumberLabel";
            caseNumberLabel.Size = new Size(101, 20);
            caseNumberLabel.TabIndex = 9;
            caseNumberLabel.Text = "Case Number:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 959);
            Controls.Add(searchGroupBox);
            Controls.Add(remunerationGroupBox);
            Controls.Add(promissoryNoteTextBox);
            Controls.Add(promissoryNoteLabel);
            Controls.Add(testButton);
            Controls.Add(judicialStampTextBox);
            Controls.Add(totalAmountTextBox);
            Controls.Add(judicialStampLabel);
            Controls.Add(totalAmountLabel);
            Controls.Add(advancedOptionsGroupBox);
            Controls.Add(typeGroupBox);
            Controls.Add(clearAllButton);
            Controls.Add(billsGroupBox);
            Controls.Add(contractsGroupBox);
            Controls.Add(genderGroupBox);
            Controls.Add(GeneratePaymenOrderBbutton);
            Controls.Add(userInfoGroupBox);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "RTF Generator";
            Load += Form1_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            userInfoGroupBox.ResumeLayout(false);
            userInfoGroupBox.PerformLayout();
            genderGroupBox.ResumeLayout(false);
            genderGroupBox.PerformLayout();
            contractsGroupBox.ResumeLayout(false);
            contractsGroupBox.PerformLayout();
            billsGroupBox.ResumeLayout(false);
            billsGroupBox.PerformLayout();
            typeGroupBox.ResumeLayout(false);
            typeGroupBox.PerformLayout();
            advancedOptionsGroupBox.ResumeLayout(false);
            advancedOptionsGroupBox.PerformLayout();
            addressChangeGroupBox.ResumeLayout(false);
            addressChangeGroupBox.PerformLayout();
            remunerationGroupBox.ResumeLayout(false);
            remunerationGroupBox.PerformLayout();
            searchGroupBox.ResumeLayout(false);
            searchGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripProgressBar toolStripProgressBar;
        private ToolStripStatusLabel toolStripStatusLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private GroupBox userInfoGroupBox;
        private TextBox firstNameTextBox;
        private Label firstNameLabel;
        private TextBox lastNameTextBox;
        private Label lasNameLabel;
        private TextBox taxNumberTextBox;
        private Label taxNumberLabel;
        private TextBox fatherNameTextBox;
        private Label fatherNameLabel;
        private Label label1;
        private TextBox zipCodeTextBox;
        private Label zipCodeLabel;
        private TextBox streetNameTextBox;
        private Label CityNameLabel;
        private TextBox streetNumberTextBox;
        private Label streetNumberLabel;
        private TextBox streetTextBox;
        private Label streetLabel;
        private Button GeneratePaymenOrderBbutton;
        private GroupBox genderGroupBox;
        private RadioButton maleRadioButton;
        private RadioButton femaleRadioButton;
        private GroupBox contractsGroupBox;
        private TextBox contractDateTextBox;
        private TextBox phoneNumberContractTextBox;
        private Label ContractDateLabel;
        private Label phnoeNumberLabel;
        private TextBox contractNumberTextBox;
        private Label contractNumberLabel;
        private Button removeContractButton;
        private Button addContractButton;
        private ListBox phoneContractsListBox;
        private Button addSimNumberButton;
        private RadioButton companyRadioButton;
        private ComboBox CompanyTypeComboBox;
        private ComboBox contractDurationComboBox;
        private GroupBox billsGroupBox;
        private Button removeBillButton;
        private TextBox billDateTextBox;
        private Button addBillButton;
        private Label billDateLabel;
        private ListBox billsListBox;
        private TextBox billAmountTextBox;
        private Label billAmountLabel;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private Button clearAllButton;
        private ToolStripMenuItem addCourtToolStripMenuItem;
        private ToolStripMenuItem addLawyerToolStripMenuItem;
        private ToolStripMenuItem addContractsToolStripMenuItem;
        private GroupBox typeGroupBox;
        private Label selectCourtLabel;
        private ComboBox courtSelectionComboBox;
        private RadioButton oteRadioButton;
        private RadioButton cosmoteRadioButton;
        private GroupBox advancedOptionsGroupBox;
        private ToolStripMenuItem checkForUpdateToolStripMenuItem;
        private Label selectLawyerLabel;
        private ComboBox lawyerSelectionComboBox;
        private TextBox totalAmountTextBox;
        private Label totalAmountLabel;
        private Button testButton;
        private Label companyTitelLabel;
        private TextBox companyTitelTextBox;
        private CheckBox athensJurisdictionCheckBox;
        private CheckBox challengeRequestCheckBox;
        private TextBox promissoryNoteTextBox;
        private Label promissoryNoteLabel;
        private TextBox judicialStampTextBox;
        private Label judicialStampLabel;
        private GroupBox addressChangeGroupBox;
        private TextBox addressChangeApplicationNumberTextBox;
        private Label addressChangeApplicationNumberLabel;
        private CheckBox AddressChangeCheckBox;
        private TextBox addressChangeApplicationDateTextBox;
        private Label addressChangeApplicationDateLabel;
        private CheckBox IdChangeCheckBox;
        private GroupBox remunerationGroupBox;
        private TextBox remunerationToTextBox;
        private Label remunerationToLabel;
        private TextBox remunerationFromTextBox;
        private Label remunerationFromLabel;
        private TextBox contractTypeTextBox;
        private Label contractTypeLabel;
        private Button removeLawyerButton;
        private Button removeCourtButton;
        private ToolStripMenuItem loadFromFileToolStripMenuItem;
        private GroupBox searchGroupBox;
        private TextBox caseNumberTextBox;
        private Label caseNumberLabel;
        private Button searchButton;
    }
}