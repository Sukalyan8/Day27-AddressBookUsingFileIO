using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystemUsingIO
{
    class Address
    {
        ArrayList addresses = new ArrayList();
        public void SetAddress()
        {
            Console.WriteLine("Enter City, state, zip");
            addresses.Add(Console.ReadLine());
        }
    }
}
