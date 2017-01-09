namespace Analiza06_zad2
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
            this.button19 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lrijec = new System.Windows.Forms.Label();
            this.lbrpok = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(13, 13);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(204, 66);
            this.button19.TabIndex = 24;
            this.button19.Text = "Nova igra";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Preostalo pokusaja:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 191);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(390, 20);
            this.textBox1.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Unos slova:";
            // 
            // lrijec
            // 
            this.lrijec.AutoSize = true;
            this.lrijec.Location = new System.Drawing.Point(138, 133);
            this.lrijec.Name = "lrijec";
            this.lrijec.Size = new System.Drawing.Size(0, 13);
            this.lrijec.TabIndex = 28;
            // 
            // lbrpok
            // 
            this.lbrpok.AutoSize = true;
            this.lbrpok.Location = new System.Drawing.Point(383, 40);
            this.lbrpok.Name = "lbrpok";
            this.lbrpok.Size = new System.Drawing.Size(0, 13);
            this.lbrpok.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Provjeri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 245);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbrpok);
            this.Controls.Add(this.lrijec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button19);
            this.Name = "Form1";
            this.Text = "Vješala";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lrijec;
        private System.Windows.Forms.Label lbrpok;
        private System.Windows.Forms.Button button1;
    }
}

