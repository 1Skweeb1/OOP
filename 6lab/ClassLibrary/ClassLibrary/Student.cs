using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Student
    {
        public string Name { get; set; }
        public string Group { get; set; }
        public Dictionary<string, int> Grades { get; set; } = new Dictionary<string, int>();

        public Student(string Name, string Group) {
            this.Name = Name;
            this.Group = Group;
        }

    }
}
