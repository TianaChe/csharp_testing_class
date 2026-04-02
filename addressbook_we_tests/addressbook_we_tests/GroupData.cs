using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    internal class GroupData
    {
        public string Name {  get; private set; }
        public string Header { get; private set; }
       public string Footer { get; private set; }
        public GroupData(string name, string header, string footer)
        {
            Name = name; 
            Header = header;
            Footer = footer;
       
     
        }

        

    }


}
