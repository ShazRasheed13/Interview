namespace Exercises.DecisionTree;

public class NumericQuestion:Question
{
    public string _question;
    private readonly Question _answer;
    private int? _reply=null;
    public NumericQuestion(string question, Question answer)
    {
        _question = question;
        _answer = answer;
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
        return _answer.NextQuestion();
    }

    public void Accept(Visitor visitor)
    {
        visitor.VisitNumericQuestion(this);
    }
}