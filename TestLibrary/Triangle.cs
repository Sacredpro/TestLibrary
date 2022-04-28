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
        decimal _sideA;
        decimal _sideB;
        decimal _sideC;

        public Triangle(decimal A, decimal B, decimal C)
        {
            if ((A+B<=C)^(A+C<=B)^(B+C<=A))
            {
                throw new Exception("Две стороны треугольника в сумме всегда больше третьей");
            }
            if ((A > 0) & (B > 0) & (C > 0))
            {
                _sideA = A;
                _sideB = B;
                _sideC = C;
            }
            else throw new Exception("Все стороны треугольника должны быть > 0 ");
        }

        public override decimal calculateArea()
        {
            decimal p = (_sideA + _sideB + _sideC) / 2;
            decimal x = (p * (p - _sideA) * (p - _sideB) * (p - _sideC));
            return (decimal)Math.Sqrt((double)x);
        }

        public bool checkIfTriangleIsRight()
        {
            if ((_sideA > _sideB) & (_sideA > _sideC) & (_sideA * _sideA == _sideB * _sideB + _sideC * _sideC))
            {
                return true;
            }
            else if ((_sideB > _sideA) & (_sideB > _sideC) & (_sideB * _sideB == _sideA * _sideA + _sideC * _sideC))
            {
                return true;
            }
            else if ((_sideC > _sideA) & (_sideC > _sideB) & (_sideC * _sideC == _sideB * _sideB + _sideA * _sideA))
            {
                return true;
            }
            else return false;
        }
    }
}
