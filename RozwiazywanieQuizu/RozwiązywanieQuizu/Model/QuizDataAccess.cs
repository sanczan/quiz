using System.Collections.Generic;
using System.Data.SQLite;

namespace RozwiazywanieQuizu
{
    public class QuizDataAccess 
    {
        private string _connectionString = "Data Source=C:\\Users\\kamil\\source\\repos\\RozwiązywanieQuizu\\RozwiązywanieQuizu\\quizy_database.db;Version=3;New=False";

        public List<Quiz> GetQuizzes()
        {
            List<Quiz> quizzes = new List<Quiz>();

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                using (var command = new SQLiteCommand("SELECT * FROM quizy", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Quiz quiz = new Quiz
                            {
                                QuizTitle = reader["nazwa"].ToString(),
                                // Set other properties
                            };

                            quizzes.Add(quiz);
                        }
                    }
                }
            }

            return quizzes;
        }
    }
}
