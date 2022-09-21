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
            int brojOcjena = 0, ocjena;
            double prosjek = 0, zbrojOcjena = 0;

            //zaglavlje aplikacije
            Console.WriteLine("##########################");
            Console.WriteLine("# Izračunavanje prosjeka #");
            Console.WriteLine("##########################");
            Console.WriteLine("Za kraj unesi nulu.");
  
            try
            {
            
                //unos i zbroj ocjena
                do
                {
                    Console.WriteLine("Unesi ocjenu: ");
                    ocjena = Convert.ToInt32(Console.ReadLine());

                    if (ocjena <= 5 && ocjena > 1)
                    {
                        zbrojOcjena += ocjena;
                        brojOcjena++;
                    }
                    else if(ocjena > 5 || ocjena < 1 )
                    {
                        Console.WriteLine("Pogrešan unos!");
                    }
                    if (ocjena == 1)
                    {
                        Console.WriteLine(" Nisi prošao razred! ");
                        break;
                    }

                } while (ocjena != 0);

            }
            catch (Exception greska)
            {
                Console.WriteLine("Neispravan unos, pokušajte ponovo.");
                Console.WriteLine("Opis greske: "+greska.Message);
            }

            //prosjek ocjena
            prosjek = zbrojOcjena / brojOcjena;
            Console.WriteLine(prosjek);

            Console.ReadKey();
        }
    }
}
