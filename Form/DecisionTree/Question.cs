using System.Data;

namespace Exercises.DecisionTree;

public interface Question
{
    void Be(string reply);
    Question NextQuestion();
    void Accept(Visitor visitor);
    string QuestionReturn();





}