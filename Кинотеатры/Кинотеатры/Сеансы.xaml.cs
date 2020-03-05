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
    /// Логика взаимодействия для Сеансы.xaml
    /// </summary>
    public partial class Сеансы : Window
    {

        MyDBContext context;


        public Сеансы()
        {
            InitializeComponent();
            context = new MyDBContext();
            DataSeans.ItemsSource =  context.Sessions.ToList();
            FilmBox.ItemsSource = context.Films.Select(x => x.Name).ToList();
            KinoBox.ItemsSource = context.Cinemas.Select(x => x.CinemaName).ToList();
            RoomBox.ItemsSource = context.Rooms.Select(x => x.Name).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Session session = new Session()
            {
                Cost = Convert.ToInt32(Costs.Text),
                Date = Dates.Text,
                RoomName = RoomBox.Text,
                CinemaName = KinoBox.Text,
                FilmName = FilmBox.Text,
                Time = Convert.ToInt32(Times.Text)
            };
            context.Sessions.Add(session);
            context.SaveChanges();
            DataSeans.ItemsSource = context.Sessions.ToList();
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

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (DataSeans.SelectedItem != null)
            {
                Session Cindex = DataSeans.SelectedItem as Session;
                context.Sessions.Remove(context.Sessions.Where(x => x.Id == Cindex.Id).FirstOrDefault());
                context.SaveChanges();
                DataSeans.ItemsSource = context.Sessions.ToList();
            }
        }
    }
}
