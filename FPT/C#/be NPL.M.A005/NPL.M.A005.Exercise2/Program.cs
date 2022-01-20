using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPL.M.A005.Exercise2
{
    class Program
    {

        public static bool CheckFirstChar(char charFirst)
        {
            if (Char.IsDigit(charFirst) || charFirst == '-' || charFirst == '.')
                return true;
            return false;
        }
        public static bool CheckFullNumber(string domain)
        {
            int dem = 0;
            for (int i = 0; i < domain.Length; i++)
            {
                if (Char.IsDigit(domain[i]))
                {
                    dem++;
                }
            }
            if (dem == domain.Length)
            {
                return false;
            }
            return true;
        }
        public static bool CheckLastChar(char charLast)
        {


            if (charLast == '-' || charLast == '.')
                return true;
            return false;
        }

        public static bool IsEmail(string email)
        {

            var exEmail = email.Trim();
            try
            {

                string[] partOfEmail = exEmail.Split('@');
                var localPart = partOfEmail[0];
                var domainPart = partOfEmail[1];
                int dem = 0;
                // bool isValid=true;
                for (int i = 0; i < localPart.Length; i++)
                {

                    if (Convert.ToInt32(localPart[i]) == 46) //so sanh dau cham
                    {
                        dem++;
                    }
                }

                if (dem > 1)
                {
                    return false;
                }

                if (CheckFirstChar(localPart[0]) == false)
                {
                    if (CheckLastChar(localPart[localPart.Length - 1]) == false)
                    {
                        int i = 0;

                        while (i < localPart.Length && (Convert.ToInt32(localPart[i]) >= 33 && Convert.ToInt32(localPart[i]) <= 47
                            || Convert.ToInt32(localPart[i]) >= 65 && Convert.ToInt32(localPart[i]) <= 90
                            || Convert.ToInt32(localPart[i]) >= 97 && Convert.ToInt32(localPart[i]) <= 122
                            || Convert.ToInt32(localPart[i]) >= 48 && Convert.ToInt32(localPart[i]) <= 57))
                        {
                            i++;

                        }
                        if (i < localPart.Length)
                        {
                            return false;
                        }
                        // return true;  em không return ở đây là sửa được a ạ:v

                    }

                }
                else
                {

                    return false;
                }

                if (CheckFullNumber(domainPart))
                {

                    if (CheckFirstChar(domainPart[0]) == false)
                    {
                        if (CheckLastChar(domainPart[domainPart.Length - 1]) == false)
                        {
                            int i = 0;

                            while (i < domainPart.Length && (Convert.ToInt32(domainPart[i]) >= 65 && Convert.ToInt32(domainPart[i]) <= 90
                                || Convert.ToInt32(domainPart[i]) >= 97 && Convert.ToInt32(domainPart[i]) <= 122
                                || (Convert.ToInt32(domainPart[i]) >= 48 && Convert.ToInt32(domainPart[i]) <= 57)))
                            {
                                i++;

                            }
                            if (i < domainPart.Length)
                            {

                                return false;
                            }
                            return true;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return true;
        }
        static void Main(string[] args)
        {
            string email = "";
            while (true)
            {
                Console.WriteLine("nhap email : ");
                email = Console.ReadLine();
                if (IsEmail(email))
                {

                    Console.WriteLine("email: " + IsEmail(email));
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Email Error");
                }

            }
            Console.ReadKey();
        }
    }
}
