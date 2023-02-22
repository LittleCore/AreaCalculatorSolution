using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class Triangle : Figure
    {
        private double _sideAB;
        private double _sideBC;
        private double _sideAC;

        public double SideAB { get => _sideAB; set => _sideAB = value > 0 ? value : -value; }
        public double SideBC { get => _sideBC; set => _sideBC = value > 0 ? value : -value; }
        public double SideAC { get => _sideAC; set => _sideAC = value > 0 ? value : -value; }

        public Triangle(double sideAB, double sideBC, double sideAC) : base("Triangle")
        {
            if (sideAB + sideBC > sideAC && sideAC + sideBC > sideAB && sideAB + sideAC > sideBC)
            {
                SideAB = sideAB;
                SideBC = sideBC;
                SideAC = sideAC;
            }
            else
            {
                Console.WriteLine("Your figure is not a Triangle, enter correct values!");
                throw new ArgumentException("Not a Triangle.");
            }
        }

        public override double GetArea()
        {
            double halfPerimetr = (SideAB + SideAC + SideBC) / 2;
            return Math.Sqrt(halfPerimetr * (halfPerimetr - SideAB) * (halfPerimetr - SideAC) * (halfPerimetr - SideBC));
        }

        public bool CheckRightTriangle()
        {
            bool result = false;

            double[] sides = { SideAB, SideAC, SideBC };

            int longestSideIndex = Array.IndexOf(sides, sides.Max());

            double hypotenusePow2 = 0;
            double sumCathetusPow2 = 0;

            for (int i = 0; i < sides.Length; i++)
            {
                if (i != longestSideIndex)
                    sumCathetusPow2 += Math.Pow(sides[i], 2);
                else
                    hypotenusePow2 = Math.Pow(sides[i], 2);
            }

            //****
            if (hypotenusePow2 == sumCathetusPow2)
            {
                result = true;
            }

            return result;
        }
    }
}
