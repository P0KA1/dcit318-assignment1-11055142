using System;

class Calculator
{
    static void Main()
    {
        int a, b, c;

        while (true)
        {
            Console.Write("Enter side A: ");
            bool validA = int.TryParse(Console.ReadLine(), out a) && a > 0;

            Console.Write("Enter side B: ");
            bool validB = int.TryParse(Console.ReadLine(), out b) && b > 0;

            Console.Write("Enter side C: ");
            bool validC = int.TryParse(Console.ReadLine(), out c) && c > 0;

            if (validA && validB && validC)
            {
                if (a + b > c && a + c > b && b + c > a) // Triangle inequality theorem
                    break;
                else
                    Console.WriteLine("These sides do not form a valid triangle. Try again.");
            }
            else
            {
                Console.WriteLine("Invalid input. All sides must be positive numbers. Try again.");
            }
        }

        if (a == b && b == c)
            Console.WriteLine("It is an Equilateral triangle");
        else if (a == b || b == c || a == c)
            Console.WriteLine("It is an Isosceles triangle");
        else
            Console.WriteLine("It is a  Scalene triangle");
    }
}
