using ExercicioMetodosAbstratos.Entities.Enums;

namespace ExercicioMetodosAbstratos.Entities
{
    abstract class Shape
    {
        public Color Color {get; set;}
        public abstract double Area();
    }
}