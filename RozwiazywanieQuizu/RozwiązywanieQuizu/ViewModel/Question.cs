using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RozwiazywanieQuizu.ViewModel
{
    internal class Question
    {
        public string QuestionText { get; set; }
        public List<string> AnswerOptions { get; set; }
        public int CorrectAnswer { get; set; }
    }

}
