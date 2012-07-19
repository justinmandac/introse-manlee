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

        public void setLabel(string l)
        {
            label = l;
        }

        public void setNum(UInt16 n)
        {
            num = n;
        }
    }
}
