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
            femaleRadioButton = new RadioButton();
            maleRadioButton = new RadioButton();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            userInfoGroupBox.SuspendLayout();
            genderGroupBox.SuspendLayout();
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
            genderGroupBox.Controls.Add(femaleRadioButton);
            genderGroupBox.Controls.Add(maleRadioButton);
            genderGroupBox.Location = new Point(8, 325);
            genderGroupBox.Name = "genderGroupBox";
            genderGroupBox.Size = new Size(278, 100);
            genderGroupBox.TabIndex = 0;
            genderGroupBox.TabStop = false;
            genderGroupBox.Text = "Gender";
            // 
            // femaleRadioButton
            // 
            femaleRadioButton.AutoSize = true;
            femaleRadioButton.Location = new Point(156, 26);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 814);
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
    }
}