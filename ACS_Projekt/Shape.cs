using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACS_Projekt
{
    public abstract class Shape
    {
        protected double circuit;
        protected double area;
        public abstract double Side
        {
            get;
            set;
        }
    }
}
