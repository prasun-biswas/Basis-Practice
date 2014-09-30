using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameReverse
{
    class person
    {
        public string Firstname { private get; set; }
        public string Middlename { private get;  set; }
        public string Lastname { private get;  set; }


        public person(string firstname,string middlename,string lastname):this(firstname,lastname)
        {
            
            Middlename = middlename;
            
        }

        public person(string firstname,string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }


        public string GetFullname()
        {
            return (Firstname + " " + Middlename +" " + Lastname);
        }

        public string GetReverseName()
        {
            string fullname = GetFullname();

            char[] cArray = fullname.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }
    }
}
