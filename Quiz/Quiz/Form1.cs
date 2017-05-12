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
        static public Model m = new Model();


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

            return correctAnswer == stringAnswer;
            
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Text = Name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            m.CheckAchi();
        }
    }
}
