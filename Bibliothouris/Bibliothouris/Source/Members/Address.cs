using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliothouris.Source.Members
{
   public class Address
    {
         string street;
         string number;
         string postalCode;
         string city;

        public Address(string street, string number, string postalcode, string city)
        {
            this.street = street;
            this.number = number;
            this.postalCode = postalcode;
            this.city = city;
        }

        public string getCity()
        {
            return city;
        }
    }
}
