using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace introseHHC.Objects
{
    public class Person
    {
        protected Name name = new Name();
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
            address = new Address();
            contactList = new LinkedList<Contact>();
          
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
            name.setDesignation(d);
            name.setFirstName(f);
            name.setMiddleName(m);
            name.setLastName(s);

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
        public Name getName()
            {
                return name;
            }
        public DateTime getBDay()
            {
                return bday;
            }
        public LinkedList<Contact> getContactNumbers()
            {
                return contactList;
            }
        public Address getAddress()
            {
                return address;
            }
        public string getGender()
            {
                return gender;
            }
        public string getNationality()
            {
                return nationality;
            }
        public string getReligion()
            {
                return religion;
            }
        public string getCivilStatus()
            {
                return civstat;
            }
        public string getEducAttainment()
            {
                return educattain;
            }
        public string getEmail()
            {
                return email;
            }

    }
}
