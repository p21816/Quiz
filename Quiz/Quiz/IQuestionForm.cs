using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public interface IQuestionForm
    {
        void askAlternativeQuestion(string Question, List<string> answers);
        bool checkAlternativeQuestion(string correctAnswer);
        void clearAlternativeQuestion();
    }
}
