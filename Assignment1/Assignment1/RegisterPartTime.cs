using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class RegisterPartTime : IRegisterStudent
    {
        List<PartTimeStudent> partTimeStudents = new List<PartTimeStudent>();
        // ArrayList<PartTimeStudent> partTimeStudents = new ArrayList<PartTimeStudent>();
        public void getStudents()
        {
            foreach (var item in partTimeStudents)
            {
                Console.WriteLine(item.ToString());
            }
        }


        public void Register(Student s)
        {
            partTimeStudents.Add((PartTimeStudent)s);
        }
    }
}
