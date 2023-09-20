namespace Exercises.DecisionTree;

public class MultipleChoiceQuestion : Question
{
    public string _question;
    private readonly Question _defaultAnswer;
    private readonly List<Option> _options;
    private string? _reply;
    public MultipleChoiceQuestion(string question, Question defaultAnswer, List<Option> options)
    {
        _question = question;
        _defaultAnswer = defaultAnswer;
        _options = options;
    }
    public string QuestionReturn()
    {
        return _question;
    }
    public void Be(string reply)
    {
        _reply = reply.ToLower();
    }
    public Question NextQuestion()
    {
       
        if (_reply == null) return this;
        return Option.NextQuestion(_options, _reply, _defaultAnswer);
    }

    public void Accept(Visitor visitor)
    {
        visitor.VisitMultipleChoiceQuestion(this);
    }
}