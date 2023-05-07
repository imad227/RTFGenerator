﻿using RTFGeneratorLibrary;

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
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
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
            CompanyTypeComboBox = new ComboBox();
            companyRadioButton = new RadioButton();
            femaleRadioButton = new RadioButton();
            maleRadioButton = new RadioButton();
            contractsGroupBox = new GroupBox();
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
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            userInfoGroupBox.SuspendLayout();
            genderGroupBox.SuspendLayout();
            contractsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripProgressBar, toolStripStatusLabel });
            statusStrip1.Location = new Point(0, 792);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(984, 22);
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(984, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(93, 22);
            exitToolStripMenuItem.Text = "E&xit";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "&About";
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
            userInfoGroupBox.Location = new Point(8, 31);
            userInfoGroupBox.Name = "userInfoGroupBox";
            userInfoGroupBox.Size = new Size(278, 288);
            userInfoGroupBox.TabIndex = 0;
            userInfoGroupBox.TabStop = false;
            userInfoGroupBox.Text = "User Information";
            // 
            // zipCodeTextBox
            // 
            zipCodeTextBox.Location = new Point(201, 245);
            zipCodeTextBox.Name = "zipCodeTextBox";
            zipCodeTextBox.Size = new Size(69, 27);
            zipCodeTextBox.TabIndex = 8;
            zipCodeTextBox.TextChanged += zipCodeTextBox_TextChanged;
            // 
            // zipCodeLabel
            // 
            zipCodeLabel.AutoSize = true;
            zipCodeLabel.Location = new Point(168, 248);
            zipCodeLabel.Name = "zipCodeLabel";
            zipCodeLabel.Size = new Size(30, 20);
            zipCodeLabel.TabIndex = 0;
            zipCodeLabel.Text = "ZIP";
            // 
            // streetNameTextBox
            // 
            streetNameTextBox.Location = new Point(58, 245);
            streetNameTextBox.Name = "streetNameTextBox";
            streetNameTextBox.Size = new Size(107, 27);
            streetNameTextBox.TabIndex = 7;
            streetNameTextBox.TextChanged += streetNameTextBox_TextChanged;
            // 
            // CityNameLabel
            // 
            CityNameLabel.AutoSize = true;
            CityNameLabel.Location = new Point(4, 248);
            CityNameLabel.Name = "CityNameLabel";
            CityNameLabel.Size = new Size(34, 20);
            CityNameLabel.TabIndex = 0;
            CityNameLabel.Text = "City";
            // 
            // streetNumberTextBox
            // 
            streetNumberTextBox.Location = new Point(201, 212);
            streetNumberTextBox.Name = "streetNumberTextBox";
            streetNumberTextBox.Size = new Size(69, 27);
            streetNumberTextBox.TabIndex = 6;
            streetNumberTextBox.TextChanged += streetNumberTextBox_TextChanged;
            // 
            // streetNumberLabel
            // 
            streetNumberLabel.AutoSize = true;
            streetNumberLabel.Location = new Point(168, 215);
            streetNumberLabel.Name = "streetNumberLabel";
            streetNumberLabel.Size = new Size(32, 20);
            streetNumberLabel.TabIndex = 0;
            streetNumberLabel.Text = "No.";
            // 
            // streetTextBox
            // 
            streetTextBox.Location = new Point(58, 212);
            streetTextBox.Name = "streetTextBox";
            streetTextBox.Size = new Size(107, 27);
            streetTextBox.TabIndex = 5;
            streetTextBox.TextChanged += streetTextBox_TextChanged;
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new Point(4, 215);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new Size(48, 20);
            streetLabel.TabIndex = 0;
            streetLabel.Text = "Street";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 189);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Address";
            // 
            // taxNumberTextBox
            // 
            taxNumberTextBox.Location = new Point(98, 148);
            taxNumberTextBox.Name = "taxNumberTextBox";
            taxNumberTextBox.Size = new Size(172, 27);
            taxNumberTextBox.TabIndex = 4;
            taxNumberTextBox.TextChanged += taxNumberTextBox_TextChanged;
            // 
            // taxNumberLabel
            // 
            taxNumberLabel.AutoSize = true;
            taxNumberLabel.Location = new Point(2, 151);
            taxNumberLabel.Name = "taxNumberLabel";
            taxNumberLabel.Size = new Size(88, 20);
            taxNumberLabel.TabIndex = 0;
            taxNumberLabel.Text = "Tax Number";
            // 
            // fatherNameTextBox
            // 
            fatherNameTextBox.Location = new Point(98, 92);
            fatherNameTextBox.Name = "fatherNameTextBox";
            fatherNameTextBox.Size = new Size(172, 27);
            fatherNameTextBox.TabIndex = 3;
            fatherNameTextBox.TextChanged += fatherNameTextBox_TextChanged;
            // 
            // fatherNameLabel
            // 
            fatherNameLabel.AutoSize = true;
            fatherNameLabel.Location = new Point(0, 95);
            fatherNameLabel.Name = "fatherNameLabel";
            fatherNameLabel.Size = new Size(102, 20);
            fatherNameLabel.TabIndex = 0;
            fatherNameLabel.Text = "Father's Name";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(98, 59);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(172, 27);
            lastNameTextBox.TabIndex = 2;
            lastNameTextBox.TextChanged += lastNameTextBox_TextChanged;
            // 
            // lasNameLabel
            // 
            lasNameLabel.AutoSize = true;
            lasNameLabel.Location = new Point(2, 62);
            lasNameLabel.Name = "lasNameLabel";
            lasNameLabel.Size = new Size(79, 20);
            lasNameLabel.TabIndex = 0;
            lasNameLabel.Text = "Last Name";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(98, 26);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(172, 27);
            firstNameTextBox.TabIndex = 1;
            firstNameTextBox.TextChanged += firstNameTextBox_TextChanged;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(2, 29);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(80, 20);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name";
            // 
            // GeneratePaymenOrderBbutton
            // 
            GeneratePaymenOrderBbutton.Location = new Point(865, 744);
            GeneratePaymenOrderBbutton.Name = "GeneratePaymenOrderBbutton";
            GeneratePaymenOrderBbutton.Size = new Size(107, 45);
            GeneratePaymenOrderBbutton.TabIndex = 200;
            GeneratePaymenOrderBbutton.Text = "Generate";
            GeneratePaymenOrderBbutton.UseVisualStyleBackColor = true;
            GeneratePaymenOrderBbutton.Click += GeneratePaymenOrderBbutton_Click;
            // 
            // genderGroupBox
            // 
            genderGroupBox.Controls.Add(CompanyTypeComboBox);
            genderGroupBox.Controls.Add(companyRadioButton);
            genderGroupBox.Controls.Add(femaleRadioButton);
            genderGroupBox.Controls.Add(maleRadioButton);
            genderGroupBox.Location = new Point(8, 325);
            genderGroupBox.Name = "genderGroupBox";
            genderGroupBox.Size = new Size(278, 100);
            genderGroupBox.TabIndex = 0;
            genderGroupBox.TabStop = false;
            genderGroupBox.Text = "Gender";
            // 
            // CompanyTypeComboBox
            // 
            CompanyTypeComboBox.FormattingEnabled = true;
            CompanyTypeComboBox.Location = new Point(10, 56);
            CompanyTypeComboBox.Name = "CompanyTypeComboBox";
            CompanyTypeComboBox.Size = new Size(260, 28);
            CompanyTypeComboBox.TabIndex = 12;
            // 
            // companyRadioButton
            // 
            companyRadioButton.AutoSize = true;
            companyRadioButton.Location = new Point(182, 26);
            companyRadioButton.Name = "companyRadioButton";
            companyRadioButton.Size = new Size(90, 24);
            companyRadioButton.TabIndex = 11;
            companyRadioButton.TabStop = true;
            companyRadioButton.Text = "Company";
            companyRadioButton.UseVisualStyleBackColor = true;
            companyRadioButton.CheckedChanged += companyRadioButton_CheckedChanged;
            // 
            // femaleRadioButton
            // 
            femaleRadioButton.AutoSize = true;
            femaleRadioButton.Location = new Point(72, 26);
            femaleRadioButton.Name = "femaleRadioButton";
            femaleRadioButton.Size = new Size(75, 24);
            femaleRadioButton.TabIndex = 10;
            femaleRadioButton.TabStop = true;
            femaleRadioButton.Text = "Female";
            femaleRadioButton.UseVisualStyleBackColor = true;
            femaleRadioButton.CheckedChanged += femaleRadioButton_CheckedChanged;
            // 
            // maleRadioButton
            // 
            maleRadioButton.AutoSize = true;
            maleRadioButton.Location = new Point(6, 26);
            maleRadioButton.Name = "maleRadioButton";
            maleRadioButton.Size = new Size(60, 24);
            maleRadioButton.TabIndex = 9;
            maleRadioButton.TabStop = true;
            maleRadioButton.Text = "Male";
            maleRadioButton.UseVisualStyleBackColor = true;
            maleRadioButton.CheckedChanged += maleRadioButton_CheckedChanged;
            // 
            // contractsGroupBox
            // 
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
            contractsGroupBox.Location = new Point(12, 440);
            contractsGroupBox.Name = "contractsGroupBox";
            contractsGroupBox.Size = new Size(429, 349);
            contractsGroupBox.TabIndex = 201;
            contractsGroupBox.TabStop = false;
            contractsGroupBox.Text = "Contracts";
            // 
            // contractDurationComboBox
            // 
            contractDurationComboBox.FormattingEnabled = true;
            contractDurationComboBox.Location = new Point(6, 92);
            contractDurationComboBox.Name = "contractDurationComboBox";
            contractDurationComboBox.Size = new Size(283, 28);
            contractDurationComboBox.TabIndex = 16;
            // 
            // addSimNumberButton
            // 
            addSimNumberButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addSimNumberButton.Location = new Point(295, 92);
            addSimNumberButton.Name = "addSimNumberButton";
            addSimNumberButton.Size = new Size(55, 28);
            addSimNumberButton.TabIndex = 19;
            addSimNumberButton.Text = "SIM";
            addSimNumberButton.UseVisualStyleBackColor = true;
            // 
            // phoneContractsListBox
            // 
            phoneContractsListBox.FormattingEnabled = true;
            phoneContractsListBox.ItemHeight = 20;
            phoneContractsListBox.Location = new Point(6, 132);
            phoneContractsListBox.Name = "phoneContractsListBox";
            phoneContractsListBox.Size = new Size(414, 204);
            phoneContractsListBox.TabIndex = 202;
            // 
            // removeContractButton
            // 
            removeContractButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            removeContractButton.Location = new Point(356, 90);
            removeContractButton.Name = "removeContractButton";
            removeContractButton.Size = new Size(29, 30);
            removeContractButton.TabIndex = 18;
            removeContractButton.Text = "-";
            removeContractButton.UseVisualStyleBackColor = true;
            removeContractButton.Click += removeContractButton_Click;
            // 
            // addContractButton
            // 
            addContractButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            addContractButton.Location = new Point(391, 90);
            addContractButton.Name = "addContractButton";
            addContractButton.Size = new Size(29, 30);
            addContractButton.TabIndex = 17;
            addContractButton.Text = "+";
            addContractButton.UseVisualStyleBackColor = true;
            addContractButton.Click += addContractButton_Click;
            // 
            // contractDateTextBox
            // 
            contractDateTextBox.Location = new Point(305, 59);
            contractDateTextBox.Name = "contractDateTextBox";
            contractDateTextBox.Size = new Size(115, 27);
            contractDateTextBox.TabIndex = 15;
            // 
            // phoneNumberContractTextBox
            // 
            phoneNumberContractTextBox.Location = new Point(112, 24);
            phoneNumberContractTextBox.Name = "phoneNumberContractTextBox";
            phoneNumberContractTextBox.Size = new Size(308, 27);
            phoneNumberContractTextBox.TabIndex = 13;
            // 
            // ContractDateLabel
            // 
            ContractDateLabel.AutoSize = true;
            ContractDateLabel.Location = new Point(258, 62);
            ContractDateLabel.Name = "ContractDateLabel";
            ContractDateLabel.Size = new Size(41, 20);
            ContractDateLabel.TabIndex = 202;
            ContractDateLabel.Text = "Date";
            // 
            // phnoeNumberLabel
            // 
            phnoeNumberLabel.AutoSize = true;
            phnoeNumberLabel.Location = new Point(-2, 29);
            phnoeNumberLabel.Name = "phnoeNumberLabel";
            phnoeNumberLabel.Size = new Size(108, 20);
            phnoeNumberLabel.TabIndex = 0;
            phnoeNumberLabel.Text = "Phone Number";
            // 
            // contractNumberTextBox
            // 
            contractNumberTextBox.Location = new Point(112, 59);
            contractNumberTextBox.Name = "contractNumberTextBox";
            contractNumberTextBox.Size = new Size(140, 27);
            contractNumberTextBox.TabIndex = 14;
            // 
            // contractNumberLabel
            // 
            contractNumberLabel.AutoSize = true;
            contractNumberLabel.Location = new Point(0, 62);
            contractNumberLabel.Name = "contractNumberLabel";
            contractNumberLabel.Size = new Size(92, 20);
            contractNumberLabel.TabIndex = 203;
            contractNumberLabel.Text = "Contract No.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 814);
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
    }
}