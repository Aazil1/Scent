using System;

public class TriangleArea
{
    public static void Main(string[] args)
    {
        // Get the sides of the triangle from the user
        Console.WriteLine("Enter the first side of the triangle:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second side of the triangle:");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the third side of the triangle:");
        double c = Convert.ToDouble(Console.ReadLine());

        // Calculate the semi-perimeter of the triangle
        double s = (a + b + c) / 2;

        // Calculate the area of the triangle using Heron's formula
        double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

        // Display the area of the triangle to the user
        Console.WriteLine("The area of the triangle is: {0}", area);
    }
}6