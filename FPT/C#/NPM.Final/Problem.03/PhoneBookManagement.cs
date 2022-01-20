using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem._03
{
   public class PhoneBookManagement:PhoneBook
    {
        List<PhoneBook> ListPhoneBook = new List<PhoneBook>();
        public void DisplayBookProperties()
        {
            var formatString =
                $"{"Name",-15} " +
                $"{"PhoneNumber",-25}" +
                $"{"Email",-15}" +
                $"{"Address",-10}" +
                $"{"Group",-10}";
            Console.WriteLine(formatString);
        }
        public void ShowInForBook()
        {
            DisplayBookProperties();
            foreach (var book in ListPhoneBook)
            {
                Console.WriteLine(book.ToString());
            }
        }
        public void Add()
        {
            PhoneBook phoneBook = new PhoneBook();
           
                Console.Write("Enter name book: ");
                phoneBook.Name  = Console.ReadLine();
                Console.Write("Enter phone number: ");
                phoneBook.PhoneNumber = Console.ReadLine();
                Console.Write("Enter Email: ");
                phoneBook.Email = Console.ReadLine();
                Console.Write("Enter address: ");
                phoneBook.Address = Console.ReadLine();
                Console.Write("Enter group: ");
                phoneBook.Group =int.Parse(Console.ReadLine());
            ListPhoneBook.Add(phoneBook);
           
        }

        //public void Remove(string name)
        //{
        //    int count = 0;
        //    //Console.WriteLine("Enter the name you want to delete : ");
        //    //  name = Console.ReadLine();
        //    foreach (var item in ListPhoneBook)
        //    {
        //        if (item.Name == name)
        //        {
        //            ListPhoneBook.Remove(item);
        //            count++;
        //        }

        //    }
        //    if (count == 0)
        //    {
        //        Console.WriteLine("Error");
        //    }
        //}

        public List<PhoneBook> Sort()
        {
            return ListPhoneBook.OrderBy(p => p.Name).ToList();
        }

        public List<PhoneBook> Find(string name)
        {
            Console.WriteLine("Enter the name you want to delete : ");
            name = Console.ReadLine();
            return ListPhoneBook.FindAll(p => p.Name == name);
        }
     
    }
}
