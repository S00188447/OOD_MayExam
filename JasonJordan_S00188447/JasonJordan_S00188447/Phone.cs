using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JasonJordan_S00188447
{




    public class Phone
    {
        [Key]
        public int PhoneID { get; set; }
        public int Price { get; set; }

        public string Name { get; set; }

        public string OperatingSystem { get; set; }

        public string OS_Image { get; set; }

        public string Phone_Image { get; set; }



        public void IncreasePrice(int percentageIncrease)
        {
            Price = Price * percentageIncrease/100 + Price;
        }
    }

    public class PhoneData : DbContext
    {

        public PhoneData() : base("MyPhoneData") { }


        public DbSet<Phone> Phones { get; set; }
    }

    





}
