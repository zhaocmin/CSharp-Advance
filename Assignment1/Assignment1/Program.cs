using System;
using System.Collections.Generic;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IRegisterStudent registerStuF = new RegisterFullTime();
            IRegisterStudent registerStuP = new RegisterPartTime();
            registerStuF.Register(new FullTimeStudent(1, "Alen", "Jerry"));
            registerStuF.Register(new FullTimeStudent(2, "Charlie", "Jack"));
            registerStuP.Register(new PartTimeStudent(1, "Alex", "Zhao"));
            registerStuP.Register(new PartTimeStudent(3, "Marry", "Jack"));

            registerStuF.getStudents();
            registerStuP.getStudents();
            
        }
    }
}
