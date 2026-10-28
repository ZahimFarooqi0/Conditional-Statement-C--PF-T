//Question 3Write a C# program that takes a year as input from the user and checks whether it is a leap year.
//Rules:
//-A year is a leap year if it is divisible by 4.
//- However, if the year is divisible by 100, it is not a leap year.
//- Exception: If the year is divisible by 400, then it is a leap year.
Console.WriteLine("STUDENT NAME : ZAHIM FAROOQI || STUDENT ID : 66434 || SUBMISSION DATE : 28/10/26 ");
Console.WriteLine("ENTER THE YEAR YOU WANT TO CHECK WHETHER ITS LEAP YEAR OR NOT ");
if (int.TryParse(Console.ReadLine(), out int years))
{
    bool IsLeapyear = (years % 4 == 0 && years % 100 != 0) || (years % 400 == 0);
    if (IsLeapyear)
    {
        Console.WriteLine("THE YEAR IS LEAP YEAR {0}" , years);
    }
    else
    {
        Console.WriteLine("THE YEAR IS NOT A LEAP YEAR {0}", years);
    }
}
else
{
    Console.WriteLine("PLEASE ENTER A NUMERIC VALUE");
}
