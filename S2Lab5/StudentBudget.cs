using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2Lab5
{
    public class StudentBudget: Student, IPerson
    {
        public int Scholarship;

        public StudentBudget(string Group, string FirstName, string LastName, int Age, int Scholarship) : base(Group, FirstName, LastName, Age)
        {
            this.Scholarship = Scholarship;
        }

        public void setScholarship(int Scholarship)
        {
            this.Scholarship = Scholarship;
        }
        public int getScholarship()
        {
            return Scholarship;
        }

        public void Write()
        {
            Console.WriteLine($"імя {FirstName} фамілія {LastName} вік {Age} степендія {Scholarship} грн");
        }
    }
}
