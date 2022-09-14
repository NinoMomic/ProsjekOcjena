using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProsjekOcjena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //varijable
            int brojOcjena, ocjena;
            double prosjek, zbrojOcjena = 0;

            //zaglavlje aplikacije
            Console.WriteLine("##########################");
            Console.WriteLine("# Izračunavanje prosjeka #");
            Console.WriteLine("##########################");
            Console.WriteLine("Za kraj unesi nulu.");

            //unos broja ocjena
            Console.WriteLine("Unesi broj ocjena: ");
            brojOcjena = Convert.ToInt32(Console.ReadLine());

            //unos i zbroj ocjena
            do
            {
                Console.WriteLine("Unesi ocjenu: ");
                ocjena = Convert.ToInt32(Console.ReadLine());

                if (ocjena > 1 && ocjena <= 5)
                {
                    zbrojOcjena += ocjena;
                }
                else if (ocjena == 1)
                {
                    Console.WriteLine(" Nisi prošao razred! ");
                    break;
                }
                else
                {
                    Console.WriteLine("Ocjenu koju si upisao nije u rasponu!!");
                    break;
                }

            } while (ocjena != 0);

            //prosjek ocjena
            prosjek = zbrojOcjena / brojOcjena;
            Console.WriteLine(prosjek);

            Console.ReadKey();
        }
    }
}
