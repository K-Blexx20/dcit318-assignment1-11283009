using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        Console.Write("Enter the length of side A: ");
        double sideA = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the length of side B: ");
        double sideB = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the length of side C: ");
        double sideC = Convert.ToDouble(Console.ReadLine());

        if (sideA == sideB && sideB == sideC)
        {
            Console.WriteLine("The triangle is Equilateral.");
        }
        else if (sideA == sideB || sideA == sideC || sideB == sideC)
        {
            Console.WriteLine("The triangle is Isosceles.");
        }
        else
        {
            Console.WriteLine("The triangle is Scalene.");
        }
    }
}
