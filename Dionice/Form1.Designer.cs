namespace Dionice
{
    partial class Form1
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
            this.dtgStocks = new System.Windows.Forms.DataGridView();
            this.btShowResults = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStocks)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgStocks
            // 
            this.dtgStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgStocks.Location = new System.Drawing.Point(12, 29);
            this.dtgStocks.Name = "dtgStocks";
            this.dtgStocks.RowHeadersWidth = 51;
            this.dtgStocks.RowTemplate.Height = 24;
            this.dtgStocks.Size = new System.Drawing.Size(776, 364);
            this.dtgStocks.TabIndex = 0;
            // 
            // btShowResults
            // 
            this.btShowResults.Location = new System.Drawing.Point(659, 399);
            this.btShowResults.Name = "btShowResults";
            this.btShowResults.Size = new System.Drawing.Size(116, 39);
            this.btShowResults.TabIndex = 1;
            this.btShowResults.Text = "Show results";
            this.btShowResults.UseVisualStyleBackColor = true;
            this.btShowResults.Click += new System.EventHandler(this.btShowResults_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btShowResults);
            this.Controls.Add(this.dtgStocks);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgStocks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgStocks;
        private System.Windows.Forms.Button btShowResults;
    }
}

