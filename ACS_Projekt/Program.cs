using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ACS_Projekt
{

    class Program
    {
        static void Main(string[] args)
        {
            char param = '0';
            ArrayList cShapes = new ArrayList();
            ArrayList pShapes = new ArrayList();

            while (param != '4')
            {
                Console.WriteLine("Program liczy obwody i powierzchnie utworzonych figur foremnych.");
                Console.WriteLine("1. - Utwórz koło");
                Console.WriteLine("2. - Utwórz wielokąt");
                Console.WriteLine("3. - Oblicz pola i obwody podanych figur");
                Console.WriteLine("4. - Wyjdź z programu\n");
                param = char.Parse(Console.ReadLine());

                switch (param)
                {
                    case '1':
                        Console.WriteLine("Podaj promień koła");
                        Circle tempC = new Circle();
                        tempC.Side = double.Parse(Console.ReadLine());
                        cShapes.Add(tempC);
                        break;
                    case '2':
                        Console.WriteLine("Podaj liczbę kątów");
                        Polygon tempP = new Polygon(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Podaj długość boku");
                        tempP.Side = double.Parse(Console.ReadLine());
                        pShapes.Add(tempP);
                        break;
                    case '3':
                        foreach(Circle element in cShapes)
                        {
                            Console.WriteLine("Promień: ");
                            Console.WriteLine("{0:f}", element.Side);
                            Console.WriteLine("Obwód: ");
                            Console.WriteLine("{0:f}", element.CalculateCircuit());
                            Console.WriteLine("Pole: ");
                            Console.WriteLine("{0:f}\n", element.CalculateArea());

                        }
                        foreach (Polygon element in pShapes)
                        {
                            Console.WriteLine(element.figure);
                            Console.WriteLine("Długość boku: ");
                            Console.WriteLine("{0:f}", element.Side);
                            Console.WriteLine("Liczba kątów: ");
                            Console.WriteLine("{0:f}", element.Angles);
                            Console.WriteLine("Obwód: ");
                            Console.WriteLine("{0:f}", element.CalculateCircuit());
                            Console.WriteLine("Pole: ");
                            Console.WriteLine("{0:f}\n", element.CalculateArea());
                        }

                        break;
                    case '4':

                        break;
                    default:
                        Console.WriteLine("Podano błędny argument\n");
                        break;
                }
            }

        }

    }
}
