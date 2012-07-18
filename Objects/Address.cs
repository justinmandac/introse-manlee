using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace introseHHC.Objects
{
    class Address
    {
        //address fields
        private string number;
        private string addline1;
        private string city;
        private string region;

        public Address()
        {

        }

        public void setStreetNo(int n)
        {
            if (n > 0)
            {
                number = n;
            }
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
    }
}
