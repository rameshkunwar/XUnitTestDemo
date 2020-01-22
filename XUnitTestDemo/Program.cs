using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTestDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = MathOperation.Add(120.25, 254.25);
            Console.WriteLine($"120.25 + 254.25 = {result}");

            string id = Guid.NewGuid().ToString();
            var guidId = id.ConvertStringToGuid();

            Console.WriteLine(guidId);

            Console.ReadLine();
        }
    }
}
