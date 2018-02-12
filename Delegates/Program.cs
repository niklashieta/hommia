﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        public delegate int CalcHandler(int x, int y);
        static void Main(string[] args)
        {
            Mymath math = new Mymath();
            //create a new instance of the delegate class
            CalcHandler sumHandler = new CalcHandler(math.Sum);
            //invoke the delegate
            int result = sumHandler(4, 2);
            Console.WriteLine("Result is: " + result);
            //change the method and invoke again
            sumHandler = new CalcHandler(math.FakeSum);
            Console.WriteLine("Result is now: " + sumHandler(4, 2));
        }
    }
}
