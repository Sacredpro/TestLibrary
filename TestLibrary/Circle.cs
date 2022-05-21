using System;

namespace TestLibrary
{
    public class Circle:Figure
    {
        private readonly decimal _radius;       

        public Circle (decimal radius)
        {
            if (radius <= 0)
            {
                throw new Exception("Radius can't be less than zero");
            }

            _radius = radius;
        }

        public override decimal CalculateArea()
        {
            return (decimal)Math.PI * _radius * _radius;
        }
    }
}
