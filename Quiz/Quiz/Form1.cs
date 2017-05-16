using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form,IQuestionForm
    {
        Model m = new Model();

        public Form1()
        {
            InitializeComponent();

        }

        List<Control> questionControls = new List<Control>();


        public void askAlternativeQuestion(string Question, List<string> answers)
        {
            Label l = new Label();
            l.Text = Question;
            l.Location = new Point(30, 30);
            questionControls.Add(l);


            for (int i = 0; i < answers.Count; i++)
            {
                Button b = new Button();
                b.Location = new Point(b.Width * i+120, 60);
                b.Text = answers[i];
                b.Tag = i;
                b.Click += B_Click;     
                this.questionControls.Add(b);
            }



            this.Controls.AddRange(questionControls.ToArray());
            this.Update();


        }
        private string stringAnswer;
        private void B_Click(object sender, EventArgs e)
        {
            stringAnswer = ((Button)sender).Text;
        }

        public bool checkAlternativeQuestion(string correctAnswer)
        {
            var isCorrect = correctAnswer == stringAnswer;

            if (isCorrect==true)
                
            {
                MessageBox.Show("Correct!");
                
            }
            AnswerData user = new AnswerData (null,DateTime.Now, isCorrect,"alternative");
               
            return isCorrect;

        }

        public void clearAlternativeQuestion()
        {
            questionControls.ForEach(new Action<Control>(Controls.Remove));
            questionControls.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m.AskQuestion(this);
        }

        
    }
}