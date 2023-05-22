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
using System.Security.Cryptography.X509Certificates;

namespace quiz
{
    public partial class edycja_pytan : Form
    {
        public edycja_pytan()
        {
            InitializeComponent();
        }

        public int id_quizu_na_podstawie_nazwy_quizu;   //distanie sie na upo do id quizu

        private void edycja_pytan_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=D:\visual\projekty\quiz\quiz\quizy_database.db;Version=3;"; //dostanie sie do pliku .db


            //---------------id quizu---------------

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))    //utworzenie polaczenia
            {
                connection.Open();

                string sql = "SELECT id_quiz FROM quizy WHERE nazwa='" + wybor_quizu.nazwa_quizu + "'"; //zapytanie

                SQLiteCommand command = new SQLiteCommand(sql, connection);

                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    id_quizu_na_podstawie_nazwy_quizu = reader.GetInt32(0);
                }

                connection.Close();
            }


            //-------------------wypunktowanie listy w comboboxie---------------------

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))    //utworzenie polaczenia
            {
                connection.Open();

                string nazwa = wybor_quizu.nazwa_quizu; //nazwa quizu z poprzedniego forma

                string query = "SELECT pytania.tresc from pytania INNER JOIN quizy ON pytania.id_quiz = quizy.id_quiz WHERE quizy.nazwa='" + nazwa + "'";   //sformuowanie zapytania

                SQLiteCommand command = new SQLiteCommand(query, connection);

                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())   //dodanie elementow do comboboxa
                {
                    string name = reader.GetString(0);
                    comboBox_edycja_pytania.Items.Add(name);
                }

                connection.Close();
            }

        }

        public int id;  //id danego pytania (na przyszlosc do edycji)

        //---------------------------------klikniecie elementu w vomboboxie pokazuje elementy w textboxach--------------------------------------

        private void comboBox_edycja_pytania_SelectionChangeCommitted(object sender, EventArgs e)
        {

            string connectionString = @"Data Source=D:\visual\projekty\quiz\quiz\quizy_database.db;Version=3;"; //dostanie sie do pliku .db
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))    //utworzenie polaczenia
            {
                connection.Open();

                string query = "SELECT id_pytanie, odp_1, odp_2, odp_3, odp_4 from pytania where tresc='" + comboBox_edycja_pytania.SelectedItem + "'";   //sformuowanie zapytania

                SQLiteCommand command = new SQLiteCommand(query, connection);

                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    id = reader.GetInt32(0);    //przypisanie danych z zapytania do zmiennych
                    string odp1 = reader.GetString(1);
                    string odp2 = reader.GetString(2);
                    string odp3 = reader.GetString(3);
                    string odp4 = reader.GetString(4);


                    odpowiedz_pierwsza.Text = odp1; //wypisanie danych w textboxach
                    odpowiedz_druga.Text = odp2;
                    odpowiedz_trzecia.Text = odp3;
                    odpowiedz_czwarta.Text = odp4;
                }

                connection.Close();
            }
        }

        //--------------------------------dadanie rekordu do bazy-------------------------------

        private void button_dodaj_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=D:\visual\projekty\quiz\quiz\quizy_database.db;Version=3;"; //dostanie sie do pliku .db

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))    //utworzenie polaczenia
            {
                connection.Open();

                string pomoc = "do zrobienia";  //utworzenie zmiennych b pozniej je wykorzystac w zapytaniu
                string tresc = comboBox_edycja_pytania.Text;
                string odp_1 = odpowiedz_pierwsza.Text;
                string odp_2 = odpowiedz_druga.Text;
                string odp_3 = odpowiedz_trzecia.Text;
                string odp_4 = odpowiedz_czwarta.Text;
                string odp_poprawna = pomoc;

                string sql = "INSERT INTO pytania (id_quiz, tresc, odp_1, odp_2, odp_3, odp_4, poprawna_odp) VALUES ('" + id_quizu_na_podstawie_nazwy_quizu + "','" + tresc + "','" + odp_1 + "','" + odp_2 + "','" + odp_3 + "','" + odp_4 + "','" + odp_poprawna + "')";  //zapytanie

                SQLiteCommand command = new SQLiteCommand(sql, connection);

                // Execute the command
                command.ExecuteNonQuery();  //wykonanie zapytania

                connection.Close();
            }

            //----------------------ponowne zaladowanie pytan w comboboxie--------------------------

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))    //utworzenie polaczenia
            {
                connection.Open();

                string nazwa = wybor_quizu.nazwa_quizu;

                string query = "SELECT pytania.tresc from pytania INNER JOIN quizy ON pytania.id_quiz = quizy.id_quiz WHERE quizy.nazwa='" + nazwa + "'";   //sformuowanie zapytania

                SQLiteCommand command = new SQLiteCommand(query, connection);

                SQLiteDataReader reader = command.ExecuteReader();

                comboBox_edycja_pytania.Items.Clear();

                while (reader.Read())
                {
                    string name = reader.GetString(0);
                    comboBox_edycja_pytania.Items.Add(name);
                }

                connection.Close();
            }

        }

        private void button_modyfikuj_Click(object sender, EventArgs e)
        {

        }

        private void button_usun_Click(object sender, EventArgs e)
        {

        }
    }
}
