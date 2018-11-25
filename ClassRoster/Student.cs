using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoster
{
    public class Student
    {
        private string _name;
        private string _major;
        private int _assignment;
        private int _test;
        
        public string Name
        {
            get {
                return _name;
            }
            set {
                _name = value;
            }
        }
        public string Major
        {
            get {
                return _major;
            }
            set {
                _major = value;
            }
        }
        public int Assignment
        {
            get {
                return _assignment;
            }
            set {
                _assignment = value;
            }
        }
        public int Test
        {
            get {
                return _test;
            }
            set {
                _test = value;
            }
        }

        public double Grade()
        {
            return (_assignment * .55) + (_test * .45);
        }

        public Student()
        {

        }

        public Student(string name,string major)
        {
            Name = name;
            Major = major;
        }

        public override string ToString()
        {
            return $"{Name},{Major},{Assignment},{Test}";
        }
    }
}
