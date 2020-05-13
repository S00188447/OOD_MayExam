using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JasonJordan_S00188447;

namespace DataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneData db = new PhoneData();

            using(db)
            {
                Phone p1 = new Phone() {PhoneID = 1, Name = "Samsung 520", Price = 500, OperatingSystem = "Android", OS_Image = "/images/android.png", Phone_Image = "/images/s20.jpg" };
                Phone p2 = new Phone() {PhoneID = 2, Name = "iPhone 11", Price = 600, OperatingSystem = "IOS", OS_Image = "/images/apple.png", Phone_Image = "/images/iphone11.jpg" };

                db.Phones.Add(p1);
                db.Phones.Add(p2);

                Console.WriteLine("Added Phones to database");

                db.SaveChanges();

                Console.WriteLine("Saved changes");
            }
        }
    }
}
