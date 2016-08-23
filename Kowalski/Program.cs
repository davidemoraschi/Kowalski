using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kowalski
{
    class Program
    {
        static void Main(string[] args)
        {
            using (NorthwindEFModelContext context = new NorthwindEFModelContext())
            {
                foreach (var c in context.Customers.Where(c => c.City == "Seattle"))
                {
                    Console.WriteLine(c.CompanyName);
                }
            }
        }
    }
}
