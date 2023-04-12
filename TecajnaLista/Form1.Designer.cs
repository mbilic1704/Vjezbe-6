namespace TecajnaLista
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
            this.dtgRates = new System.Windows.Forms.DataGridView();
            this.btShowRates = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRates)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgRates
            // 
            this.dtgRates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRates.Location = new System.Drawing.Point(12, 23);
            this.dtgRates.Name = "dtgRates";
            this.dtgRates.RowHeadersWidth = 51;
            this.dtgRates.RowTemplate.Height = 24;
            this.dtgRates.Size = new System.Drawing.Size(579, 329);
            this.dtgRates.TabIndex = 0;
            // 
            // btShowRates
            // 
            this.btShowRates.Location = new System.Drawing.Point(468, 380);
            this.btShowRates.Name = "btShowRates";
            this.btShowRates.Size = new System.Drawing.Size(123, 37);
            this.btShowRates.TabIndex = 1;
            this.btShowRates.Text = "Show rates";
            this.btShowRates.UseVisualStyleBackColor = true;
            this.btShowRates.Click += new System.EventHandler(this.btShowRates_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 436);
            this.Controls.Add(this.btShowRates);
            this.Controls.Add(this.dtgRates);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgRates)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgRates;
        private System.Windows.Forms.Button btShowRates;
    }
}

