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
        List<Student> users = new List<Student>();
        Question currentQuestion = null;
        int Achicount;
        private Student currentStudent;
        public Model()
        {
            questions.Add(new AlternativQuestion());
            users.Add(new Student("liskin"));
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
         
           foreach (AnswerData answer in answerData)
           {
               if (answer.student == currentStudent)
               {
                     if (answerData.Count == 1)
                   {
                       Achicount++;
                   }
               }
           }
           MessageBox.Show(String.Format("{0} ачивок",Achicount));
        }
    }
}
