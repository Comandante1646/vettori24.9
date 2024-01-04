using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vettori24._9
{
    internal class Vettore
    {
        public int X {  get; set; }
        public int Y { get; set; }
        public double Lunghezza { get; set; }
        public double Calcolalunghezza() 
        {
            Lunghezza= Math.Sqrt(X*X/2+Y*Y/2);
            return Lunghezza;
        }
        
    }
}
