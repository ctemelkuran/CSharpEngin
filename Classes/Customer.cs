using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {
        //field
        public int Firstname;

        //property, class'ın özelliklerini anlatacaksak
        public int Id { get; set; }       
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
