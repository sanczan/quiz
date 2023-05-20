namespace quiz
{
    partial class menu
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
            this.button_stworz_quiz = new System.Windows.Forms.Button();
            this.button_rozwiaz_quiz = new System.Windows.Forms.Button();
            this.button_edytuj_quiz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_stworz_quiz
            // 
            this.button_stworz_quiz.Location = new System.Drawing.Point(331, 121);
            this.button_stworz_quiz.Name = "button_stworz_quiz";
            this.button_stworz_quiz.Size = new System.Drawing.Size(111, 23);
            this.button_stworz_quiz.TabIndex = 0;
            this.button_stworz_quiz.Text = "Stwórz quiz";
            this.button_stworz_quiz.UseVisualStyleBackColor = true;
            this.button_stworz_quiz.Click += new System.EventHandler(this.stworz_quiz_Click);
            // 
            // button_rozwiaz_quiz
            // 
            this.button_rozwiaz_quiz.Location = new System.Drawing.Point(331, 234);
            this.button_rozwiaz_quiz.Name = "button_rozwiaz_quiz";
            this.button_rozwiaz_quiz.Size = new System.Drawing.Size(111, 23);
            this.button_rozwiaz_quiz.TabIndex = 1;
            this.button_rozwiaz_quiz.Text = "Rozwiąż quiz";
            this.button_rozwiaz_quiz.UseVisualStyleBackColor = true;
            // 
            // button_edytuj_quiz
            // 
            this.button_edytuj_quiz.Location = new System.Drawing.Point(331, 165);
            this.button_edytuj_quiz.Name = "button_edytuj_quiz";
            this.button_edytuj_quiz.Size = new System.Drawing.Size(111, 23);
            this.button_edytuj_quiz.TabIndex = 2;
            this.button_edytuj_quiz.Text = "Edytuj quiz";
            this.button_edytuj_quiz.UseVisualStyleBackColor = true;
            this.button_edytuj_quiz.Click += new System.EventHandler(this.button_edytuj_quiz_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_edytuj_quiz);
            this.Controls.Add(this.button_rozwiaz_quiz);
            this.Controls.Add(this.button_stworz_quiz);
            this.Name = "menu";
            this.Text = "menu_główne";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_stworz_quiz;
        private System.Windows.Forms.Button button_rozwiaz_quiz;
        private System.Windows.Forms.Button button_edytuj_quiz;
    }
}

