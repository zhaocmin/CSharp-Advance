using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Console.WriteLine("The member of list are: ");
            string line = Console.ReadLine();
            List<string> numbers = line.Split(' ').ToList();
            Console.WriteLine("The number than 80 list are: ");
            greaterExample(numbers);
            //Console.Write("How many records you want to display ? : ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //topNth(numbers, n);
        }
        public static void greaterExample(List<string> numbers)
        {


            var result = from s in numbers where Convert.ToInt32(s) > 80 select s;



            foreach (var num in result)
            {

                Console.WriteLine(num);
            }

        }
        private static void topNth(List<string> numbers, int n)
        {
            var thenByResult = numbers.OrderByDescending(s => Int16.Parse(s));
          
            foreach (string topn in thenByResult.Take(n))
            {
                Console.Write(topn);
                Console.Write(" ");
            }
        }
    

        public static void GroupByExample(List<string> numbers)
        {
      

            var groupedResult1 = from s in numbers
                                 group s by s;

            foreach (var numGroup in groupedResult1)
            {
                
                Console.WriteLine("Number {0} appears {1} times", numGroup.Key, numGroup.Count());
            }

        }
    }
}
