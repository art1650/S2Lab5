using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2Lab5
{
    public class CorrespondenceStudent : Student, IPerson
    {
        public string Country;
        public CorrespondenceStudent(string Group, string FirstName, string LastName, int Age, string Country) : base(Group, FirstName, LastName, Age)
        {
            Country = Country;
        }

        public void SetCountrye(string Country)
        {
            this.Country = Country;
        }
        public string GetCountry()
        {
            return this.Country;
        }
    }
}
