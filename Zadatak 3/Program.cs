using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int UneseniBroj, broj;

            Console.WriteLine("Unesi neki broj");

            
            UneseniBroj = Convert.ToInt32(Console.ReadLine());

            if ( UneseniBroj % 4 ==0 && UneseniBroj % 6 != 0)
            {

                Console.WriteLine("Broj je djeljiv sa 4");
            }
            if(UneseniBroj % 4 != 0  && UneseniBroj % 6 == 0)
            {
                Console.WriteLine("Broj je djeljiv sa 6");
            }
            if(UneseniBroj % 4 == 0 && UneseniBroj % 6 == 0)
            {
                Console.WriteLine("Broj je djeljiv sa 4 i sa 6");
            }
            if (UneseniBroj % 4 != 0 && UneseniBroj % 6 != 0)
            {
                Console.WriteLine("Broj nije djeljiv sa 4 i sa 6");
            }


        }
    }
}
