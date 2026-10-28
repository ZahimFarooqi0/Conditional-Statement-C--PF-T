//Question 4
//Write a C# program that acts as a simple calculator. It should read:

//Two numbers (as double).
//An operator character (+, -, *, /).
//Perform the corresponding operation and print the result.
Console.WriteLine("STUDENT NAME : ZAHIM FAROOQI || STUDENT ID : 66434 || SUBMISSION DATE : 28/10/26 ");
Console.WriteLine("\n \t \a ENTER FIRST VALUE : ");
double FirstValue = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("\n \t \a ENTER SECOND VALUE : ");
double SecondValue = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("\n \t \a ENTER THE OPERATOR : ");
string Operand = Console.ReadLine()!;

switch (Operand)
{
    case "+":
        Console.WriteLine("\a \t \nYOU HAVE SELECTED ADDITION");
        Console.WriteLine("THE DIVISON OF {0} AND {1} IS : {2}", FirstValue, SecondValue, (FirstValue + SecondValue));
        break;
    case "-":
        Console.WriteLine("YOU HAVE SELECTED SUBSTRACTION");
        Console.WriteLine("THE DIVISON OF {0} AND {1} IS : {2}", FirstValue, SecondValue, (FirstValue - SecondValue));
        break;
    case "*":
        Console.WriteLine("YOU HAVE SELECTED MULTIPLICATION");
        Console.WriteLine("THE DIVISON OF {0} AND {1} IS : {2}", FirstValue, SecondValue, (FirstValue * SecondValue));
        break;
    case "/":
        Console.WriteLine("YOU HAVE SELECTED DIVISION");
        Console.WriteLine("THE DIVISON OF {0} AND {1} IS : {2}", FirstValue, SecondValue, (FirstValue / SecondValue));
        break;


    default:
        Console.WriteLine("PLEASE SELECT THE + , - , * ,/ ");
        break;
}