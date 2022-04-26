using System;

namespace TestLibrary
{
    public class Circle:Figure
    {
        double r;
        const double p = 3.14;
        public Circle (double R)
        {
            if (R <= 0)
            {
                throw new Exception("Радиус меньше 0");
            }

            r = R;
        }

        public override double calculateArea()
        {
            return p * r * r;
        }
    }
}
