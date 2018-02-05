using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2
{
    class Program
    {
        static void Main(string[] args)
        {

            var persons = new List<Person>();
            persons.Add(new Person { Firstname = "Kirsi", Lastname = "Mainio", SocialSecurityNumber = "010190-111A" });
            persons.Add(new Person { Firstname = "Matti", Lastname = "Husso", SocialSecurityNumber = "020292-222A" });
            persons.Add(new Person { Firstname = "Teppo", Lastname = "Vuolle", SocialSecurityNumber = "030393-333A" });

            Console.WriteLine(persons.ElementAt(0).ToString());
            Console.WriteLine(persons[0].ToString());

            foreach (Person person in persons)
            {
                Console.WriteLine(person.ToString());
                if (person == persons.Last())
                {
                    Console.WriteLine("LAST!");
                }
            }

            persons.Sort((x, y) => x.Lastname.CompareTo(y.Lastname));
            foreach (Person person in persons)
            {
                Console.WriteLine(person.ToString());
            }











            /* var names = new List<string>
            {
                "annna",
                "pekka",
                "kimmo",
                "daavetti"
            };
            names.ForEach(name => Console.WriteLine($"hello {name}"));
            names.ForEach(ShowinConsole);
        }
        private static void ShowinConsole(string txt)
        {
            Console.WriteLine(txt);
        }*/
        }
    }
}
