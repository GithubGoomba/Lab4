using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLib
{
    public class Person : ICloneable
    {
        private int _ID = 0;
        private string _LastName = string.Empty;
        private string _FirstName = string.Empty;
        private DateTime _DOB = DateTime.MinValue;

        public int ID
        {
            get
            {
                return _ID;
            }
            private set
            {
                if (value < 0 || value > 999999999)
                {
                    throw new ArgumentOutOfRangeException("ID");
                }
                _ID = value;
            }
        }

        public DateTime DOB
        {
            get
            {
                return _DOB;
            }
            set
            {
                value = _DOB;
            }
        }

        public string LastName
        {
            get
            {
                return _LastName;
            }

            set
            {
                _LastName = value;
            }
        }

        public string FirstName
        {
            get
            {
                return _FirstName;
            }

            set
            {
                _FirstName = value;
            }
        }

        #region constructors
        //copy constructor?
        public Person(Person person) 
        {
            _ID = person.ID;
            _LastName = person.LastName;
            _FirstName = person.FirstName;
            _DOB = person.DOB;
        } 
        internal Person(int id, string lastname, string firstname, DateTime dob )
        {
            _ID = id;
            _LastName = lastname;
            _FirstName = firstname;
            _DOB = dob;
        }



        #endregion

        #region methods
        public object Clone()
        {
            return new Person(this); //Can I do it this way?
        }
        public string GetFormattedID()
        {
            string id = ID.ToString("000000000");
            string digits = id.Substring(id.Length - 4);
            return $"XXX-XX-{digits}";
        }
        public int GetAge()
        {
            DateTime now = DateTime.Now;
            int years = now.Year - DOB.Year;
            if((now.Month < DOB.Month) || ((now.Month == DOB.Month) && (now.Day < DOB.Day)))

            {
                --years;
            }
            return years;
        }

        public override string ToString()
        {
            return $"{ID:000-00-0000} {LastName,-15} {FirstName,-15} {DOB:yyyy-MM-dd} {GetAge(),3}"; 
        }

        public static string GetHeader()
        {
            return $"{"ID",-11} {"Last Name",-15} {"First Name",-15} {"DOB",-10} {"Age"}";
        }

        #endregion


    }
}
