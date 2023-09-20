
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.DecisionTree
{
    public class BooleanQuestion:Question
    {
        public string _question;
        private readonly Question _trueAnswer;
        private readonly Question _falseAnswer;
        private bool? _reply=null;
        public BooleanQuestion(string question,Question trueAnswer, Question falseAnswer)
        {
            _question = question;
            _trueAnswer = trueAnswer;
            _falseAnswer = falseAnswer;
        }
        public string QuestionReturn()
        {
            return _question;
        }
        public void Be(string reply)
        {
            _reply = bool.Parse(reply.ToLower());
        }
        public Question NextQuestion()
        {
            if (_reply == null) return this;
            return (bool)(_reply) ? _trueAnswer.NextQuestion() : _falseAnswer.NextQuestion();
        }

        public void Accept(Visitor visitor)
        {
           visitor.VisitBooleanQuestion(this);
        }

       
    }
}
