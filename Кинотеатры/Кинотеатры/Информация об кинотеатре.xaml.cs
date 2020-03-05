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
    /// Логика взаимодействия для Информация_об_кинотеатре.xaml
    /// </summary>
    public partial class Информация_об_кинотеатре : Window
    {
        MyDBContext context;
        public Информация_об_кинотеатре()
        {
            InitializeComponent();
            context = new MyDBContext();
            KinoBox.ItemsSource = context.Cinemas.Select(x => x.CinemaName).ToList();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (KinoBox.SelectedItem != null)
            {
                DataKino.ItemsSource = context.Cinemas.Where(x => x.CinemaName == KinoBox.SelectedItem.ToString()).ToList();
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

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
