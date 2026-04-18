using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringExtensionsLib;

namespace StringExtensionsConsumer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a string:");
            var input = Console.ReadLine();

            bool result = input.StartsWithUppercase();

            Console.WriteLine(result
                ? "Starts with uppercase"
                : "Does NOT start with uppercase");

        }
    }
}
