using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAddressbookTests;

namespace addressbook_we_tests
{
    internal class ContactData

    {      public string FirstName { get; private set; }
            public string MiddleName { get; private set; }
            public string LastName { get; private set; }


        public ContactData(string firstname, string middlename, string lastname)
        {
            FirstName = firstname;
            MiddleName = middlename;
            LastName = lastname;

        }
        
    }
    

    
}
