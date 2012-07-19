using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace introseHHC.Objects
{
    public class Name
    {
        private string desig;
        private string firstName;
        private string middleName;
        private string lastName;
      

        public Name()
        {
            desig = "";
            firstName = "";
            middleName = "";
            lastName = "";
         }
        public Name(string d, string f, string m, string l)
        {
            desig = d;
            firstName = f;
            middleName = m;
            lastName = l;
        }
        public Name(string f, string m, string l)
        {
            firstName = f;
            middleName = m;
            lastName = l;
        }

        public void setDesignation(string d)
        {
            desig = d;
        }
        public void setFirstName(string f)
        {
            firstName = f;
        }
        public void setMiddleName(string m)
        {
            middleName = m;
        }
        public void setLastName(string l)
        {
            lastName = l;
        }

        public string getFullName()
        {
            string full;

            full = firstName + " " + middleName + " " + lastName;

            if (desig.Length > 0)
                full = desig + " " + full;
   
            return full;

        }
        public string getDesignation()
        {
            return desig;
        }
        public string getFirstName()
        {
            return firstName;
        }
        public string getMiddleName()
        {
            return middleName;
        }
        public string getLastName()
        {
            return lastName;
        }

    }
}
