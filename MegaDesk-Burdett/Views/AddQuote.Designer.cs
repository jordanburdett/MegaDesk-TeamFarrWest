namespace MegaDesk_Burdett
{
    partial class AddQuote
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
            this.BackButton = new System.Windows.Forms.Button();
            this.CustomerNameTextField = new System.Windows.Forms.TextBox();
            this.ViewTitleLabel = new System.Windows.Forms.Label();
            this.CustomerNameErrorLabel = new System.Windows.Forms.Label();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.DeskWidthLabel = new System.Windows.Forms.Label();
            this.DeskWidthErrorLabel = new System.Windows.Forms.Label();
            this.DeskDepthLabel = new System.Windows.Forms.Label();
            this.DeskDepthErrorLabel = new System.Windows.Forms.Label();
            this.NumberOfDrawersLabel = new System.Windows.Forms.Label();
            this.NumberOfDrawersErrorLabel = new System.Windows.Forms.Label();
            this.NumberOfDrawersTextField = new System.Windows.Forms.NumericUpDown();
            this.DeskMaterialLabel = new System.Windows.Forms.Label();
            this.DeskTopMaterialErrorLabel = new System.Windows.Forms.Label();
            this.DesktopMaterialTextField = new System.Windows.Forms.TextBox();
            this.AddNewQuoteButton = new System.Windows.Forms.Button();
            this.DeskWidthInputField = new System.Windows.Forms.NumericUpDown();
            this.DeskDepthInputField = new System.Windows.Forms.NumericUpDown();
            this.DeliveryOptionsLabel = new System.Windows.Forms.Label();
            this.DeliveryOptionsErrorLabel = new System.Windows.Forms.Label();
            this.DeliveryOptionsTextField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfDrawersTextField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeskWidthInputField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeskDepthInputField)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(127, 59);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Return to Main Menu";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CustomerNameTextField
            // 
            this.CustomerNameTextField.Location = new System.Drawing.Point(334, 115);
            this.CustomerNameTextField.Name = "CustomerNameTextField";
            this.CustomerNameTextField.Size = new System.Drawing.Size(100, 20);
            this.CustomerNameTextField.TabIndex = 1;
            this.CustomerNameTextField.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateCustomerName);
            // 
            // ViewTitleLabel
            // 
            this.ViewTitleLabel.AutoSize = true;
            this.ViewTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewTitleLabel.Location = new System.Drawing.Point(304, 34);
            this.ViewTitleLabel.Name = "ViewTitleLabel";
            this.ViewTitleLabel.Size = new System.Drawing.Size(244, 37);
            this.ViewTitleLabel.TabIndex = 3;
            this.ViewTitleLabel.Text = "Add New Quote";
            // 
            // CustomerNameErrorLabel
            // 
            this.CustomerNameErrorLabel.AutoSize = true;
            this.CustomerNameErrorLabel.ForeColor = System.Drawing.Color.Crimson;
            this.CustomerNameErrorLabel.Location = new System.Drawing.Point(440, 118);
            this.CustomerNameErrorLabel.MaximumSize = new System.Drawing.Size(125, 0);
            this.CustomerNameErrorLabel.MinimumSize = new System.Drawing.Size(125, 0);
            this.CustomerNameErrorLabel.Name = "CustomerNameErrorLabel";
            this.CustomerNameErrorLabel.Size = new System.Drawing.Size(125, 13);
            this.CustomerNameErrorLabel.TabIndex = 4;
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Location = new System.Drawing.Point(223, 118);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(82, 13);
            this.CustomerNameLabel.TabIndex = 5;
            this.CustomerNameLabel.Text = "Customer Name";
            // 
            // DeskWidthLabel
            // 
            this.DeskWidthLabel.AutoSize = true;
            this.DeskWidthLabel.Location = new System.Drawing.Point(223, 144);
            this.DeskWidthLabel.Name = "DeskWidthLabel";
            this.DeskWidthLabel.Size = new System.Drawing.Size(63, 13);
            this.DeskWidthLabel.TabIndex = 8;
            this.DeskWidthLabel.Text = "Desk Width";
            // 
            // DeskWidthErrorLabel
            // 
            this.DeskWidthErrorLabel.AutoSize = true;
            this.DeskWidthErrorLabel.ForeColor = System.Drawing.Color.Crimson;
            this.DeskWidthErrorLabel.Location = new System.Drawing.Point(440, 144);
            this.DeskWidthErrorLabel.MaximumSize = new System.Drawing.Size(125, 0);
            this.DeskWidthErrorLabel.MinimumSize = new System.Drawing.Size(125, 0);
            this.DeskWidthErrorLabel.Name = "DeskWidthErrorLabel";
            this.DeskWidthErrorLabel.Size = new System.Drawing.Size(125, 13);
            this.DeskWidthErrorLabel.TabIndex = 7;
            // 
            // DeskDepthLabel
            // 
            this.DeskDepthLabel.AutoSize = true;
            this.DeskDepthLabel.Location = new System.Drawing.Point(223, 170);
            this.DeskDepthLabel.Name = "DeskDepthLabel";
            this.DeskDepthLabel.Size = new System.Drawing.Size(64, 13);
            this.DeskDepthLabel.TabIndex = 11;
            this.DeskDepthLabel.Text = "Desk Depth";
            // 
            // DeskDepthErrorLabel
            // 
            this.DeskDepthErrorLabel.AutoSize = true;
            this.DeskDepthErrorLabel.ForeColor = System.Drawing.Color.Crimson;
            this.DeskDepthErrorLabel.Location = new System.Drawing.Point(440, 170);
            this.DeskDepthErrorLabel.MaximumSize = new System.Drawing.Size(125, 0);
            this.DeskDepthErrorLabel.MinimumSize = new System.Drawing.Size(125, 0);
            this.DeskDepthErrorLabel.Name = "DeskDepthErrorLabel";
            this.DeskDepthErrorLabel.Size = new System.Drawing.Size(125, 13);
            this.DeskDepthErrorLabel.TabIndex = 10;
            // 
            // NumberOfDrawersLabel
            // 
            this.NumberOfDrawersLabel.AutoSize = true;
            this.NumberOfDrawersLabel.Location = new System.Drawing.Point(223, 196);
            this.NumberOfDrawersLabel.Name = "NumberOfDrawersLabel";
            this.NumberOfDrawersLabel.Size = new System.Drawing.Size(98, 13);
            this.NumberOfDrawersLabel.TabIndex = 14;
            this.NumberOfDrawersLabel.Text = "Number of Drawers";
            // 
            // NumberOfDrawersErrorLabel
            // 
            this.NumberOfDrawersErrorLabel.AutoSize = true;
            this.NumberOfDrawersErrorLabel.ForeColor = System.Drawing.Color.Crimson;
            this.NumberOfDrawersErrorLabel.Location = new System.Drawing.Point(440, 196);
            this.NumberOfDrawersErrorLabel.MaximumSize = new System.Drawing.Size(125, 0);
            this.NumberOfDrawersErrorLabel.MinimumSize = new System.Drawing.Size(125, 0);
            this.NumberOfDrawersErrorLabel.Name = "NumberOfDrawersErrorLabel";
            this.NumberOfDrawersErrorLabel.Size = new System.Drawing.Size(125, 13);
            this.NumberOfDrawersErrorLabel.TabIndex = 13;
            // 
            // NumberOfDrawersTextField
            // 
            this.NumberOfDrawersTextField.Location = new System.Drawing.Point(334, 196);
            this.NumberOfDrawersTextField.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.NumberOfDrawersTextField.Name = "NumberOfDrawersTextField";
            this.NumberOfDrawersTextField.Size = new System.Drawing.Size(100, 20);
            this.NumberOfDrawersTextField.TabIndex = 4;
            this.NumberOfDrawersTextField.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateNumberOfDrawers);
            // 
            // DeskMaterialLabel
            // 
            this.DeskMaterialLabel.AutoSize = true;
            this.DeskMaterialLabel.Location = new System.Drawing.Point(223, 225);
            this.DeskMaterialLabel.Name = "DeskMaterialLabel";
            this.DeskMaterialLabel.Size = new System.Drawing.Size(87, 13);
            this.DeskMaterialLabel.TabIndex = 18;
            this.DeskMaterialLabel.Text = "Desktop Material";
            // 
            // DeskTopMaterialErrorLabel
            // 
            this.DeskTopMaterialErrorLabel.AutoSize = true;
            this.DeskTopMaterialErrorLabel.ForeColor = System.Drawing.Color.Black;
            this.DeskTopMaterialErrorLabel.Location = new System.Drawing.Point(440, 225);
            this.DeskTopMaterialErrorLabel.MinimumSize = new System.Drawing.Size(150, 0);
            this.DeskTopMaterialErrorLabel.Name = "DeskTopMaterialErrorLabel";
            this.DeskTopMaterialErrorLabel.Size = new System.Drawing.Size(199, 13);
            this.DeskTopMaterialErrorLabel.TabIndex = 17;
            this.DeskTopMaterialErrorLabel.Text = "laminate, oak, rosewood, veneer, or pine";
            // 
            // DesktopMaterialTextField
            // 
            this.DesktopMaterialTextField.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.DesktopMaterialTextField.Location = new System.Drawing.Point(334, 222);
            this.DesktopMaterialTextField.Name = "DesktopMaterialTextField";
            this.DesktopMaterialTextField.Size = new System.Drawing.Size(100, 20);
            this.DesktopMaterialTextField.TabIndex = 5;
            this.DesktopMaterialTextField.Validating += new System.ComponentModel.CancelEventHandler(this.DesktopMaterialValidation);
            // 
            // AddNewQuoteButton
            // 
            this.AddNewQuoteButton.BackColor = System.Drawing.Color.Transparent;
            this.AddNewQuoteButton.Location = new System.Drawing.Point(311, 339);
            this.AddNewQuoteButton.Name = "AddNewQuoteButton";
            this.AddNewQuoteButton.Size = new System.Drawing.Size(127, 59);
            this.AddNewQuoteButton.TabIndex = 7;
            this.AddNewQuoteButton.Text = "Add New Quote";
            this.AddNewQuoteButton.UseVisualStyleBackColor = false;
            this.AddNewQuoteButton.Click += new System.EventHandler(this.AddNewQuoteButton_Click);
            // 
            // DeskWidthInputField
            // 
            this.DeskWidthInputField.Location = new System.Drawing.Point(334, 144);
            this.DeskWidthInputField.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.DeskWidthInputField.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.DeskWidthInputField.Name = "DeskWidthInputField";
            this.DeskWidthInputField.Size = new System.Drawing.Size(100, 20);
            this.DeskWidthInputField.TabIndex = 2;
            this.DeskWidthInputField.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.DeskWidthInputField.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateDeskWidth);
            // 
            // DeskDepthInputField
            // 
            this.DeskDepthInputField.Location = new System.Drawing.Point(334, 170);
            this.DeskDepthInputField.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.DeskDepthInputField.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.DeskDepthInputField.Name = "DeskDepthInputField";
            this.DeskDepthInputField.Size = new System.Drawing.Size(100, 20);
            this.DeskDepthInputField.TabIndex = 3;
            this.DeskDepthInputField.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.DeskDepthInputField.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateDeskDepth);
            // 
            // DeliveryOptionsLabel
            // 
            this.DeliveryOptionsLabel.AutoSize = true;
            this.DeliveryOptionsLabel.Location = new System.Drawing.Point(223, 251);
            this.DeliveryOptionsLabel.Name = "DeliveryOptionsLabel";
            this.DeliveryOptionsLabel.Size = new System.Drawing.Size(84, 13);
            this.DeliveryOptionsLabel.TabIndex = 24;
            this.DeliveryOptionsLabel.Text = "Delivery Options";
            // 
            // DeliveryOptionsErrorLabel
            // 
            this.DeliveryOptionsErrorLabel.AutoSize = true;
            this.DeliveryOptionsErrorLabel.ForeColor = System.Drawing.Color.Black;
            this.DeliveryOptionsErrorLabel.Location = new System.Drawing.Point(440, 251);
            this.DeliveryOptionsErrorLabel.MaximumSize = new System.Drawing.Size(125, 0);
            this.DeliveryOptionsErrorLabel.MinimumSize = new System.Drawing.Size(125, 0);
            this.DeliveryOptionsErrorLabel.Name = "DeliveryOptionsErrorLabel";
            this.DeliveryOptionsErrorLabel.Size = new System.Drawing.Size(125, 13);
            this.DeliveryOptionsErrorLabel.TabIndex = 23;
            this.DeliveryOptionsErrorLabel.Text = "3,5,7";
            // 
            // DeliveryOptionsTextField
            // 
            this.DeliveryOptionsTextField.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.DeliveryOptionsTextField.Location = new System.Drawing.Point(334, 248);
            this.DeliveryOptionsTextField.Name = "DeliveryOptionsTextField";
            this.DeliveryOptionsTextField.Size = new System.Drawing.Size(100, 20);
            this.DeliveryOptionsTextField.TabIndex = 6;
            this.DeliveryOptionsTextField.Validating += new System.ComponentModel.CancelEventHandler(this.DeliveryOptionsValidation);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeliveryOptionsLabel);
            this.Controls.Add(this.DeliveryOptionsErrorLabel);
            this.Controls.Add(this.DeliveryOptionsTextField);
            this.Controls.Add(this.DeskDepthInputField);
            this.Controls.Add(this.DeskWidthInputField);
            this.Controls.Add(this.AddNewQuoteButton);
            this.Controls.Add(this.DeskMaterialLabel);
            this.Controls.Add(this.DeskTopMaterialErrorLabel);
            this.Controls.Add(this.DesktopMaterialTextField);
            this.Controls.Add(this.NumberOfDrawersTextField);
            this.Controls.Add(this.NumberOfDrawersLabel);
            this.Controls.Add(this.NumberOfDrawersErrorLabel);
            this.Controls.Add(this.DeskDepthLabel);
            this.Controls.Add(this.DeskDepthErrorLabel);
            this.Controls.Add(this.DeskWidthLabel);
            this.Controls.Add(this.DeskWidthErrorLabel);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.CustomerNameErrorLabel);
            this.Controls.Add(this.ViewTitleLabel);
            this.Controls.Add(this.CustomerNameTextField);
            this.Controls.Add(this.BackButton);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfDrawersTextField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeskWidthInputField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeskDepthInputField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox CustomerNameTextField;
        private System.Windows.Forms.Label ViewTitleLabel;
        private System.Windows.Forms.Label CustomerNameErrorLabel;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.Label DeskWidthLabel;
        private System.Windows.Forms.Label DeskWidthErrorLabel;
        private System.Windows.Forms.Label DeskDepthLabel;
        private System.Windows.Forms.Label DeskDepthErrorLabel;
        private System.Windows.Forms.Label NumberOfDrawersLabel;
        private System.Windows.Forms.Label NumberOfDrawersErrorLabel;
        private System.Windows.Forms.NumericUpDown NumberOfDrawersTextField;
        private System.Windows.Forms.Label DeskMaterialLabel;
        private System.Windows.Forms.Label DeskTopMaterialErrorLabel;
        private System.Windows.Forms.TextBox DesktopMaterialTextField;
        private System.Windows.Forms.Button AddNewQuoteButton;
        private System.Windows.Forms.NumericUpDown DeskWidthInputField;
        private System.Windows.Forms.NumericUpDown DeskDepthInputField;
        private System.Windows.Forms.Label DeliveryOptionsLabel;
        private System.Windows.Forms.Label DeliveryOptionsErrorLabel;
        private System.Windows.Forms.TextBox DeliveryOptionsTextField;
    }
}