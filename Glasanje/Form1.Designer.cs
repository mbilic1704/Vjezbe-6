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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
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
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(272, 34);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(215, 216);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 311);
            this.Controls.Add(this.richTextBox1);
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
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

