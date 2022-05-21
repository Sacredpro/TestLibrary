using System;

namespace TestLibrary
{
    public class Triangle:Figure
    {
        private readonly decimal _sideA;
        private readonly decimal _sideB;
        private readonly decimal _sideC;

        public Triangle(decimal sideA, decimal sideB, decimal sideC)
        {
            if ((sideA+sideB<=sideC)^(sideA+sideC<=sideB)^(sideB+sideC<=sideA))
            {
                throw new Exception("Две стороны треугольника в сумме всегда больше третьей");
            }
            if ((sideA > 0) & (sideB > 0) & (sideC > 0))
            {
                _sideA = sideA;
                _sideB = sideB;
                _sideC = sideC;
            }
            else throw new Exception("Все стороны треугольника должны быть > 0 ");
        }

        public override decimal CalculateArea()
        {
            decimal p = (_sideA + _sideB + _sideC) / 2;
            decimal x = (p * (p - _sideA) * (p - _sideB) * (p - _sideC));
            return (decimal)Math.Sqrt((double)x);
        }

        public bool СheckIsRight()
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
