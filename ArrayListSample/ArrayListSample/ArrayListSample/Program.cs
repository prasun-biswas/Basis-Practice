using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListSample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(4);
            numbers.Add(2);
            numbers.Add(6);
            numbers.Add(9);

            foreach (int value in numbers)
            {
                Console.WriteLine(value);
            }

            Console.ReadKey();


        }
    }
}
