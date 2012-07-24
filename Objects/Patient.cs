using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace introseHHC.Objects
{
    public class Patient: Person
    {
        public Patient()
        {
            fname = sname = mname = "";
            gender = civstat = "";
            nationality = educattain = email = "";
            age = 0;

        }
    }
}
