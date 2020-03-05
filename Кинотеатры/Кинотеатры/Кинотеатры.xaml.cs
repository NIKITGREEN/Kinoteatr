using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Кинотератры
{
    /// <summary>
    /// Логика взаимодействия для Кинотеатры.xaml
    /// </summary>
    public  partial class Кинотеатры : Window
    {
        public Кинотеатры()
        {
            InitializeComponent();
            using(var context = new MyDBContext())
            {
                //  ListCinemas = Cinist();
                Cinemas.ItemsSource = Cinist(); //ListCinemas;
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Wind.OpenЗалы(this);
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Wind.OpenФильмы(this);
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Wind.OpenСеансы(this);
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Wind.OpenРепертуар_кинотеатра(this);
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            Wind.OpenИнформация_об_кинотеатре(this);
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            Wind.OpenПоиск(this);
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            Wind.OpenИнформация_о_фильме(this);
        }
        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            Wind.OpenКинотеатры(this);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var context  = new MyDBContext())
            {
                Cinema cinema = new Cinema()
                {
                    CinemaName = kinoteatr.Text,
                    Adress = adress.Text,
                    Phone = nomer.Text,
                    Transport = marshrut.Text
                };
                context.Cinemas.Add(cinema);
                context.SaveChanges();
                ListCinemas = Cinist();
                Cinemas.ItemsSource = ListCinemas;
            }

        }

        public static List<Cinema> Cinist()
        {
            MyDBContext context = new MyDBContext();
            return context.Cinemas.Select(h => h).ToList<Cinema>();
        }
        private List<Cinema> ListCinemas;

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            if (Cinemas.SelectedItem != null)
            {
                MyDBContext context = new MyDBContext();
                Cinema Cindex = Cinemas.SelectedItem as Cinema;
                context.Cinemas.Remove(context.Cinemas.Where(x => x.Id == Cindex.Id).FirstOrDefault());
                context.SaveChanges();
                Cinemas.ItemsSource = context.Cinemas.ToList();
            }

        }
    }
}
