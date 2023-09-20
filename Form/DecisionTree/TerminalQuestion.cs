namespace Exercises.DecisionTree;


public class TerminalQuestion: Question
{
    public static TerminalQuestion Success=new TerminalQuestion("Welcome to Our Company have a good Day..!!");
    public static TerminalQuestion Failure = new TerminalQuestion("Sorry you are not Eligible!");
    public static TerminalQuestion NotHire = new TerminalQuestion("Wrong Answer, We cant hire you!");
    public static TerminalQuestion NoSkill = new TerminalQuestion("Sorry we cant hire you, We need someone who has the above mentioned skills.");
    public static TerminalQuestion ThankYou = new TerminalQuestion("We appreciate your Efforts..All the best for your future");
    public static TerminalQuestion Mistake = new TerminalQuestion("Sorry you made a mistake fill the form again");

    public string text;

    public TerminalQuestion(string Success)
    {
        text = Success;
    }
    public void Be(string reply) => throw new InvalidOperationException("No More Questions, You are done");

    public Question NextQuestion()
    {
        Console.WriteLine(text);
        return this;
    }
    public void Accept(Visitor visitor)
    {
        throw new NotImplementedException();
    }

    public string QuestionReturn() => throw new InvalidOperationException("No More Questions, You are done");
    
}