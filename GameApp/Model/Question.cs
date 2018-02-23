using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameQuiz.Model
{
    class Question
    {
        public int questID { get; set; }
        public string questTxt { get; set; }
        public string answer { get; set; }
        public int quizID { get; set; }
    }
}
