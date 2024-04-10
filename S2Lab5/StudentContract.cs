using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2Lab5
{
    public class StudentContract : Student, IPerson
    {
        public int Price { get; set; }
        public StudentContract(string Group, string FirstName, string LastName, int Age, int Price) : base(Group, FirstName, LastName, Age)
        {
            this.Price = Price;
        }
        public void SetPrice(int Price)
        {
            this.Price = Price;
        }
        public int GetPrice()
        {
            return this.Price;
        }

    }
}
