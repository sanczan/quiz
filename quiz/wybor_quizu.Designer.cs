namespace quiz
{
    partial class wybor_quizu
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
            this.combobox_wybor_quizu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_edytuj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combobox_wybor_quizu
            // 
            this.combobox_wybor_quizu.FormattingEnabled = true;
            this.combobox_wybor_quizu.Location = new System.Drawing.Point(203, 123);
            this.combobox_wybor_quizu.Name = "combobox_wybor_quizu";
            this.combobox_wybor_quizu.Size = new System.Drawing.Size(270, 21);
            this.combobox_wybor_quizu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wybierz quiz";
            // 
            // button_edytuj
            // 
            this.button_edytuj.Location = new System.Drawing.Point(298, 196);
            this.button_edytuj.Name = "button_edytuj";
            this.button_edytuj.Size = new System.Drawing.Size(75, 23);
            this.button_edytuj.TabIndex = 2;
            this.button_edytuj.Text = "Edytuj";
            this.button_edytuj.UseVisualStyleBackColor = true;
            this.button_edytuj.Click += new System.EventHandler(this.button_edytuj_Click);
            // 
            // wybor_quizu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_edytuj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combobox_wybor_quizu);
            this.Name = "wybor_quizu";
            this.Text = "wybor";
            this.Load += new System.EventHandler(this.wybór_quizu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combobox_wybor_quizu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_edytuj;
    }
}