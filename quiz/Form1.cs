using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"D:\visual\projekty\quiz\quiz\test.db"))
            {
                //nic nie rob
            }
            else
            {
                var db = new SQLiteConnection(@"D:\visual\projekty\quiz\quiz\test.db");

                db.CreateTable<dbinfo> ();

                db.Close ();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbinfo temp = new dbinfo(pytanie.Text);

            var db = new SQLiteConnection(@"D:\visual\projekty\quiz\quiz\test.db");

            db.Insert(temp);

            db.Close ();
        }
    }
}
