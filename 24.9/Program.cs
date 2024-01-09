using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static _24._9.Program;

namespace _24._9
{
    internal class Program
    {
        public class Vector
        {
            public Vector(double x, double y)
            {
                this.x = x;
                this.y = y;
            }

            public double x { get; set; }
            public double y { get; set; }


            public Vector Somma(Vector vettore)
            {
                return new Vector(this.x + vettore.x, this.y + vettore.y);
            }
        
            public static Vector Parse(string s)
            {
                string[] coordinate = s.Split(';');

                if (coordinate.Length == 2 && double.TryParse(coordinate[0], out double x) && double.TryParse(coordinate[1], out double y))
                {

                    return new Vector(x, y);
                }
                else
                {
                    return new Vector(double.NaN, double.NaN);
                }
            }
            public void Stampa()
            {
                Console.WriteLine("{0};{1}", x,y);
            }
        }

        static void Main(string[] args)
        {
            Vector v1 = new Vector(2, 2);
            Vector v2 = new Vector(3, 3);
            Vector v3 = Vector.Parse("4;4");
            Vector v4 = v1.Somma(v2);
            v1.Stampa();
            v2.Stampa();
            v3.Stampa();
            v4.Stampa();
            Console.ReadLine();
        }
    }
}
