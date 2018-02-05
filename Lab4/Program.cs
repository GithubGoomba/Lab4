using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonLib;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            PersonFactory Hospital = PersonFactory.Instance;
            Person p1 = Hospital.Create(123456789, "Zhang", "Fred", DateTime.Parse("2009-06-01"));
            Person p2 = Hospital.Create(123456788, "Fox", "Carson", DateTime.Parse("2001-06-01"));
            Person p3 = Hospital.Create(123456787, "Hamburger", "John", DateTime.Parse("2003-06-01"));
            Person p4 = Hospital.Create(123456786, "Porridge", "Tina", DateTime.Parse("2004-06-01"));
            Person p5 = Hospital.Create(123456785, "Carlisle", "Kristina", DateTime.Parse("2002-06-01"));
            list.Add(p1);
            list.Add(p2);
            list.Add(p3);
            list.Add(p4);
            list.Add(p5);

            Person p6 = new Person(p5); //clone a person
            p6.LastName = "Delgado";
            p6.FirstName = "Susanna";
            p6.DOB = DateTime.Parse("1992-01-12");
            list.Add(p6);

            Console.WriteLine(Person.GetHeader());
            foreach (Person p in list)
            {
                Console.WriteLine(p);
            }

            Console.ReadLine();
        }
    }
}
