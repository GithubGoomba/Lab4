using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLib
{
    public class PersonFactory //Singleton factory design pattern
    {
        //restrict access through a single instance of an object
        private readonly static PersonFactory _Instance = null;  

        public static PersonFactory Instance
        {
            get
            {
                return _Instance;
            }
        }

        private PersonFactory() { } //prevents instantiation
        public Person Create(int id, string lastname, string firstname, DateTime dob)
        {
            return new Person(id, lastname, firstname, dob);
        }
        
    }
}
