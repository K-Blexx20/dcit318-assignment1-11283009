using System;

class TicketPriceCalculator
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        int ticketPrice = 10;

        if (age >= 65 || age <= 12)
        {
            ticketPrice = 7;
        }

        Console.WriteLine($"Your ticket price is: GHC{ticketPrice}");
    }
}
