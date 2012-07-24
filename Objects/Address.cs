using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace introseHHC.Objects
{
    public class Address
    {
        //address fields
        private UInt16 number;
        private string addline1;
        private string city;
        private string region;

        public Address()
        {
            number = 0;
            addline1 = "";
            city = "";
            region = "";
        }

        //Mutator Methods
        public void setStreetNo(UInt16 n)
        {
                number = n;
        }
        public void setAddLine(string a)
        {
            addline1 = a;
        }
        public void setCity(string c)
        {
            city = c;
        }
        public void setRegion(string r)
        {
            region = r;
        }
        //Accessor Methods
        public string getFullAddress()
        {
            return number.ToString() + " " + addline1 + " ," + city + ", " + region;
        }
        public UInt16 getNumber()
        {
            return number;
        }
        public string getAddLine()
        {
            return addline1;
        }
        public string getCity()
        {
            return city;
        }
        public string getRegion()
        {
            return region;
        }
    }
}
