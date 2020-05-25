using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class PartTimeStudent : Student {

        public override string ToString()
        {
            return $"'type:Part Time Student', 'firstname':{this.firstName}, 'lastName':{this.lastName}, 'id':{this.studentId} ";
        }
        public PartTimeStudent(int studentId, string firstName, string lastName)
        {
            this.studentId = studentId;
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
