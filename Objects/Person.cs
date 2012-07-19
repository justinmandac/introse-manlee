using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace introseHHC.Objects
{
    public class Person
    {
        public const byte NAME_LEN = 32;
        private string desig;
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

       

        public void setName(string d,string f, string m, string s)
        {
            desig = d;
            //assume max length is 32 characters per field
                fname = f;
                mname = m;
                sname = s;
        }

        public void setBday(string m, string d, string y)
        {
            Int32 dm, dd, dy;
            //convert to Integers & do error checking
            dm = Int32.Parse(m);
            dd = Int32.Parse(d);
            dy = Int32.Parse(y);

            bday = new DateTime(dy,dm,dd);

        }
       
        
    }
}
