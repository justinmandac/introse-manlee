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
        //address fields
        protected UInt16 stNum;
        protected string addLine;
        protected string city;
        protected string region;
        //contact fields
        protected UInt16 homeNum;
        protected UInt16 workNum;
        protected UInt16 mobNum;
        protected UInt16 otherNum;

        public Person()
        {
          
            fname = sname = mname = "";
            gender = civstat = "";
            nationality = educattain = email = "";
            age = 0;
       
               
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
        public void setAddress(UInt16 num, string a, string c, string r)
        {
           stNum =  num;
            addLine = a;
            city = c;
            region = r;
        }
        public void setNumbers(UInt16 home, UInt16 work, UInt16 mobile, UInt16 other)
        {
            this.mobNum = mobile;
            this.homeNum = home;
            this.workNum = work;
            this.otherNum = other;
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
        public int getStNum()
        {
            return stNum;
        }
        public string getAddLine()
        {
            return addLine;
        }
        public string getCity()
        {
            return city;
        }
        public string getRegion()
        {
            return region;
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
        public UInt16 getWorkNum()
        {
            return workNum;
        }
        public UInt16 getHomeNum()
        {
            return homeNum;
        }
        public UInt16 getMobNum()
        {
            return mobNum;
        }
        public UInt16 getOtherNum()
        {
            return otherNum;
        }
    }
}
