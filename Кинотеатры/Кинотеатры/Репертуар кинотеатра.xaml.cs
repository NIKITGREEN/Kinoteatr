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
    /// Логика взаимодействия для Репертуар_кинотеатра.xaml
    /// </summary>
    public partial class Репертуар_кинотеатра : Window
    {
        MyDBContext context;
        public Репертуар_кинотеатра()
        {
            InitializeComponent();
            context = new MyDBContext();
            SessionBox.ItemsSource = context.Sessions.Select(x => x.RoomName).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataSession.ItemsSource = context.Sessions.Where(x => x.RoomName == SessionBox.SelectedItem.ToString()).ToList();
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

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
