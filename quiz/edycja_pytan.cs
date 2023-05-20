using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace quiz
{
    public partial class edycja_pytan : Form
    {
        public edycja_pytan()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string connectionString = @"Data Source=D:\visual\projekty\quiz\quiz\quizy_database.db;Version=3;"; //dostanie sie do pliku .db

            string connectionString = @"Data Source=D:\visual\projekty\quiz\quiz\quizy_database.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO TableName (Column1, Column2) VALUES (@Value1, @Value2)";

                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    // Set the parameter values
                    command.Parameters.AddWithValue("@Value1", odpowiedz_pierwsza);
                    command.Parameters.AddWithValue("@Value2", odpowiedz_druga);

                    // Execute the command
                    command.ExecuteNonQuery();
                }

                //connection.Insert(temp);    //zapis do pliku

                connection.Close();
                // Perform the data insertion
            }

            
        }

        private void edycja_pytan_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=D:\visual\projekty\quiz\quiz\quizy_database.db;Version=3;"; //dostanie sie do pliku .db
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))    //utworzenie polaczenia
            {
                connection.Open();

                string query = "SELECT id_pytanie from pytania";   //sformuowanie zapytania

                SQLiteCommand command = new SQLiteCommand(query, connection);
                
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string name = reader.GetInt32(0).ToString();
                    comboBox_edycja_pytania.Items.Add(name);
                }
                
                connection.Close();
            }

        }

        private void comboBox_edycja_pytania_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=D:\visual\projekty\quiz\quiz\quizy_database.db;Version=3;"; //dostanie sie do pliku .db
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))    //utworzenie polaczenia
            {
                connection.Open();

                string query = "SELECT tresc, odp_1, odp_2, odp_3, odp_4 from pytania where id_pytanie='" + comboBox_edycja_pytania.SelectedItem+"'";   //sformuowanie zapytania

                SQLiteCommand command = new SQLiteCommand(query, connection);

                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string polecenie = reader.GetString(0);
                    string odp1 = reader.GetString(1);
                    string odp2 = reader.GetString(2);
                    string odp3 = reader.GetString(3);
                    string odp4 = reader.GetString(4);

                    textBox_tresc.Text = polecenie;
                    odpowiedz_pierwsza.Text = odp1;
                    odpowiedz_druga.Text = odp2;
                    odpowiedz_trzecia.Text = odp3;
                    odpowiedz_czwarta.Text = odp4;
                }

                connection.Close();
            }
        }
    }
}
