using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public abstract class Figure
    {
        private string _name;
        
        public Figure(string name)
        {
            _name = name;
        }

        public abstract double GetArea();
    }
}
