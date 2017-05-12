using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
     class AlternativQuestion:Question
    {
        string textQuestion = "eeaefaef";
        string correct = "e";
        string noCorrect = "a";

        public override void Ask(IQuestionForm form)
        {
            form.askAlternativeQuestion(textQuestion, new List<string>() { "aaa", "fdfdf","sdfs" });
            State = QuestionState.Asked;
        }

        public override void CheckAnswer(IQuestionForm form)
        {
            State = form.checkAlternativeQuestion("aaa") ? QuestionState.CorrectlyAnswered : QuestionState.IncorrectlyAnswered;
        }

        public override void ClearForm(IQuestionForm form)
        {
            form.clearAlternativeQuestion();
        }
    }
}
