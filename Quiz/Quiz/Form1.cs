using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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



       
            Button b = new Button();
            b.Text = answers[0];
            b.Location = new Point(30,60);
            questionControls.Add(b);
            //120 пикселей
            Button b1 = new Button();
            b1.Text = answers[1];
            b1.Location = new Point(150,60);
            questionControls.Add(b1);

            Button b2 = new Button();
            b2.Text = answers[1];
            b2.Location = new Point(270, 60);
            questionControls.Add(b2);

            this.Controls.AddRange(questionControls.ToArray());
            this.Update();


        }

        public bool checkAlternativeQuestion(string correctAnswer)
        {
            if(questionControls[1]==correctAnswer)
            {

            } 
        }

        public void clearAlternativeQuestion()
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m.AskQuestion(this);
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Text = Name;
        }
    }
}
