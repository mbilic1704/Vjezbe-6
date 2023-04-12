namespace Glasanje
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOIB = new System.Windows.Forms.TextBox();
            this.cbOpcija = new System.Windows.Forms.ComboBox();
            this.btGlasaj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbZa = new System.Windows.Forms.Label();
            this.lbProtiv = new System.Windows.Forms.Label();
            this.lbSuzdrzan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "OIB:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opcija:";
            // 
            // tbOIB
            // 
            this.tbOIB.Location = new System.Drawing.Point(26, 62);
            this.tbOIB.Name = "tbOIB";
            this.tbOIB.Size = new System.Drawing.Size(121, 22);
            this.tbOIB.TabIndex = 2;
            // 
            // cbOpcija
            // 
            this.cbOpcija.FormattingEnabled = true;
            this.cbOpcija.Location = new System.Drawing.Point(26, 143);
            this.cbOpcija.Name = "cbOpcija";
            this.cbOpcija.Size = new System.Drawing.Size(121, 24);
            this.cbOpcija.TabIndex = 3;
            // 
            // btGlasaj
            // 
            this.btGlasaj.Location = new System.Drawing.Point(26, 204);
            this.btGlasaj.Name = "btGlasaj";
            this.btGlasaj.Size = new System.Drawing.Size(121, 46);
            this.btGlasaj.TabIndex = 4;
            this.btGlasaj.Text = "Glasaj";
            this.btGlasaj.UseVisualStyleBackColor = true;
            this.btGlasaj.Click += new System.EventHandler(this.btGlasaj_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "REZULTATI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "ZA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "PROTIV: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "SUZDRZAN:";
            // 
            // lbZa
            // 
            this.lbZa.AutoSize = true;
            this.lbZa.Location = new System.Drawing.Point(374, 78);
            this.lbZa.Name = "lbZa";
            this.lbZa.Size = new System.Drawing.Size(14, 16);
            this.lbZa.TabIndex = 9;
            this.lbZa.Text = "0";
            // 
            // lbProtiv
            // 
            this.lbProtiv.AutoSize = true;
            this.lbProtiv.Location = new System.Drawing.Point(413, 132);
            this.lbProtiv.Name = "lbProtiv";
            this.lbProtiv.Size = new System.Drawing.Size(14, 16);
            this.lbProtiv.TabIndex = 10;
            this.lbProtiv.Text = "0";
            // 
            // lbSuzdrzan
            // 
            this.lbSuzdrzan.AutoSize = true;
            this.lbSuzdrzan.Location = new System.Drawing.Point(424, 188);
            this.lbSuzdrzan.Name = "lbSuzdrzan";
            this.lbSuzdrzan.Size = new System.Drawing.Size(14, 16);
            this.lbSuzdrzan.TabIndex = 11;
            this.lbSuzdrzan.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 311);
            this.Controls.Add(this.lbSuzdrzan);
            this.Controls.Add(this.lbProtiv);
            this.Controls.Add(this.lbZa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btGlasaj);
            this.Controls.Add(this.cbOpcija);
            this.Controls.Add(this.tbOIB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOIB;
        private System.Windows.Forms.ComboBox cbOpcija;
        private System.Windows.Forms.Button btGlasaj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbZa;
        private System.Windows.Forms.Label lbProtiv;
        private System.Windows.Forms.Label lbSuzdrzan;
    }
}

