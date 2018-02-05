using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stakking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Person> persons = new Dictionary<string, Person>();

            Person person1 = new Person { Firstname = "kirsti", Lastname = "mainio", SocialSecurityNumber = "123123" };
            Person person2 = new Person { Firstname = "homo", Lastname = "petteri", SocialSecurityNumber = "5673123" };
            Person person3 = new Person { Firstname = "Kusi", Lastname = "paa", SocialSecurityNumber = "12657" };


            persons.Add(person1.SocialSecurityNumber, person1);
            persons.Add(person2.SocialSecurityNumber, person2);
            persons.Add(person3.SocialSecurityNumber, person3);

            string key = "5673123";
            Person found;
            if(persons.TryGetValue(key, out found))
            {
                
                Console.WriteLine("Person with SSN {0} found: {1}", key, found.ToString());
            }
            else
            {
                Console.WriteLine("Person with SSN {0} NOT FOUND}", key);
            }
            foreach (string key2 in persons.Keys)
            {
                Console.WriteLine(key2);
            }
            foreach (Person person in persons.Values)
            {
                Console.WriteLine(person.ToString());
            }

            foreach (KeyValuePair<string, Person> kvp in persons)
            {
                Console.WriteLine("{0] : {1}", kvp.Key, kvp.Value);
            }
            if (persons.ContainsKey(key))
            {
                persons.Remove(key);
            }

















            /* Queue<string> queue = new Queue<string>();

            queue.Enqueue("first");
            queue.Enqueue("second");
            queue.Enqueue("third");

            string first = queue.Peek();
            Console.WriteLine("First is queye is {0}", first);
            Console.WriteLine("queue count {0}", queue.Count);

            first = queue.Dequeue();
            Console.WriteLine("First is queye is {0}", first);
            Console.WriteLine("queue count {0}", queue.Count);



            /*Stack<string> stackStrings = new Stack<string>();
            stackStrings.Push("First");
            stackStrings.Push("second");
            stackStrings.Push("third");

            Console.WriteLine(stackStrings.Peek());
            Console.WriteLine("");

            foreach(string s in stackStrings)
            {
                Console.WriteLine(s);
            }

            string temp = stackStrings.Pop();
            Console.WriteLine("Just popped: {0}", temp);
            Console.WriteLine("Stack count: {0}", stackStrings.Count);*/
        }
    }
}
