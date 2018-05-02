using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace QuizApplication
{
    
    class DataAccessLayer
    {
        SqlConnection connection;
        public DataAccessLayer()
        {
            connection = new SqlConnection(ApplicationSettings.connectionString);
        }

        public List<QuizQuestions> GetAllQuestions()
        {
            connection.Open();
            string query = "Select * from tblQuiz";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<QuizQuestions> AllQuestions = new List<QuizQuestions>();
            while (reader.Read())
            {
                int questionId = Convert.ToInt32(reader["QuestionId"]);
                int questionNumber = Convert.ToInt32(reader["QuestionNumber"]);
                string question = "" + reader["Question"];
                string option1 = "" + reader["option1"];
                string option2 = "" + reader["option2"];
                string option3 = "" + reader["option3"];
                string option4 = "" + reader["option4"];
                int optionsToDisplay = Convert.ToInt32(reader["optionsToDisplay"]);
                string quizType = "" + reader["quizType"];
                int correctAnswer = Convert.ToInt32(reader["correctAnswer"]);

                QuizQuestions aQues = new QuizQuestions(questionId, questionNumber, question, option1, option2, option3, option4, optionsToDisplay, quizType, correctAnswer);
                AllQuestions.Add(aQues);
            }
            connection.Close();
            return AllQuestions;
        }

        public List<QuizQuestions> GetAllQuestionsByType (string Type)
        {
            connection.Open();
            string queryType = "Select * from tblQuiz where questionType = '" + Type +"'";
            SqlCommand command = new SqlCommand(queryType, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<QuizQuestions> AllQuestionsByType = new List<QuizQuestions>();
            while (reader.Read())
            {
                int questionId = Convert.ToInt32(reader["QuestionId"]);
                int questionNumber = Convert.ToInt32(reader["QuestionNumber"]);
                string question = "" + reader["Question"];
                string option1 = "" + reader["option1"];
                string option2 = "" + reader["option2"];
                string option3 = "" + reader["option3"];
                string option4 = "" + reader["option4"];
                int optionsToDisplay = Convert.ToInt32(reader["optionsToDisplay"]);
                string quizType = "" + reader["quizType"];
                int correctAnswer = Convert.ToInt32(reader["correctAnswer"]);

                QuizQuestions aQues = new QuizQuestions(questionId, questionNumber, question, option1, option2, option3, option4, optionsToDisplay, quizType, correctAnswer);
                AllQuestionsByType.Add(aQues);
            }
            connection.Close();
            return AllQuestionsByType;
        }
    }
}
