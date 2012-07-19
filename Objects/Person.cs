using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace introseHHC.Objects
{
    public class Person
    {
        public const byte NAME_LEN = 32;
        protected string desig;
        protected string fname;
        protected string sname;
        protected string mname;
        protected string gender;
        protected string religion;
        protected string nationality;
        protected string civstat;
        protected string educattain;
        protected string email;
        protected DateTime bday;
        protected UInt16 age;
        protected Address address;
        protected LinkedList<Contact> contactList;

        public Person()
        {
            fname = sname = mname = "";
            gender = civstat = "";
            nationality = educattain = email = "";
            age = 0;
            address = null;
        }
        public Person(string fn,string sn, string mn, string gen,string nat, string cstat)
        {
            fname = fn;
            sname = sn;
            mname = mn;
            gender = gen;
            nationality = nat;
            civstat = cstat;
        }
      //Mutator methods
        public void setName(string d,string f, string m, string s)
        {
                desig = d;
            //assume max length is 32 characters per field
                fname = f;
                mname = m;
                sname = s;
        }
        public void setBday(DateTime b)
        {
       
            //convert to Integers & do error checking

            bday = b;

        }
        public void setGender(string g)
        {
            gender = g;
        }
        public void setNationality(string n)
        {
            nationality = n;
        }
        public void setReligion(string r)
        {
            religion = r;
        }
        public void setCivilStatus(string c)
        {
            civstat = c;

        }
        public void setEducAttainment(string e)
        {
            educattain = e;
        }
        public void setEmail(string e)
        {
            email = e;
        }
        public void addContact(Contact c)
        {
            contactList.AddLast(c);
        }
        public void setAddress(UInt16 num, string a, string c, string r)
        {
            address.setStreetNo(num);
            address.setAddLine(a);
            address.setCity(c);
            address.setRegion(r);
        }
    //Getter methods
        public string getName();
        public string getBDay();
        public string getGender();
        public string getNationality();
        public string getReligion();
        public string getCivilStatus();
        public string getEducAttainment();
        public string getEmail();
        public LinkedList<Contact> getContactNumbers();
        public Address getAddress();
    }
}
