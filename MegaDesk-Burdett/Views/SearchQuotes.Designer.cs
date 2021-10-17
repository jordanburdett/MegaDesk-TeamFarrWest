namespace MegaDesk_Burdett
{
    partial class SearchQuotes
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
            this.searchLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MaterialComboBox = new System.Windows.Forms.ComboBox();
            this.SearchQuotesResults = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.SearchQuotesErrorText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SearchQuotesResults)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(127, 59);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Return to Main Menu";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(304, 34);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(230, 37);
            this.searchLabel.TabIndex = 3;
            this.searchLabel.Text = "Search Quotes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "By Desk Material";
            // 
            // MaterialComboBox
            // 
            this.MaterialComboBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MaterialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaterialComboBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MaterialComboBox.FormattingEnabled = true;
            this.MaterialComboBox.Items.AddRange(new object[] {
            "laminate",
            "oak",
            "rosewood",
            "veneer",
            "pine"});
            this.MaterialComboBox.Location = new System.Drawing.Point(357, 128);
            this.MaterialComboBox.Name = "MaterialComboBox";
            this.MaterialComboBox.Size = new System.Drawing.Size(121, 21);
            this.MaterialComboBox.TabIndex = 5;
            this.MaterialComboBox.SelectedValueChanged += new System.EventHandler(this.OnValueSelected);
            // 
            // SearchQuotesResults
            // 
            this.SearchQuotesResults.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchQuotesResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchQuotesResults.Location = new System.Drawing.Point(197, 170);
            this.SearchQuotesResults.Name = "SearchQuotesResults";
            this.SearchQuotesResults.ReadOnly = true;
            this.SearchQuotesResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SearchQuotesResults.Size = new System.Drawing.Size(441, 207);
            this.SearchQuotesResults.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(666, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "View Quote Details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchQuotesErrorText
            // 
            this.SearchQuotesErrorText.AutoSize = true;
            this.SearchQuotesErrorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchQuotesErrorText.ForeColor = System.Drawing.Color.IndianRed;
            this.SearchQuotesErrorText.Location = new System.Drawing.Point(340, 394);
            this.SearchQuotesErrorText.Name = "SearchQuotesErrorText";
            this.SearchQuotesErrorText.Size = new System.Drawing.Size(0, 17);
            this.SearchQuotesErrorText.TabIndex = 12;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchQuotesErrorText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchQuotesResults);
            this.Controls.Add(this.MaterialComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.BackButton);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            ((System.ComponentModel.ISupportInitialize)(this.SearchQuotesResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox MaterialComboBox;
        private System.Windows.Forms.DataGridView SearchQuotesResults;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label SearchQuotesErrorText;
    }
}