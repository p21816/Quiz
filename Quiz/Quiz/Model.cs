using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class Model
    {
        List<AnswerData> answerData = new List<AnswerData>();
        List<Question> questions = new List<Question>();
        Question currentQuestion = null;

        public Model()
        {
            questions.Add(new AlternativQuestion());
        }
        public void AskQuestion(IQuestionForm form)
        {
            if (currentQuestion != null)
            {
                currentQuestion.CheckAnswer(form);
                // заполняем answerdata
                answerData.Add(new AnswerData());
                // очистиить форму
                currentQuestion.ClearForm(form);

            }
            currentQuestion = questions[0];
            currentQuestion.Ask(form);
        }

    }
}
