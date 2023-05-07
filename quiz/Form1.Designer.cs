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
            this.SuspendLayout();
            // 
            // pytanie
            // 
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
            this.button1.Location = new System.Drawing.Point(221, 315);
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
            this.odpowiedz_trzecia.Location = new System.Drawing.Point(221, 210);
            this.odpowiedz_trzecia.Name = "odpowiedz_trzecia";
            this.odpowiedz_trzecia.Size = new System.Drawing.Size(100, 20);
            this.odpowiedz_trzecia.TabIndex = 4;
            // 
            // odpowiedz_czwarta
            // 
            this.odpowiedz_czwarta.Location = new System.Drawing.Point(221, 256);
            this.odpowiedz_czwarta.Name = "odpowiedz_czwarta";
            this.odpowiedz_czwarta.Size = new System.Drawing.Size(100, 20);
            this.odpowiedz_czwarta.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

