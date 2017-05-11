using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    class Model
    {
        List<AnswerData> answerData = new List<AnswerData>();
        List<Question> questions = new List<Question>();
       
        Question currentQuestion = null;
        int Achicount;
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
                // очистиить форму
                currentQuestion.ClearForm(form);

            }
            currentQuestion = questions[0];
            currentQuestion.Ask(form);
        }
        public void CheckAchi()
        {
           if(answerData.Count==1)
           {
               Achicount++;
           }
           MessageBox.Show(String.Format("{0} ачивок",Achicount));
        }
    }
}
