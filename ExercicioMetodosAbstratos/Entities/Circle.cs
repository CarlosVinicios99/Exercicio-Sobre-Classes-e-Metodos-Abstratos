using System;
using ExercicioMetodosAbstratos.Entities.Enums;

namespace ExercicioMetodosAbstratos.Entities
{
    class Circle : Shape
    {
        public double Radius {get; set;}

        public Circle()
        {

        }

        public Circle(double radius, Color color)
        {   
            Radius = radius;
            Color = color;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}