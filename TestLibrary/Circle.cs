using System;

namespace TestLibrary
{
    public class Circle:Figure
    {
        decimal _radius;
        const decimal pi = 3.14m;

        public Circle (decimal R)
        {
            if (R <= 0)
            {
                throw new Exception("Радиус меньше 0");
            }

            _radius = R;
        }

        public override decimal calculateArea()
        {
            return pi * _radius * _radius;
        }
    }
}
