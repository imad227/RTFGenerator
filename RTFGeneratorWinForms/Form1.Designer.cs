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
            taxNumberTextBox = new TextBox();
            taxNumberLabel = new Label();
            fatherNameTextBox = new TextBox();
            fatherNameLabel = new Label();
            lastNameTextBox = new TextBox();
            lasNameLabel = new Label();
            firstNameTextBox = new TextBox();
            firstNameLabel = new Label();
            label1 = new Label();
            streetTextBox = new TextBox();
            streetLabel = new Label();
            streetNumberTextBox = new TextBox();
            streetNumberLabel = new Label();
            zipCodeTextBox = new TextBox();
            zipCodeLabel = new Label();
            streetNameTextBox = new TextBox();
            CityNameLabel = new Label();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            userInfoGroupBox.SuspendLayout();
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
            userInfoGroupBox.Size = new Size(276, 288);
            userInfoGroupBox.TabIndex = 0;
            userInfoGroupBox.TabStop = false;
            userInfoGroupBox.Text = "User Information";
            // 
            // taxNumberTextBox
            // 
            taxNumberTextBox.Location = new Point(98, 148);
            taxNumberTextBox.Name = "taxNumberTextBox";
            taxNumberTextBox.Size = new Size(172, 27);
            taxNumberTextBox.TabIndex = 4;
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
            // 
            // fatherNameLabel
            // 
            fatherNameLabel.AutoSize = true;
            fatherNameLabel.Location = new Point(4, 95);
            fatherNameLabel.Name = "fatherNameLabel";
            fatherNameLabel.Size = new Size(93, 20);
            fatherNameLabel.TabIndex = 0;
            fatherNameLabel.Text = "Father Name";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(98, 59);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(172, 27);
            lastNameTextBox.TabIndex = 2;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 189);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Address";
            // 
            // streetTextBox
            // 
            streetTextBox.Location = new Point(58, 212);
            streetTextBox.Name = "streetTextBox";
            streetTextBox.Size = new Size(107, 27);
            streetTextBox.TabIndex = 5;
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
            // streetNumberTextBox
            // 
            streetNumberTextBox.Location = new Point(201, 212);
            streetNumberTextBox.Name = "streetNumberTextBox";
            streetNumberTextBox.Size = new Size(69, 27);
            streetNumberTextBox.TabIndex = 6;
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
            // zipCodeTextBox
            // 
            zipCodeTextBox.Location = new Point(201, 245);
            zipCodeTextBox.Name = "zipCodeTextBox";
            zipCodeTextBox.Size = new Size(69, 27);
            zipCodeTextBox.TabIndex = 8;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 814);
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
    }
}