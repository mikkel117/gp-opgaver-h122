using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Password { get; set; }
        public double Balance { get; set; }

        public Person(int id, string name, string lastName, int password, double balance)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Password = password;
            Balance = balance;
        }
    }
}
