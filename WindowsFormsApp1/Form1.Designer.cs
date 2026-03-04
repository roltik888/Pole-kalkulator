namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Oblicz = new System.Windows.Forms.Button();
            this.BokA = new System.Windows.Forms.TextBox();
            this.BokB = new System.Windows.Forms.TextBox();
            this.Wybor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Pole = new System.Windows.Forms.Label();
            this.Obwod = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Oblicz
            // 
            this.Oblicz.Location = new System.Drawing.Point(492, 109);
            this.Oblicz.Name = "Oblicz";
            this.Oblicz.Size = new System.Drawing.Size(75, 23);
            this.Oblicz.TabIndex = 0;
            this.Oblicz.Text = "Oblicz";
            this.Oblicz.UseVisualStyleBackColor = true;
            this.Oblicz.Click += new System.EventHandler(this.button1_Click);
            // 
            // BokA
            // 
            this.BokA.Location = new System.Drawing.Point(249, 112);
            this.BokA.Name = "BokA";
            this.BokA.Size = new System.Drawing.Size(100, 20);
            this.BokA.TabIndex = 1;
            this.BokA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BokB
            // 
            this.BokB.Location = new System.Drawing.Point(249, 204);
            this.BokB.Name = "BokB";
            this.BokB.Size = new System.Drawing.Size(100, 20);
            this.BokB.TabIndex = 2;
            this.BokB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Wybor
            // 
            this.Wybor.FormattingEnabled = true;
            this.Wybor.Location = new System.Drawing.Point(446, 203);
            this.Wybor.Name = "Wybor";
            this.Wybor.Size = new System.Drawing.Size(121, 21);
            this.Wybor.TabIndex = 3;
            this.Wybor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wpisz bok A";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wpisz bok B";
            // 
            // Pole
            // 
            this.Pole.AutoSize = true;
            this.Pole.Location = new System.Drawing.Point(249, 281);
            this.Pole.Name = "Pole";
            this.Pole.Size = new System.Drawing.Size(28, 13);
            this.Pole.TabIndex = 6;
            this.Pole.Text = "Pole";
            // 
            // Obwod
            // 
            this.Obwod.AutoSize = true;
            this.Obwod.Location = new System.Drawing.Point(249, 294);
            this.Obwod.Name = "Obwod";
            this.Obwod.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Obwod.Size = new System.Drawing.Size(41, 13);
            this.Obwod.TabIndex = 7;
            this.Obwod.Text = "Obwód";
            this.Obwod.Click += new System.EventHandler(this.Obwod_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Obwod);
            this.Controls.Add(this.Pole);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Wybor);
            this.Controls.Add(this.BokB);
            this.Controls.Add(this.BokA);
            this.Controls.Add(this.Oblicz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Oblicz;
        private System.Windows.Forms.TextBox BokA;
        private System.Windows.Forms.TextBox BokB;
        private System.Windows.Forms.ComboBox Wybor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Pole;
        private System.Windows.Forms.Label Obwod;
    }
}

