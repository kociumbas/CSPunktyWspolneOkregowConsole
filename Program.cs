using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Problem6Console
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = 0;
            int warunek = 0;
            float y1, y2, x1, x2, r1, r2, sumapromieni, roznicapromieni = 0;
            Console.WriteLine("\n\tProgram sprawdza, czy dwa okręgi mają punkty wspólne");
            Console.WriteLine("\n\n\tPodaj współrzędne x środka pierwszego okręgu");
            Console.Write("\n\tx1= ");
            x1 = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("\n\n\tPodaj współrzędne y środka pierwszego okręgu");
            Console.Write("\n\ty1= ");
            y1 = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("\n\n\tPodaj promień r środka pierwszego okręgu");
            Console.Write("\n\tr1= ");
            r1 = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("\n\n\tPodaj współrzędne x środka drugiego okręgu");
            Console.Write("\n\tx2= ");
            x2 = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("\n\n\tPodaj współrzędne y środka drugiego okręgu");
            Console.Write("\n\ty2= ");
            y2 = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("\n\n\tPodaj promień r środka drugiego okręgu");
            Console.Write("\n\tr2= ");
            r2 = Convert.ToInt64(Console.ReadLine());

            d = Math.Sqrt((x1 - x2) * (x1 - x2) * (y1 - y2) * (y1 - y2));
            sumapromieni = r1 + r2;
            roznicapromieni = Math.Abs(r1 - r2);

            if (d > sumapromieni || d < roznicapromieni) warunek = 1;
            if (d == sumapromieni || d == roznicapromieni) warunek = 2;
            if (d < sumapromieni || d > roznicapromieni) warunek = 3;

            switch (warunek)
            {
                case 1: Console.WriteLine("\n\n\tOkręgi nie mają punktów wspólnych");
                    break;
                case 2:
                    Console.WriteLine("\n\n\tOkręgi mają jeden punkt wspólny");
                    break;
                case 3:
                    Console.WriteLine("\n\n\tOkręgi mają dwa punkty wspólne");
                    break;
            }
            Console.ReadLine();
        }
    }
}
