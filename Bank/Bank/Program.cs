using Bank;
using System.Threading;
using static System.Console;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            /*bruger calssen BankAccount og sætter den til bankAccount*/
            BankAccount bankAccount = new();
            List<Person> persons = new List<Person>();
            persons.Add(new Person(1, "peter", "pedersen", 1234, 100));


            WriteLine("velcome til din bank");
            WriteLine("1: login");
            WriteLine("2: afslut");
            Write("> ");
            /**/
            int chose = Convert.ToInt32(ReadLine());

            switch (chose)
            {
                case 1:
                    Clear();
                    bankAccount.Login(persons);
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
                default:
                    WriteLine("UDGYTIGVALG");
                    break;
            }
        }
    }
}