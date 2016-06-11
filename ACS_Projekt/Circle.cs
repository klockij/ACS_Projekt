using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACS_Projekt
{
    public class Circle : Shape, IShape
    {
        private double radius;

        public override double Side
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }

        public double CalculateCircuit()
        {
            return 2 * 3.14 * radius;
        }
        public double CalculateArea()
        {
            return 3.14 * radius * radius;
        }

    }
}
