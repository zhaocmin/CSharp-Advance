using System;
using System.Collections.Generic;
namespace AssignmentAdv2
{
    class Program
    {
        static void Main(string[] args)
        {
            ChangMinZhaoClass<string> myName = new ChangMinZhaoClass<string>("Changmin Zhao");
            Console.WriteLine($"Your name is {myName.print()}");
        }
    }
}
