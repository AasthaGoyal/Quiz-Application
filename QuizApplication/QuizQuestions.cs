using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApplication
{
    class QuizQuestions
    {
        public int questionId { get; set; }
        public int questionNumber { get; set;  }
        public string question { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string option3 { get; set; }
        public string option4 { get; set; }
        public int optionsToDisplay { get; set;  }
        public string quizType { get; set; }
        public int correctAnswer { get; set;  }

        public QuizQuestions(int questionId, int questionNumber, string question, string option1, string option2, string option3, string option4, int optionsToDisplay, string quizType, int correctAnswer)
        {
            this.questionId = questionId;
            this.questionNumber = questionNumber;
            this.question = question;
            this.option1 = option1;
            this.option2 = option2;
            this.option3 = option3;
            this.option4 = option4;
            this.optionsToDisplay = optionsToDisplay;
            this.quizType = quizType;
            this.correctAnswer = correctAnswer;
        }
    }
}
