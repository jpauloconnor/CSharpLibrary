using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._31_Equality_Struct_Implementation
{
    public enum StudentGroup { Senior, Junior, Sophomore, Freshman }

    public struct Student : IEquatable<Student>
    {
        public static bool operator ==(Student lhs, Student rhs)
        {
            return lhs.Equals(rhs);
        }
        public static bool operator !=(Student lhs, Student rhs)
        {
            return lhs.Equals(rhs);
        }
        private readonly string _name;
        private readonly StudentGroup _group;

        public string Name { get { return _name; } }
        public StudentGroup Group { get { return _group; } }

        public Student(string name, StudentGroup group)
        {
            this._name = name;
            this._group = group;
        }

        public bool Equals(Student other)
        {
            bool returnValue = this._name == other.Name && this._group == other._group;
            return returnValue;
        }
    }
}
