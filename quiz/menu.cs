﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLite;

namespace quiz
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void stworz_quiz_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //new wybor_quizu().Show(); 
        }

        private void button_edytuj_quiz_Click(object sender, EventArgs e)
        {
            this.Hide();
            new wybor_quizu().Show(); 
        }
    }
}
