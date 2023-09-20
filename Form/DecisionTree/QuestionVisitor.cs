using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.DecisionTree
{
    public class QuestionVisitor:Visitor
    {
        public void PreorderTraversal(Question question)
        {
            question.Accept(this);
            if(question.NextQuestion()!=question)
                PreorderTraversal(question.NextQuestion());

        }
        public void VisitBooleanQuestion(BooleanQuestion question)
        {
            throw new NotImplementedException();
        }

        public void VisitNumericQuestion(NumericQuestion question)
        {
            throw new NotImplementedException();
        }

        public void VisitRangeQuestion(RangeQuestion question)
        {
            throw new NotImplementedException();
        }

        public void VisitMultipleChoiceQuestion(MultipleChoiceQuestion question)
        {
            throw new NotImplementedException();
        }

        public void VisitTerminalQuestion(TerminalQuestion question)
        {
            throw new NotImplementedException();
        }
    }
}
