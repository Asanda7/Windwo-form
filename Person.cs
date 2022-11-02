using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllReadFormat
{
    class Person
    {
        internal  string name { get; set; }
        internal string surname { get; set; }

        internal string job { get; set; }
        //construction
        public Person(string n, string s, string j)
        {
            this.name = n;
            this.surname = s;
            this.job = j;
        }

        public override string ToString()
        {
            return $"Your name  is :  {this.name} | Your surname  is  : {this.surname} | Your job   is  : {this.job}";
        }
    }
}
