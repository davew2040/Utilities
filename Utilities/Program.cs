using System;
using UtilitiesLib;

namespace Utilities
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var timer = new ActionTimer(time => Console.WriteLine(time.TotalSeconds)))
            {
                Console.WriteLine("Hello World!");
            }
        }
    }
}
