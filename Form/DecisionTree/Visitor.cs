using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.DecisionTree
{
    public interface Visitor
    {
        public void VisitBooleanQuestion(BooleanQuestion  question);
        public void VisitNumericQuestion(NumericQuestion question); 
        public void VisitRangeQuestion(RangeQuestion question);
        public void VisitMultipleChoiceQuestion(MultipleChoiceQuestion question);
        public void VisitTerminalQuestion(TerminalQuestion question);
    }
}
