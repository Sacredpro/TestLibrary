using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace TestLibrary
{
    public class Triangle:Figure
    {
        double sideA;
        double sideB;
        double sideC;

        public Triangle(double A, double B, double C)
        {
            if ((A+B<=C)^(A+C<=B)^(B+C<=A))
            {
                throw new Exception("Две стороны треугольника в сумме всегда больше третьей");
            }
            if ((A > 0) & (B > 0) & (C > 0))
            {
                sideA = A;
                sideB = B;
                sideC = C;
            }
            else throw new Exception("Все стороны треугольника должны быть > 0 ");
        }

        public override double calculateArea()
        {
            double p = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }

        public bool checkIfTriangleIsRight()
        {
            if ((sideA > sideB) & (sideA > sideC) & (sideA * sideA == sideB * sideB + sideC * sideC))
            {
                return true;
            }
            else if ((sideB > sideA) & (sideB > sideC) & (sideB * sideB == sideA * sideA + sideC * sideC))
            {
                return true;
            }
            else if ((sideC > sideA) & (sideC > sideB) & (sideC * sideC == sideB * sideB + sideA * sideA))
            {
                return true;
            }
            else return false;
        }
    }
}
