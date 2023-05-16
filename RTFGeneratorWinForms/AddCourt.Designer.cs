namespace RTFGeneratorWinForms
{
    partial class AddCourt
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
            addCourtLabel = new Label();
            courtNameCapitalLabel = new Label();
            courtNameCapitalTextBox = new TextBox();
            courtNameSmallTextBox = new TextBox();
            courtNameSmallLabel = new Label();
            cityNameSmallTextBox = new TextBox();
            cityNameLabel = new Label();
            ArticlesgroupBox = new GroupBox();
            neutralRadioButton = new RadioButton();
            masculineRadioButton = new RadioButton();
            feminineRadioButton = new RadioButton();
            exitButton = new Button();
            saveButton = new Button();
            courtRegionGroupBox = new GroupBox();
            otherRegionadioButton = new RadioButton();
            AttikaRadioButton = new RadioButton();
            ArticlesgroupBox.SuspendLayout();
            courtRegionGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // addCourtLabel
            // 
            addCourtLabel.AutoSize = true;
            addCourtLabel.Location = new Point(48, 24);
            addCourtLabel.Name = "addCourtLabel";
            addCourtLabel.Size = new Size(114, 20);
            addCourtLabel.TabIndex = 0;
            addCourtLabel.Text = "Add Court Entry";
            // 
            // courtNameCapitalLabel
            // 
            courtNameCapitalLabel.AutoSize = true;
            courtNameCapitalLabel.Location = new Point(12, 91);
            courtNameCapitalLabel.Name = "courtNameCapitalLabel";
            courtNameCapitalLabel.Size = new Size(150, 20);
            courtNameCapitalLabel.TabIndex = 1;
            courtNameCapitalLabel.Text = "Court Name (Capital)";
            // 
            // courtNameCapitalTextBox
            // 
            courtNameCapitalTextBox.Location = new Point(168, 88);
            courtNameCapitalTextBox.Margin = new Padding(3, 4, 3, 4);
            courtNameCapitalTextBox.Name = "courtNameCapitalTextBox";
            courtNameCapitalTextBox.Size = new Size(164, 27);
            courtNameCapitalTextBox.TabIndex = 2;
            courtNameCapitalTextBox.TextChanged += courtNameCapitalTextBox_TextChanged;
            // 
            // courtNameSmallTextBox
            // 
            courtNameSmallTextBox.Location = new Point(168, 134);
            courtNameSmallTextBox.Margin = new Padding(3, 4, 3, 4);
            courtNameSmallTextBox.Name = "courtNameSmallTextBox";
            courtNameSmallTextBox.Size = new Size(164, 27);
            courtNameSmallTextBox.TabIndex = 4;
            courtNameSmallTextBox.TextChanged += courtNameSmallTextBox_TextChanged;
            // 
            // courtNameSmallLabel
            // 
            courtNameSmallLabel.AutoSize = true;
            courtNameSmallLabel.Location = new Point(12, 137);
            courtNameSmallLabel.Name = "courtNameSmallLabel";
            courtNameSmallLabel.Size = new Size(140, 20);
            courtNameSmallLabel.TabIndex = 3;
            courtNameSmallLabel.Text = "Court Name (Small)";
            // 
            // cityNameSmallTextBox
            // 
            cityNameSmallTextBox.Location = new Point(168, 184);
            cityNameSmallTextBox.Margin = new Padding(3, 4, 3, 4);
            cityNameSmallTextBox.Name = "cityNameSmallTextBox";
            cityNameSmallTextBox.Size = new Size(164, 27);
            cityNameSmallTextBox.TabIndex = 6;
            cityNameSmallTextBox.TextChanged += cityNameSmallTextBox_TextChanged;
            // 
            // cityNameLabel
            // 
            cityNameLabel.AutoSize = true;
            cityNameLabel.Location = new Point(12, 187);
            cityNameLabel.Name = "cityNameLabel";
            cityNameLabel.Size = new Size(129, 20);
            cityNameLabel.TabIndex = 5;
            cityNameLabel.Text = "City Name (Small)";
            // 
            // ArticlesgroupBox
            // 
            ArticlesgroupBox.Controls.Add(neutralRadioButton);
            ArticlesgroupBox.Controls.Add(masculineRadioButton);
            ArticlesgroupBox.Controls.Add(feminineRadioButton);
            ArticlesgroupBox.Location = new Point(12, 233);
            ArticlesgroupBox.Name = "ArticlesgroupBox";
            ArticlesgroupBox.Size = new Size(150, 138);
            ArticlesgroupBox.TabIndex = 7;
            ArticlesgroupBox.TabStop = false;
            ArticlesgroupBox.Text = "Articles";
            // 
            // neutralRadioButton
            // 
            neutralRadioButton.AutoSize = true;
            neutralRadioButton.Location = new Point(17, 90);
            neutralRadioButton.Name = "neutralRadioButton";
            neutralRadioButton.Size = new Size(108, 24);
            neutralRadioButton.TabIndex = 2;
            neutralRadioButton.TabStop = true;
            neutralRadioButton.Text = "Neutral (TO)";
            neutralRadioButton.UseVisualStyleBackColor = true;
            neutralRadioButton.CheckedChanged += neutralRadioButton_CheckedChanged;
            // 
            // masculineRadioButton
            // 
            masculineRadioButton.AutoSize = true;
            masculineRadioButton.Location = new Point(17, 60);
            masculineRadioButton.Name = "masculineRadioButton";
            masculineRadioButton.Size = new Size(118, 24);
            masculineRadioButton.TabIndex = 1;
            masculineRadioButton.TabStop = true;
            masculineRadioButton.Text = "Masculine (O)";
            masculineRadioButton.UseVisualStyleBackColor = true;
            masculineRadioButton.CheckedChanged += masculineRadioButton_CheckedChanged;
            // 
            // feminineRadioButton
            // 
            feminineRadioButton.AutoSize = true;
            feminineRadioButton.Location = new Point(17, 30);
            feminineRadioButton.Name = "feminineRadioButton";
            feminineRadioButton.Size = new Size(112, 24);
            feminineRadioButton.TabIndex = 0;
            feminineRadioButton.TabStop = true;
            feminineRadioButton.Text = "Feminine (H)";
            feminineRadioButton.UseVisualStyleBackColor = true;
            feminineRadioButton.CheckedChanged += feminineRadioButton_CheckedChanged;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(29, 397);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(108, 51);
            exitButton.TabIndex = 8;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(168, 397);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(108, 51);
            saveButton.TabIndex = 9;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // courtRegionGroupBox
            // 
            courtRegionGroupBox.Controls.Add(otherRegionadioButton);
            courtRegionGroupBox.Controls.Add(AttikaRadioButton);
            courtRegionGroupBox.Location = new Point(182, 233);
            courtRegionGroupBox.Name = "courtRegionGroupBox";
            courtRegionGroupBox.Size = new Size(150, 138);
            courtRegionGroupBox.TabIndex = 8;
            courtRegionGroupBox.TabStop = false;
            courtRegionGroupBox.Text = "Region";
            // 
            // otherRegionadioButton
            // 
            otherRegionadioButton.AutoSize = true;
            otherRegionadioButton.Location = new Point(17, 60);
            otherRegionadioButton.Name = "otherRegionadioButton";
            otherRegionadioButton.Size = new Size(115, 24);
            otherRegionadioButton.TabIndex = 1;
            otherRegionadioButton.TabStop = true;
            otherRegionadioButton.Text = "Other Region";
            otherRegionadioButton.UseVisualStyleBackColor = true;
            otherRegionadioButton.CheckedChanged += otherRegionadioButton_CheckedChanged;
            // 
            // AttikaRadioButton
            // 
            AttikaRadioButton.AutoSize = true;
            AttikaRadioButton.Location = new Point(17, 30);
            AttikaRadioButton.Name = "AttikaRadioButton";
            AttikaRadioButton.Size = new Size(75, 24);
            AttikaRadioButton.TabIndex = 0;
            AttikaRadioButton.TabStop = true;
            AttikaRadioButton.Text = "ATTIKA";
            AttikaRadioButton.UseVisualStyleBackColor = true;
            AttikaRadioButton.CheckedChanged += AttikaRadioButton_CheckedChanged;
            // 
            // AddCourt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 492);
            Controls.Add(courtRegionGroupBox);
            Controls.Add(saveButton);
            Controls.Add(exitButton);
            Controls.Add(ArticlesgroupBox);
            Controls.Add(cityNameSmallTextBox);
            Controls.Add(cityNameLabel);
            Controls.Add(courtNameSmallTextBox);
            Controls.Add(courtNameSmallLabel);
            Controls.Add(courtNameCapitalTextBox);
            Controls.Add(courtNameCapitalLabel);
            Controls.Add(addCourtLabel);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddCourt";
            Text = "AddCourt";
            ArticlesgroupBox.ResumeLayout(false);
            ArticlesgroupBox.PerformLayout();
            courtRegionGroupBox.ResumeLayout(false);
            courtRegionGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label addCourtLabel;
        private Label courtNameCapitalLabel;
        private TextBox courtNameCapitalTextBox;
        private TextBox courtNameSmallTextBox;
        private Label courtNameSmallLabel;
        private TextBox cityNameSmallTextBox;
        private Label cityNameLabel;
        private GroupBox ArticlesgroupBox;
        private RadioButton neutralRadioButton;
        private RadioButton masculineRadioButton;
        private RadioButton feminineRadioButton;
        private Button exitButton;
        private Button saveButton;
        private GroupBox courtRegionGroupBox;
        private RadioButton otherRegionadioButton;
        private RadioButton AttikaRadioButton;
    }
}