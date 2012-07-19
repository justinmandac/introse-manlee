using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace introseHHC.Objects
{
    public class Contact
    {
        private string label;
        private UInt16 num;

        public Contact(string l, UInt16 n)
        {
            label = l;
            num = n;
        }

        public void setLabel(string l)
        {
            label = l;
        }

        public void setNum(UInt16 n)
        {
            num = n;
        }

        public string getLabel()
        {
            return label;
        }
        public UInt16 getNum()
        {
            return num;
        }
    }
}
