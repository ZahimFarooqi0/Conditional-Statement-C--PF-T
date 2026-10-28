Console.WriteLine("STUDENT NAME : ZAHIM FAROOQI || STUDENT ID : 66434 || SUBMISSION DATE : 28/10/26 ");
//Question 2
//A shop gives a discount based on the purchase amount:

//If amount ≥ 5000 → 20% discount
//If amount ≥ 2000 and < 5000 → 10% discount
//Otherwise → No discount
//Write a C# program that reads the purchase amount and prints:
//The discount percentage
//The discount amount
//The final payable amount

Double discount = 0;
Console.Write("ENTER THE PURCHASE AMOUNT : ");
if (Double.TryParse(Console.ReadLine(), out Double amount))
{
    if (amount >= 5000)
    {
        discount = 20;

    }
    else if (amount >= 2000 && amount < 5000)
    {
        discount = 10;
    }
    else
    {
        Console.WriteLine("\n \t DISCOUNT ISNT APPLICABLE FOR YOUR PURCHASE : ");

    }
    double DiscountPrice = (amount * (discount / 100));
    Console.WriteLine("\n \t THE DISCOUNT PERCENTAGE APPLIED ON YOUR PURCHASE IS {0}%", discount);
    Console.WriteLine("\n \tTHE DISCOUNT AMOUNT APPLIED ON YOUR PURCHASE  IS {0}%", DiscountPrice);
    Console.WriteLine("\n \tTHE FINAL PAYABLE AMOUNT IS {0} ", amount - DiscountPrice);
}
else
{
    Console.WriteLine("PLEASE ENTER A NUMERIC VALUE");
}
Console.ReadKey();