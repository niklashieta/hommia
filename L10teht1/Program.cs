using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//tiedostojen käsittelyä

namespace JAMK.IT
{
    class NamesToFile
    {
        static void Test()
        {
            string myfile = @"D:\K9279\testi.txt";
            string line;
            try
            {
                //luodaan tiedosto
                using (StreamWriter sw = new StreamWriter(myfile))
                {
                    //kysytään käyttäjältä nimet// ja kirjoitetaan nimet sinne
                    do
                    {
                        Console.WriteLine("Anna henkilon nimi (tyhja lopettaa) ");
                        line = Console.ReadLine();
                        if (line.Length > 0)
                            sw.WriteLine(line);
                    } while (line.Length > 0);
                    sw.Close();
                }
                //avataan tiedosto lukua varten
                if (File.Exists(myfile))
                {
                    //näytetään nimet
                    string txt = File.ReadAllText(myfile);
                    Console.WriteLine("tiedostossa {0} on nimet: {1}", myfile, txt);
                }
                else
                {
                    Console.WriteLine("tiedostoa {0] ei loydy", myfile);
                }

                
            }
            catch (Exception)
            {
                throw;
            }


        }
        static void Main(string[] args)
        {
            try
            {
                Test();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }
    }
}
