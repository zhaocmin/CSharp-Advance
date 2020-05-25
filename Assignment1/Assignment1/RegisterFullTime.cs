using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class RegisterFullTime : IRegisterStudent
    {
        List<FullTimeStudent> fullTimeStudents = new List<FullTimeStudent>();
        public void getStudents()
        {
            foreach(var item in fullTimeStudents)
            {
               Console.WriteLine(item.ToString());
            }
        }

        //public void Register(FullTimeStudent f)
        //{
        //    throw new NotImplementedException();
        //}

        public void Register(Student s)
        {
            fullTimeStudents.Add((FullTimeStudent)s);
        }
    }
}
