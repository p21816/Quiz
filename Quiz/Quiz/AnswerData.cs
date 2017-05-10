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
    }
}
