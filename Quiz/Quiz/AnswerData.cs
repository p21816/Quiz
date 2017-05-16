using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    struct AnswerData
    {
        // student, who had given the answer
        Student student;
        // time, when the answer was given
        DateTime time;
        // whether the answer was correct
        bool isCorrect;
        // type of the question
        string questionType;

        private object p;
        private DateTime now;
        private string v;

        public AnswerData(object p, DateTime now, bool isCorrect, string v) : this()
        {
            this.p = p;
            this.now = now;
            this.isCorrect = isCorrect;
            this.v = v;
        }
    }
}
