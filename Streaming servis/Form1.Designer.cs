namespace Streaming_servis
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btPogledaj = new System.Windows.Forms.Button();
            this.btOsvjezi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(397, 264);
            this.dataGridView1.TabIndex = 0;
            // 
            // btPogledaj
            // 
            this.btPogledaj.Location = new System.Drawing.Point(243, 310);
            this.btPogledaj.Name = "btPogledaj";
            this.btPogledaj.Size = new System.Drawing.Size(77, 52);
            this.btPogledaj.TabIndex = 1;
            this.btPogledaj.Text = "Pogledaj film";
            this.btPogledaj.UseVisualStyleBackColor = true;
            this.btPogledaj.Click += new System.EventHandler(this.btPogledaj_Click);
            // 
            // btOsvjezi
            // 
            this.btOsvjezi.Location = new System.Drawing.Point(344, 310);
            this.btOsvjezi.Name = "btOsvjezi";
            this.btOsvjezi.Size = new System.Drawing.Size(75, 54);
            this.btOsvjezi.TabIndex = 2;
            this.btOsvjezi.Text = "Osvjezi prikaz";
            this.btOsvjezi.UseVisualStyleBackColor = true;
            this.btOsvjezi.Click += new System.EventHandler(this.btOsvjezi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 406);
            this.Controls.Add(this.btOsvjezi);
            this.Controls.Add(this.btPogledaj);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btPogledaj;
        private System.Windows.Forms.Button btOsvjezi;
    }
}

