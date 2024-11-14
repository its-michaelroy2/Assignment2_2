using Assignment2_2.Models;

namespace Assignment2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment 2_2

            //1. Write a base class: 'Shape' and add properties like id, name and color and method like 'calculate area'.
            //2. Create a Class named 'Circle', inherit the base class and add properties like radius. Add an override to calculate area for circle.
            //3. Create a Class called 'Square', inherit base class from shape and add change the calculate area logic. Add property like side of square.
            //4. Take the input from user to seelct circle or square and display the calculated area. No hard coded values!

            string? choice = string.Empty;
            do
            {
                Console.Clear();
                Console.WriteLine("Assignment 2_2\n");
                Console.WriteLine("Please select a number and Press ENTER\n");
                Console.WriteLine("1. Circle");
                Console.WriteLine("2. Square");
                Console.WriteLine("3. Exit");

                choice = Console.ReadLine();

                if (choice == "1")
                {
                    Circle circle = new Circle();
                    circle.ShapeId = "1";
                    circle.ShapeName = "Circle";
                    circle.ShapeColor = "Red";
                    Console.WriteLine("\nPlease enter the radius and press ENTER");
                    circle.Radius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"\nThe area of the circle is {circle.CalculateArea(circle.Radius)} and the color is {circle.ShapeColor} and the name is {circle.ShapeName}\n");
                    Console.WriteLine("Press ENTER key to continue");
                    Console.Read();
                }
                else if (choice == "2")
                {
                    Square square = new Square();
                    square.ShapeId = "2";
                    square.ShapeName = "Square";
                    square.ShapeColor = "Blue";
                    Console.WriteLine("\nPlease enter the side length and press ENTER");
                    square.SideLength = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"\nThe area of the square is {square.CalculateArea(square.SideLength)} and the color is {square.ShapeColor} and the name is {square.ShapeName}\n");
                    Console.WriteLine("Press ENTER key to continue");
                    Console.Read();
                }
            } while (choice != "3");
        }
    }
}
