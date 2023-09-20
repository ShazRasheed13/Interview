using Exercises.DecisionTree;
using static Exercises.DecisionTree.TerminalQuestion;

string QuestionHeading = "Answer the following question carefully this is your only chance to get the Job.";


BooleanQuestion K = "Right Answer..!! Are you willing to Join Us?\n(true or false)".Boolean(Success, ThankYou);

BooleanQuestion R = $"{QuestionHeading}\nC# is primarily used for web development.\n(true or false)".Boolean(NotHire, K);
BooleanQuestion Q = $"{QuestionHeading}\nC# is an open-source programming language.\n(true or false)".Boolean(K, NotHire);
BooleanQuestion P = $"{QuestionHeading}\nC# is a statically typed language.\n(true or false)".Boolean(K, NotHire);

BooleanQuestion O = $"{QuestionHeading}\nPython has a built-in garbage collector.\n(true or false)".Boolean(K, NotHire);
BooleanQuestion N = $"{QuestionHeading}\nPython is a case-sensitive language.\n(true or false)".Boolean(K, NotHire);
BooleanQuestion M = $"{QuestionHeading}\nPython uses semicolons (;) to terminate statements.?\n(true or false)".Boolean(NotHire, K);

BooleanQuestion D = $"{QuestionHeading}\nJava supports multiple inheritance through classes.\n(true or false)".Boolean(NotHire, K);
BooleanQuestion C = $"{QuestionHeading}\nJava is a purely object-oriented programming language.\n(true or false)".Boolean(NotHire, K);
BooleanQuestion B = $"{QuestionHeading}\nJava programs can only be run on Windows operating systems?\n(true or false)".Boolean(NotHire, K);

RangeQuestion J = "How do you rate yourself in C# programming? (0-10)".Range(Mistake.UpTo(0).Question(P).UpTo(3).Question(Q).UpTo(7).Question(R).UpTo(10).Otherwise(Mistake));
RangeQuestion I = "How do you rate yourself in Python programming (0-10)?".Range(Mistake.UpTo(0).Question(M).UpTo(3).Question(N).UpTo(7).Question(O).UpTo(10).Otherwise(Mistake));
RangeQuestion H = "How do you rate yourself in Java programming (0-10)?".Range(Mistake.UpTo(0).Question(B).UpTo(3).Question(C).UpTo(7).Question(D).UpTo(10).Otherwise(Mistake));


MultipleChoiceQuestion G = "Which Programming Language do you prefer?\n->Java\n->Python\n->C#".MultiQuestion(NoSkill, "Java".Question(H), "Python".Question(I), "C#".Question(J));

NumericQuestion F = "How many years of Experience do you have in Coding?".Numeric(G);
BooleanQuestion E = "Are you a Graduate in CSE,EC or IS?\n(true or false)".Boolean(F, Failure);


Question question = E;

while (question is not TerminalQuestion)
{
    Console.WriteLine(question.QuestionReturn());
    try
    {
        question.Be(Console.ReadLine());
        question = E.NextQuestion();
    }
    catch
    {
        Console.WriteLine("Give Valid response");
    }
}
Console.WriteLine("Thank you for attempting the test");


