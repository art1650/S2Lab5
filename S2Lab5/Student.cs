using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2Lab5
{
    public class Student: IPerson
    {
        public int Cours { get; set; }
        public string Group { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Student (string Group, string FirstName, string LastName, int Age)
        {
            Cours = 1;
            this.Group = Group;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
        }
        public void Write()
        {
            Console.WriteLine($"імя {FirstName} фамілія {LastName} вік {Age}");
        }
    }
}
