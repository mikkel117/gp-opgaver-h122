using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;
using System.Diagnostics;

namespace Bank
{
    internal class BankAccount
    {
        public void Login(List<Person> person)
        {
            Write("id: ");
            int id = 0, password = 0, index;
            try
            {
                id = Convert.ToInt32(ReadLine());
            }
            catch
            {
                IdError(person);
            }

            index = person.FindIndex(a => a.Id == id);
            if (person[index].Id == id)
            {
                Write("password: ");
                try
                {
                    password = Convert.ToInt32(ReadLine());
                }
                catch
                {
                    PasswordError(person);
                }

                if (person[index].Password == password)
                {
                    Clear();
                    Logedin(index, person);
                }
                else
                {
                    PasswordError(person);
                }

            }
            else
            {
                IdError(person);
            }

        }

        private void IdError(List<Person> person)
        {
            WriteLine("der var en fejl i id");
            WriteLine("tryk enter for at prøve igen");
            ReadKey();
            Clear();
            Login(person);
        }

        private void PasswordError(List<Person> person)
        {
            WriteLine("der var en fejl i password");
            WriteLine("tryk enter for at prøve igen");
            ReadKey();
            Clear();
            Login(person);
        }

        private void Logedin(int index, List<Person> person)
        {
            WriteLine($"du er logget in som {person[index].Name}");

            WriteLine("1: Hæv");


            WriteLine("2: Set in");

            WriteLine("3: Balance");

            Write(">");
            int chose = Convert.ToInt32(ReadLine());

            switch (chose)
            {
                case 1:
                    Withdraw(index, person);
                    break;
                case 2:
                    Deposit(index, person);
                    break;
                case 3:
                    WriteLine($"balance: {person[index].Balance}");
                    ReadLine();
                    Clear();
                    Logedin(index, person);
                    break;
                default:
                    Logedin(index, person);
                    break;
            }

        }

        private void Withdraw(int index, List<Person> person)
        {
            double temp = person[index].Balance;
            Write("Hæv: ");
            double Withdraw = Convert.ToInt32(ReadLine());
            if (temp - Withdraw >= 0)
            {
                person[index].Balance = temp - Withdraw;
                Clear();
                Logedin(index, person);
            }
            else
            {
                WriteLine("du kan ikke hæve over din balance");
                ReadKey();
                Logedin(index, person);
            }

        }

        private void Deposit(int index, List<Person> person)
        {
            double temp = person[index].Balance, setIn = 0;
            Write("sæt in: ");
            try
            {
                setIn = Convert.ToInt32(ReadLine());
            }
            catch
            {
                WriteLine("der skete en fejl");
                ReadKey();
                Logedin(index, person);
            }
            person[index].Balance = temp + setIn;
            Clear();
            Logedin(index, person);
        }
    }
}
