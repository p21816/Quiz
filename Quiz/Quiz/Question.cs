using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    abstract class Question
    {
        public enum QuestionState
        {
            NotAsked,
            Asked,
            CorrectlyAnswered,
            IncorrectlyAnswered
        }
        public QuestionState State { get; protected set; }
        public Question()
        {
            State = QuestionState.NotAsked;
        }
        abstract public void Ask(IQuestionForm form);

        abstract public void CheckAnswer(IQuestionForm form);
        abstract public void ClearForm(IQuestionForm form);
    }
}
