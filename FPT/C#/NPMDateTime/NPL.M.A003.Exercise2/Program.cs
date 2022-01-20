using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPL.M.A003.Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = new[]
            {
                "Created at 28/02/2018 10:15:35 AM by Andy.",
                "Updated at 03/03/2018 by Mark",
                "Clear name at 02 / 03 / 2018 11:34:05 AM by Andy",
               
            };

            var dic = new Dictionary<string, DateTime>();
            try
            {
                for (int i = 0; i < inputs.Length; i++)
                {
                    int startIndex = inputs[i].IndexOf(" at ") + 4;
                    int length = inputs[i].IndexOf(" by ") - startIndex;
                    string dateString = inputs[i].Substring(startIndex, length);
                    dic.Add(inputs[i], dateString.ToDateTime());
                }
                foreach (var item in dic.OrderBy(x => x.Value))
                {
                    Console.WriteLine(item.Key);
                    Console.WriteLine(item.Value.ToString("dd/MM/yyyy hh:mm:ss tt"));
                }
            }
            catch (ArgumentException aex)
            {
                Console.WriteLine(aex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();

        }
    }
}
