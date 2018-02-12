using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nimet = new List<string> { "Arska", "Kalle", "Cecilia", "Jack" };
            string foo = nimet.FirstOrDefault(x => x.StartsWith("Ja"));
            Console.WriteLine(foo); //this prints Jack
        }
        
        
        
        
        
        
        
        
        /* delegate void FormatNumber(double luku);
        s
        {
            //kysytään käyttäjältä jokin desimaaliluku
            Console.WriteLine("Anna desimaaliluku");
            string syote = Console.ReadLine();
            double aluku;
            if (double.TryParse(syote, out aluku))
            {
                //kiinnitetään useita metodeja delegaatille
                FormatNumber formatoija = FormatoiValuutaksi;
                formatoija += FormatoiKolmelleDesimaalille;
                //kutsutaan kiinnitetyt delegaatit
                formatoija(aluku);
            }

        }
        static void FormatoiValuutaksi(double luku)
        {
            Console.WriteLine("Annettu luku valuuttana {0:C}", luku);
        }
        static void FormatoiKolmelleDesimaalille(double luku)
        {
            Console.WriteLine("Annettu luku kolmen desimaalin tarkkuudella {0:.###}", luku);
        }*/
    }
}
