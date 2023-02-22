using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class Circle : Figure
    {
        private double _radius;

        public double Radius { get => _radius; set => _radius = value > 0 ? value : -value; }

        public Circle(double radius) : base("Circle")
        {
            _radius = radius;
        }

        //dhfisdufhiadshfaj
        public override double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
