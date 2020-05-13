using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JasonJordan_S00188447
{

    public partial class MainWindow : Window
    {
        PhoneData db = new PhoneData();


        public MainWindow()
        {
            InitializeComponent();
        }



        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            var query = from p in db.Phones
                        orderby p.Name descending
                        select new
                        {

                            PhoneName = p.Name
                            
                        };
            PhoneNameLBX.ItemsSource = query.ToList();

            var query3 = from p in db.Phones
                        orderby p.Name descending
                        select new
                        {

                            Price = p.Price

                        };
            PhonePriceLBX.ItemsSource = query3.ToList();






        }

        private void PhoneNameLBX_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            var query = from p in db.Phones
                        select p.Name;

            string selected = PhoneNameLBX.SelectedItem as string;

            switch (selected)
            {
                case "{PhoneName = Samsung 520}":
                    var query1 = from p in db.Phones
                                 where p.PhoneID == 1
                                 orderby p.Price
                                 select new
                                 {
                                     Price = p.Price



                                 };

                    PhonePriceLBX.ItemsSource = query1.ToList();

                    //string imagesource = "/images/android.png";

                    //PhoneImage.Source = imagesource;
                    break;

                case "{PhoneName = iPhone11}":
                    var query2 = from p in db.Phones
                                where p.PhoneID == 2
                                orderby p.Price
                                select new
                                {
                                    Price = p.Price
                                    


                                };

                    PhonePriceLBX.ItemsSource = query2.ToList();
                    break;

            }


        }
    }
}
