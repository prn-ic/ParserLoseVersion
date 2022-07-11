using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonParcer
{
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Profession { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}; FirstName: {FirstName}; LastName: {LastName}; E-mail: {Email}; Age: {Age}; Profession: {Profession}";
        }
    }
}
