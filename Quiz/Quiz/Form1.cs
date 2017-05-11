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

        public void askAlternativeQuestion(string Question, List<string> answers)
        {
            throw new NotImplementedException();
        }

        public bool checkAlternativeQuestion(string correctAnswer)
        {
            throw new NotImplementedException();
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

        private void button2_Click(object sender, EventArgs e)
        {
            m.CheckAchi();
        }
    }
}
