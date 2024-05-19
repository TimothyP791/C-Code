// If/Else Conditionals in C#

//Inline or Ternary operator
//true - return first number on other side of the question
var inlineStatement  = 3 > 2 ? 10 : 5;

var inlineStatement2 = 4 > 2 ? 5 : 6;
var inlineStatementFalse = 2 == 1 ? 6 : 7;

Console.WriteLine(inlineStatement); 
/*using If_Else;

State state = State.Inactive;

switch (state)
{
    case State.Active:
        Console.WriteLine("Active");
        break;
    case State.Inactive:
        Console.WriteLine("Inactive");
        break;
    default:
        throw new Exception(String.Format("Unknown State: {0}", state));
}*/