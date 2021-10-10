using System;
using System.Globalization;
using System.Collections.Generic;

using ExercicioMetodosAbstratos.Entities;
using ExercicioMetodosAbstratos.Entities.Enums;

namespace ExercicioMetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            Console.Write("Enter the number of shapes: ");
            int numberOfShapes = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numberOfShapes; i++)
            {
                Console.WriteLine($"\nShape #{i} data: ");

                Console.Write("Rectangle or Circle (r/c): ");
                char figure = char.Parse(Console.ReadLine());

                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if(figure == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapes.Add(new Rectangle(width, height, color));
                }
                
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Circle(radius, color));
                }
            }
            Console.WriteLine("\nSHAPE AREAS: ");
            
            foreach(Shape shape in shapes){
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
