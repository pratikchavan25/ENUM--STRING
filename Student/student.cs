using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ennum
{
    public enum Stream { CS, IT, Electrical, Electronic, Mech, Civil };

    public class Student1
    {
        private string Name;
        private int roll_no;
        private int age;
        // private char gender;
        private Stream stream;
        // private static int count;

        public Student1(string Name, int roll_no, int age, Stream stream)
        {

            this.Name = Name;
            this.roll_no = roll_no;
            this.age = age;
            this.stream = stream;
        }
        public override string ToString()
        {
            return $"Name is {Name}  Roll no is {roll_no} Age is {age} Stream is {stream}";
        }

    }

}





