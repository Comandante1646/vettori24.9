using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vettori24._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vettore v1 = new Vettore();
            v1.X = 2;
            v1.Y = 2;
            v1.Calcolalunghezza();
            Vettore v2 = new Vettore();
            v2.X = 3;
            v2.Y = 3;
            v2.Calcolalunghezza();
            Vettore v3 = new Vettore();
            Console.WriteLine("ascisse vettore?");
            v3.X = int.Parse(Console.ReadLine());
            Console.WriteLine("Ordinate vettore?");
            v3.Y = int.Parse(Console.ReadLine()); 
            v3.Calcolalunghezza();
            Console.WriteLine("primo vettore: ") ;
            Console.WriteLine( (v1.X).ToString());
            Console.WriteLine( (v1.Y).ToString());
            Console.WriteLine("secondo vettore: ");
            Console.WriteLine((v2.X).ToString());
            Console.WriteLine((v2.Y).ToString());
            Console.WriteLine("somma vettori: ");
            Console.WriteLine((v1.Lunghezza + v2.Lunghezza).ToString());
            Console.ReadLine();
        }
    }
}
