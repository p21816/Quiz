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
        public Student student;
        // time, when the answer was given
        public DateTime time;
        // whether the answer was correct
        public bool isCorrect;
        // type of the question
        public string questionType;
    }
}
