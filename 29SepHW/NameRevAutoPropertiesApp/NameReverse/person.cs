using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameReverse
{
    class person
    {
        public string Firstname { get; set; }
        public string Middlename { get;  set; }
        public string Lastname { get;  set; }


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
