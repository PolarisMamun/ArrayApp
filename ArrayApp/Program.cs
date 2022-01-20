using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            
            numbers[2] = 3;
            numbers[3] = 4;

            Console.WriteLine(numbers[2]);
            Console.ReadLine();
        }
    }
}
