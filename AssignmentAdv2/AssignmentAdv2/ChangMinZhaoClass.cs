using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentAdv2
{
    //public interface isString
    //{
    //    string value { get; }
    //}
    class ChangMinZhaoClass<T>
    {
        private T name;
        public ChangMinZhaoClass(T value)
        {
            name = value;
        }
        public T print()
        {
            return name;
        }
    }
}
