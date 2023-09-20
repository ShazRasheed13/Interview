
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.DecisionTree
{
    public class RangeQuestion : Question
    {
        public readonly Question _defaultAnswer;
        private readonly List<Range> _ranges;
        public string _question;

        private int? _reply;
       
        public RangeQuestion(string question, List<Range> ranges)
        {
            _ranges = ranges;
            _question=question;
        }
        public string QuestionReturn()
        {
            return _question;
        }
        public void Be(string reply)
        {
            _reply = int.Parse(reply);
        }

        public Question NextQuestion()
        {
            if (_reply == null) return this;
            return Range.NextQuestion(_defaultAnswer, _ranges, _reply);
        }

        public void Accept(Visitor visitor)
        {
            visitor.VisitRangeQuestion(this);
        }


        
    }

    public class RangeBuilder
    {
        
        private Question _question;
        private int _min;
        public  readonly List<Range> _ranges= new();

        internal RangeBuilder(Range range, int min)
        {
            _ranges.Add(range);
            _min = min;
            
        }


        public RangeBuilder UpTo(int max)
        {
           
            _ranges.Add(new Range(_question, _min, max));
            return this;
        }

        public RangeBuilder Question(Question question)
        {
            _question=question;
            return this;
        }

        public List<Range> Otherwise(Question question)
        {
            _ranges.Add(new Range(question,_min,Int32.MaxValue));
            return _ranges;
        }
    }
}