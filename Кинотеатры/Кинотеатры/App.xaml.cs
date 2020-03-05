using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Кинотератры
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    /// 
    public class User
    {
        public string login = "admin";
        //Dictionary<int, string> login;
        public string password = "admin";
        //Dictionary<int, string> password;
    }
    public static class Wind
    {
        public static Кинотеатры кинотеатры;
        public static Залы залы;
        public static Информация_о_фильме информация_О_Фильме;
        public static Информация_об_кинотеатре информация_Об_Кинотеатре;
        public static Поиск поиск = new Поиск();
        public static Репертуар_кинотеатра репертуар_Кинотеатра;
        public static Сеансы сеансы;
        public static Фильмы фильмы;
     //   public static MyDBContext context;

        public static void OpenЗалы(Window window)
        {
            window.Hide();
            Wind.залы.Show();
        }

        public static void OpenИнформация_о_фильме(Window window)
        {
            window.Hide();
            Wind.информация_О_Фильме.Show();
        }
        public static void OpenИнформация_об_кинотеатре(Window window)
        {
            window.Hide();
            Wind.информация_Об_Кинотеатре.Show();
        }
        public static void OpenПоиск(Window window)
        {
            window.Hide();
            Wind.поиск.Show();
        }
        public static void OpenРепертуар_кинотеатра(Window window)
        {
            window.Hide();
            Wind.репертуар_Кинотеатра.Show();
        }
        public static void OpenСеансы(Window window)
        {
            window.Hide();
            Wind.сеансы.Show();
        }
        public static void OpenФильмы(Window window)
        {
            window.Hide();
            Wind.фильмы.Show();
        }
        public static void OpenКинотеатры(Window window)
        {
            window.Hide();
            Wind.кинотеатры.Show();
        }
    }


    public partial class App : Application
    {
    }
}
