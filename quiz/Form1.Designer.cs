namespace quiz
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
            this.pytanie = new System.Windows.Forms.TextBox();
            this.odpowiedz_pierwsza = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.odpowiedz_druga = new System.Windows.Forms.TextBox();
            this.odpowiedz_trzecia = new System.Windows.Forms.TextBox();
            this.odpowiedz_czwarta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pytanie
            // 
            this.pytanie.Enabled = false;
            this.pytanie.Location = new System.Drawing.Point(221, 66);
            this.pytanie.Name = "pytanie";
            this.pytanie.Size = new System.Drawing.Size(100, 20);
            this.pytanie.TabIndex = 0;
            // 
            // odpowiedz_pierwsza
            // 
            this.odpowiedz_pierwsza.Location = new System.Drawing.Point(221, 119);
            this.odpowiedz_pierwsza.Name = "odpowiedz_pierwsza";
            this.odpowiedz_pierwsza.Size = new System.Drawing.Size(100, 20);
            this.odpowiedz_pierwsza.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // odpowiedz_druga
            // 
            this.odpowiedz_druga.Location = new System.Drawing.Point(221, 167);
            this.odpowiedz_druga.Name = "odpowiedz_druga";
            this.odpowiedz_druga.Size = new System.Drawing.Size(100, 20);
            this.odpowiedz_druga.TabIndex = 3;
            // 
            // odpowiedz_trzecia
            // 
            this.odpowiedz_trzecia.Enabled = false;
            this.odpowiedz_trzecia.Location = new System.Drawing.Point(221, 210);
            this.odpowiedz_trzecia.Name = "odpowiedz_trzecia";
            this.odpowiedz_trzecia.Size = new System.Drawing.Size(100, 20);
            this.odpowiedz_trzecia.TabIndex = 4;
            // 
            // odpowiedz_czwarta
            // 
            this.odpowiedz_czwarta.Enabled = false;
            this.odpowiedz_czwarta.Location = new System.Drawing.Point(221, 256);
            this.odpowiedz_czwarta.Name = "odpowiedz_czwarta";
            this.odpowiedz_czwarta.Size = new System.Drawing.Size(100, 20);
            this.odpowiedz_czwarta.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pytanie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Odpowiedz 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Odpowiedz 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Odpowiedz 3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Odpowiedz 4:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(491, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "na razie dziala tylko odp 1 i 2 pez pytania xD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.odpowiedz_czwarta);
            this.Controls.Add(this.odpowiedz_trzecia);
            this.Controls.Add(this.odpowiedz_druga);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.odpowiedz_pierwsza);
            this.Controls.Add(this.pytanie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pytanie;
        private System.Windows.Forms.TextBox odpowiedz_pierwsza;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox odpowiedz_druga;
        private System.Windows.Forms.TextBox odpowiedz_trzecia;
        private System.Windows.Forms.TextBox odpowiedz_czwarta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

