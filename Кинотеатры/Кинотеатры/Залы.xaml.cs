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
    /// Логика взаимодействия для Залы.xaml
    /// </summary>
    public partial class Залы : Window
    {
        private static List<Room> GetRooms()
        {
            MyDBContext context = new MyDBContext();
            return context.Rooms.Select(h => h).ToList<Room>();
        }
        private static List<string> GetCinemas()
        {
            List<string> cinemas = new List<string>();
            foreach (var item in Кинотеатры.Cinist())
            {
                cinemas.Add(item.CinemaName);
            }
            return cinemas;
        }
        public Залы()
        {
     
        InitializeComponent();
            using (var context = new MyDBContext())
            {
                Roomes.ItemsSource = GetRooms();
                ComboCinema.ItemsSource = GetCinemas();
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
            using (var context = new MyDBContext())
            {
                Room room = new Room()
                {
                    Name = TextRoom.Text,
                    CinemaName = ComboCinema.SelectedItem.ToString()
                };
                context.Rooms.Add(room);
                context.SaveChanges();
                Roomes.ItemsSource = GetRooms();
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {   
            Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Roomes.SelectedItem != null)
            {
                MyDBContext context = new MyDBContext();
                Room Cindex = Roomes.SelectedItem as Room;
                context.Rooms.Remove(context.Rooms.Where(x => x.Id == Cindex.Id).FirstOrDefault());
                context.SaveChanges();
                Roomes.ItemsSource = context.Rooms.ToList();
            }
        }
    }
}
