using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Static_and_Constructor_life_app
{
    class clsPerson {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        clsPerson(int Id, string Name, int Age) {
            this .Id = Id;  
            this .Name = Name;
            this .Age = Age;
        }
        public static clsPerson Find(int Id) {
            // simulating the database
            if (Id == 10)
            {
                clsPerson Person = new clsPerson(10, "Carlos", 27);
                return Person;
            }
            else { 
                return null;
            }
        }
        public static clsPerson Find(string Username, string Password) {
            // simulating the database
            if (Username == "Carlos" && Password == "12345")
            {

                clsPerson Person = new clsPerson(15, "Carlos costa", 27);
                return Person;
            }
            else { 
                
                return null;
            }


        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Finding peson by Id:");
            clsPerson Person1 = clsPerson.Find(9);
            if (Person1 != null)
            {
                Console.WriteLine("Id: {0}", Person1.Id);
                Console.WriteLine("Name: {0}", Person1.Name);
                Console.WriteLine("Age: {0}", Person1.Age);

            }
            else {
                Console.WriteLine("Person couldn't be found");
            }

            Console.WriteLine();

            Console.WriteLine("Finding Person2 by username and password....");
            clsPerson Person2 = clsPerson.Find("Carlos", "12345");
            if (Person2 != null)
            {
                Console.WriteLine("Id: {0}", Person2.Id);
                Console.WriteLine("Name: {0}", Person2.Name);
                Console.WriteLine("Age: {0}", Person2.Age);
            }
            else {
                Console.WriteLine("Person couldn't be found");
            }
        }
    }
}
