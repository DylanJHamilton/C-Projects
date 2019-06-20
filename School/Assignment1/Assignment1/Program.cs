using System;
using System.Collections.Generic;


namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = Person.getPersonInformation();
            Person person2 = Person.getPersonInformation();
            Person person3 = Person.getPersonInformation();

            person1.DisplayPersonInfo(1);
            person2.DisplayPersonInfo(2);
            person3.DisplayPersonInfo(3);

            Person.DisplayStaticVars();

            Console.WriteLine("\n\n\nPress Enter key to end program");
            Console.ReadLine();
        }
        }
    }
