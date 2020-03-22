using System.Collections.Generic;

namespace ConsoleApp1
{
    public class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if (x.indexNumber != y.indexNumber) return false;
            if (!x.fname.Equals(y.fname)) return false;
            if (!x.lname.Equals(y.lname)) return false;
            return true;
        }

        public int GetHashCode(Student obj)
        {
            return obj.indexNumber;
        }
    }
}