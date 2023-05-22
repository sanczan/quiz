using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace quiz
{
    public partial class wybor_quizu : Form
    {
        public static string nazwa_quizu = "";
        public wybor_quizu()
        {
            InitializeComponent();
        }

        private void wybór_quizu_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=D:\visual\projekty\quiz\quiz\quizy_database.db;Version=3;"; //dostanie sie do pliku .db
            System.Data.SQLite.SQLiteConnection connection = new System.Data.SQLite.SQLiteConnection(connectionString); //utworzenie polaczenia

            connection.Open();

            string query = "SELECT nazwa from quizy";   //sformuowanie zapytania

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);   //wykonanie zapytania
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            combobox_wybor_quizu.DataSource = dataTable;

            combobox_wybor_quizu.DisplayMember = "nazwa";

            connection.Close();

        }

        private void button_edytuj_Click(object sender, EventArgs e)
        {
            this.Hide();
            new edycja_pytan().Show();
        }

        private void combobox_wybor_quizu_SelectedValueChanged(object sender, EventArgs e)
        {
            nazwa_quizu = combobox_wybor_quizu.Text;
        }
    }
}
