﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystemUsingIO
{
    class PersonInfo : Address
    {
        ArrayList name = new ArrayList();
        ArrayList mobileNo = new ArrayList();
        ArrayList mail = new ArrayList();
        public void SetPersonInfo()
        {
            while (true)
            {
                Console.WriteLine("\n Enter person name :");
                name.Add(Console.ReadLine());

                Console.WriteLine("\n Enter person mobile number :");
                mobileNo.Add(Console.ReadLine());

                Console.WriteLine("\n Enter person Email ID :");
                mail.Add(Console.ReadLine());

                SetAddress();

                Console.WriteLine("\n you want add anathar person yes or no :");
                String check = Console.ReadLine();
                if (check.Equals("no"))
                    break;

            }
        }
        public void DisplayPersonInfo()
        {
            Console.WriteLine("\n ============= Person Information =============\n");
            for (int i = 0; i < name.Count; i++)
            {
                Console.WriteLine("Index No : " + i + " Name :" + name[i] + " Mobile No :" + mobileNo[i] + " Email ID :" + mail[i] + " Add :" + addresses[i]);
            }
        }
    }
}