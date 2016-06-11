using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACS_Projekt
{
    enum ShapeType : byte
    {
        Triangle,
        Square,
        Polygon
    }

    class Polygon : Shape, IShape
    {
        public ShapeType figure;
        private int numberOfAngles;
        private double lenghtOfSide;


        public Polygon(int angles)
        {
            numberOfAngles = angles;
            if (angles == 3)
            {
                figure = ShapeType.Triangle;
            }
            else if (angles == 4)
            {
                figure = ShapeType.Square;
            }
            else if (angles > 4)
            {
                figure = ShapeType.Polygon;
            }
            else
            {
                throw new System.Exception("Impossible shape");
            }
        }

        public override double Side
        {
            get
            {
                return lenghtOfSide;
            }
            set
            {
                lenghtOfSide = value;
            }
        }

        public int Angles
        {
            get
            {
                return numberOfAngles;
            }
            set
            {
                numberOfAngles = value;
            }
        }


        public double CalculateCircuit()
        {
            return numberOfAngles * lenghtOfSide;
        }
        public double CalculateArea()
        {
            if (figure == ShapeType.Triangle)
                return lenghtOfSide * lenghtOfSide * (1.73) / 4;
            else if (figure == ShapeType.Square)
                return lenghtOfSide * lenghtOfSide;
            else if (figure == ShapeType.Polygon)
            {
                try {
                    var calculatedArea = lenghtOfSide * lenghtOfSide * numberOfAngles
                        / (System.Math.Tan(System.Math.PI / numberOfAngles) * 4);

                    return calculatedArea;
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("Attempted divide by zero.");
                }
                return -1;
            }
            else
                return -1;

        }
    }
}
