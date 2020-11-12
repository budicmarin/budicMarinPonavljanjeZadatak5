using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budicMarinPonavljanjeZadatak5
{
    class Program
    {
        static void Main(string[] args)
        {
            int karte;
            int zbroj = 0;
            while(zbroj<31)
            {
               karte=Convert.ToInt32( Console.ReadLine());
                if (karte > 0 && karte < 14)
                {
                    zbroj = zbroj + karte;
                }
            }
            if (zbroj == 31)
            {
                Console.WriteLine("Pobijedio si");
            }
            else
            {
                Console.WriteLine("Izgubio si");
            }
            Console.ReadKey();
        }
      
    }
}
