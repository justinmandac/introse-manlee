using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace introseHHC.Objects
{
    class Person
    {
        public const byte NAME_LEN = 32;
        private string fname;
        private string sname;
        private string mname;
        private char gender;
        private string nationality;
        private char civstat;
        private string educattain;
        private string email;
        private DateTime bday;
        private UInt16 age;
        private Address address;
        private LinkedList<Contact> contactList;

        public Person()
        {
            fname = sname = mname = "";
            gender = civstat = ' ';
            nationality = educattain = email = "";
            age = 0;
            address = null;
        }
        public Person(string fn,string sn, string mn, char gen,string nat, char cstat)
        {
            fname = fn;
            sname = sn;
            mname = mn;
            gender = gen;
            nationality = nat;
            civstat = cstat;
        }

        public void setName(string f, string m, string s)
        {
            //assume max length is 32 characters per field
                fname = f;
                mname = m;
                sname = s;
        }
        public void setAddress(Address a)
        {
            address = a;
        }


       
        
    }
}
