using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carshering2
{
    public class Users
    {

    }


    public class User
    {
        public string Name { get; }
        public string Surname { get; }
        public string MiddleName { get; }
        public int Age { get; }
        public int PasSeries { get; }
        public int PasNumber { get; }
        public string Password { get; }

        public User(string name, string surname, string middleName, int age, int pasSeries, int pasNumber, string password)
        {
            this.Name = name;
            this.Surname = surname;
            this.MiddleName = middleName;
            this.Age = age;
            this.PasSeries = pasSeries;
            this.PasNumber = pasNumber;
            this.Password = password;
        }
    }
}
