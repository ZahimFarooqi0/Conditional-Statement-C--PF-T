Console.WriteLine("STUDENT NAME : ZAHIM FAROOQI || STUDENT ID : 66434 || SUBMISSION DATE : 28/10/26 ");
//Question 1
//Write a C# program that reads an integer representing a day number (1–7) from the console and prints the corresponding day name (e.g., 1 → Monday, 7 → Sunday).
//Note: If the input is invalid (outside 1–7 or not a number), display the message: "Invalid number".

Console.Write("\t \n \a ENTER THE NUMBER FROM RANGE (1-7) FOR THE CORRESPONDING DAY NAME : ");
if (int.TryParse(Console.ReadLine(), out int days)) //MEINE YAHN int.tryparse is liye use kra hai takey woh exception pr chala jaye na ke error de , 
{
    switch (days) //Meine Switch is liye use kra hai takey program optimized , fast , efficient ho warna mein if else bhi use krskhta tha but woh nested hojata and optimization etc mein thora slow rehjata 
    {
        case 1:
            Console.WriteLine(" \n\t \a TODAY IS MONDAY");
            break;


        case 2:
            Console.WriteLine(" \n\t \a TODAY IS TUESDAY");
            break;

        case 3:
            Console.WriteLine("\n \t \a TODAY IS WEDNESDAY");
            break;

        case 4:
            Console.WriteLine("\n \t \a TODAY IS THURSDAY");
            break;

        case 5:
            Console.WriteLine("\n \t \a TODAY IS FRIDAY");
            break;

        case 6:
            Console.WriteLine("\n \t \a TODAY IS SATURDAY");
            break;
        case 7:
            Console.WriteLine("\n \t \a TODAY IS SUNDAY");
            break;

        default:
            Console.WriteLine("\n \t \a PLEASE ENTER A NUMBER BETWEEN 1-7 : "); //Default is liye use kra hai takey agr koi bhi out of range number user input de toh woh program error ke bajaye exception pr le jaye
            break;
    }
}
else
{
    Console.WriteLine("INVALID NUMBER , PLEASE INPUT A VALID NUMBER");
}
