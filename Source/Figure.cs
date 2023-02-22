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

        //9879789428u
        public abstract double GetArea();
    }
}
