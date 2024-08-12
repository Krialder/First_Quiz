using System.Collections.Generic;

namespace QuizApplication
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string CorrectAnswer { get; set; }
        public List<string> PossibleWrongAnswers { get; set; }

        public Question(string text, string correctAnswer, List<string> possibleWrongAnswers)
        {
            Text = text;
            CorrectAnswer = correctAnswer;
            PossibleWrongAnswers = possibleWrongAnswers;
        }
    }
}
