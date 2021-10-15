namespace MegaDesk_Burdett.Views
{
    partial class ViewQuotes
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
            this.label1 = new System.Windows.Forms.Label();
            this.SelectQuoteButton = new System.Windows.Forms.Button();
            this.QuoteErrorLabel = new System.Windows.Forms.Label();
            this.QuotesDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.QuotesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(127, 59);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Return to Main Menu";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "All Quotes";
            // 
            // SelectQuoteButton
            // 
            this.SelectQuoteButton.Location = new System.Drawing.Point(627, 405);
            this.SelectQuoteButton.Name = "SelectQuoteButton";
            this.SelectQuoteButton.Size = new System.Drawing.Size(122, 33);
            this.SelectQuoteButton.TabIndex = 8;
            this.SelectQuoteButton.Text = "View Quote Details";
            this.SelectQuoteButton.UseVisualStyleBackColor = true;
            this.SelectQuoteButton.Click += new System.EventHandler(this.SelectQuoteButton_Click);
            // 
            // QuoteErrorLabel
            // 
            this.QuoteErrorLabel.AutoSize = true;
            this.QuoteErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuoteErrorLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.QuoteErrorLabel.Location = new System.Drawing.Point(417, 401);
            this.QuoteErrorLabel.Name = "QuoteErrorLabel";
            this.QuoteErrorLabel.Size = new System.Drawing.Size(0, 17);
            this.QuoteErrorLabel.TabIndex = 9;
            // 
            // QuotesDataGrid
            // 
            this.QuotesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QuotesDataGrid.Location = new System.Drawing.Point(225, 38);
            this.QuotesDataGrid.Name = "QuotesDataGrid";
            this.QuotesDataGrid.ReadOnly = true;
            this.QuotesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.QuotesDataGrid.Size = new System.Drawing.Size(469, 347);
            this.QuotesDataGrid.TabIndex = 10;
            // 
            // ViewQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.QuotesDataGrid);
            this.Controls.Add(this.QuoteErrorLabel);
            this.Controls.Add(this.SelectQuoteButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackButton);
            this.Name = "ViewQuotes";
            this.Text = "ViewQuotes";
            ((System.ComponentModel.ISupportInitialize)(this.QuotesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SelectQuoteButton;
        private System.Windows.Forms.Label QuoteErrorLabel;
        private System.Windows.Forms.DataGridView QuotesDataGrid;
    }
}