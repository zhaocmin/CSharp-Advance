using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class FullTimeStudent : Student
    {
        public override string ToString()
        {
            return $"'type:Full Time Student', 'firstname':{this.firstName}, 'lastName':{this.lastName}, 'id':{this.studentId} ";
        }
        public FullTimeStudent(int studentId, string firstName, string lastName)
        {
            this.studentId = studentId;
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
