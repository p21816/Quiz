﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    interface IQuestionForm
    {
        void askAlternativeQuestion();
        void checkAlternativeQuestion();
        void clearAlternativeQuestion();
    }
}
