namespace Dionice_2
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
            this.Total = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.btShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStocks)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgStocks
            // 
            this.dtgStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgStocks.Location = new System.Drawing.Point(25, 30);
            this.dtgStocks.Name = "dtgStocks";
            this.dtgStocks.RowHeadersWidth = 51;
            this.dtgStocks.RowTemplate.Height = 24;
            this.dtgStocks.Size = new System.Drawing.Size(752, 334);
            this.dtgStocks.TabIndex = 0;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(611, 391);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(38, 16);
            this.Total.TabIndex = 1;
            this.Total.Text = "Total";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(677, 391);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(100, 22);
            this.tbTotal.TabIndex = 2;
            // 
            // btShow
            // 
            this.btShow.Location = new System.Drawing.Point(663, 436);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(114, 32);
            this.btShow.TabIndex = 3;
            this.btShow.Text = "Show";
            this.btShow.UseVisualStyleBackColor = true;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 480);
            this.Controls.Add(this.btShow);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.dtgStocks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgStocks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgStocks;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Button btShow;
    }
}

