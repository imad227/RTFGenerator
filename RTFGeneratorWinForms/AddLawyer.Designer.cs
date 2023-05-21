namespace RTFGeneratorWinForms
{
    partial class AddLawyer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            firstNameLabel = new Label();
            firstNameTextBox = new TextBox();
            preFixTextBox = new TextBox();
            prfixLabel = new Label();
            lastNameTextBox = new TextBox();
            lastNameLabel = new Label();
            amdsaTextBox = new TextBox();
            AMDSALabel = new Label();
            genderGroupBox = new GroupBox();
            femaleRadioButton = new RadioButton();
            maleRadioButton = new RadioButton();
            saveButton = new Button();
            exitButton = new Button();
            genderGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(14, 44);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(80, 20);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(135, 40);
            firstNameTextBox.Margin = new Padding(3, 4, 3, 4);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(132, 27);
            firstNameTextBox.TabIndex = 1;
            firstNameTextBox.TextChanged += firstNameTextBox_TextChanged;
            // 
            // preFixTextBox
            // 
            preFixTextBox.Location = new Point(135, 79);
            preFixTextBox.Margin = new Padding(3, 4, 3, 4);
            preFixTextBox.Name = "preFixTextBox";
            preFixTextBox.Size = new Size(132, 27);
            preFixTextBox.TabIndex = 3;
            preFixTextBox.TextChanged += preFixTextBox_TextChanged;
            // 
            // prfixLabel
            // 
            prfixLabel.AutoSize = true;
            prfixLabel.Location = new Point(14, 83);
            prfixLabel.Name = "prfixLabel";
            prfixLabel.Size = new Size(48, 20);
            prfixLabel.TabIndex = 2;
            prfixLabel.Text = "PreFix";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(135, 117);
            lastNameTextBox.Margin = new Padding(3, 4, 3, 4);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(132, 27);
            lastNameTextBox.TabIndex = 5;
            lastNameTextBox.TextChanged += lastNameTextBox_TextChanged;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(14, 121);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(79, 20);
            lastNameLabel.TabIndex = 4;
            lastNameLabel.Text = "Last Name";
            // 
            // amdsaTextBox
            // 
            amdsaTextBox.Location = new Point(14, 209);
            amdsaTextBox.Margin = new Padding(3, 4, 3, 4);
            amdsaTextBox.Name = "amdsaTextBox";
            amdsaTextBox.Size = new Size(114, 27);
            amdsaTextBox.TabIndex = 7;
            amdsaTextBox.TextChanged += amdsaTextBox_TextChanged;
            // 
            // AMDSALabel
            // 
            AMDSALabel.AutoSize = true;
            AMDSALabel.Location = new Point(14, 173);
            AMDSALabel.Name = "AMDSALabel";
            AMDSALabel.Size = new Size(61, 20);
            AMDSALabel.TabIndex = 6;
            AMDSALabel.Text = "AMDSA";
            // 
            // genderGroupBox
            // 
            genderGroupBox.Controls.Add(femaleRadioButton);
            genderGroupBox.Controls.Add(maleRadioButton);
            genderGroupBox.Location = new Point(135, 156);
            genderGroupBox.Margin = new Padding(3, 4, 3, 4);
            genderGroupBox.Name = "genderGroupBox";
            genderGroupBox.Padding = new Padding(3, 4, 3, 4);
            genderGroupBox.Size = new Size(133, 104);
            genderGroupBox.TabIndex = 9;
            genderGroupBox.TabStop = false;
            genderGroupBox.Text = "Gender";
            // 
            // femaleRadioButton
            // 
            femaleRadioButton.AutoSize = true;
            femaleRadioButton.Location = new Point(18, 66);
            femaleRadioButton.Name = "femaleRadioButton";
            femaleRadioButton.Size = new Size(75, 24);
            femaleRadioButton.TabIndex = 11;
            femaleRadioButton.TabStop = true;
            femaleRadioButton.Text = "Female";
            femaleRadioButton.UseVisualStyleBackColor = true;
            femaleRadioButton.CheckedChanged += femaleRadioButton_CheckedChanged;
            // 
            // maleRadioButton
            // 
            maleRadioButton.AutoSize = true;
            maleRadioButton.Location = new Point(18, 36);
            maleRadioButton.Name = "maleRadioButton";
            maleRadioButton.Size = new Size(60, 24);
            maleRadioButton.TabIndex = 10;
            maleRadioButton.TabStop = true;
            maleRadioButton.Text = "Male";
            maleRadioButton.UseVisualStyleBackColor = true;
            maleRadioButton.CheckedChanged += maleRadioButton_CheckedChanged;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(153, 279);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(114, 36);
            saveButton.TabIndex = 10;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(14, 279);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(114, 36);
            exitButton.TabIndex = 11;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // AddLawyer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 347);
            Controls.Add(exitButton);
            Controls.Add(saveButton);
            Controls.Add(genderGroupBox);
            Controls.Add(amdsaTextBox);
            Controls.Add(AMDSALabel);
            Controls.Add(lastNameTextBox);
            Controls.Add(lastNameLabel);
            Controls.Add(preFixTextBox);
            Controls.Add(prfixLabel);
            Controls.Add(firstNameTextBox);
            Controls.Add(firstNameLabel);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddLawyer";
            Text = "AddLawyer";
            genderGroupBox.ResumeLayout(false);
            genderGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private TextBox firstNameTextBox;
        private TextBox preFixTextBox;
        private Label prfixLabel;
        private TextBox lastNameTextBox;
        private Label lastNameLabel;
        private TextBox amdsaTextBox;
        private Label AMDSALabel;
        private GroupBox genderGroupBox;
        private RadioButton femaleRadioButton;
        private RadioButton maleRadioButton;
        private Button saveButton;
        private Button exitButton;
    }
}