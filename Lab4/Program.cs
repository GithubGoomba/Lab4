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
           // Hospital.Create(123456789, "Zhang", "Fred", DateTime.Parse("2009-06-01"));
            Person pf1 = Hospital.Create(123456789, "Zhang", "Fred", DateTime.Parse("2009-06-01"));
            //list.Add(p1);
            //Console.WriteLine(p1);
        }
    }
}
