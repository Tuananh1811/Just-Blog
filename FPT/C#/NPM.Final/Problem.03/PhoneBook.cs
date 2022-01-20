using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem._03
{
    public class PhoneBook
    {
        public string Name;
        public string PhoneNumber;
        public string Email;
        public string Address;
        public int Group;

        public PhoneBook()
        {
        }

        public PhoneBook(string name, string phoneNumber, string email, string address, int group)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = address;
            Group = group;
        }
       
        public override string ToString()
        {
            var showInfor =
                $"{$"{Name}",-15} " +
                $"{$"{PhoneNumber}",-25}" +
                $"{$"{Email}",-15}" +
                $"{$"{Address}",-10}" +
                $"{$"{Group}",-10}";
            return showInfor;
        }

    }
}
