using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public class Model
    {
        List<AnswerData> answerData = new List<AnswerData>();
        List<Question> questions = new List<Question>();
        public List<Student> users = new List<Student>();
        Question currentQuestion = null;
        int Achicount;
        private Student currentStudent;
        public Model()
        {
            questions.Add(new AlternativQuestion());
            users.Add(new Student("liskin"));
            users.Add(new Student("wpiskin"));
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
        private int TempAchiInARow;
        public void CheckAchi()
        {
         
           foreach (AnswerData answer in answerData)
           {
               if (answer.student == currentStudent)
               {
                     if (answerData.Count == 1)
                   {
                       Achicount++;
                        TempAchiInARow++;
                   }
                     if (TempAchiInARow==3)
                    {
                        Achicount++;
                    }
                     if(TempAchiInARow==5)
                    {
                        Achicount++;
                    }
                     if(answerData.Count==0)
                    {
                        Achicount++;
                    }
                     if 
               }
           }
           MessageBox.Show(String.Format("{0} ачивок",Achicount));
        }
    }
}
