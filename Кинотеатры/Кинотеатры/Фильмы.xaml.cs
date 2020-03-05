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
    /// Логика взаимодействия для Фильмы.xaml
    /// </summary>
    public partial class Фильмы : Window
    {
        MyDBContext context;
        private static List<Film> GetFilms(MyDBContext context)
        {
   //         MyDBContext context = new MyDBContext();
            return context.Films.Select(h => h).ToList<Film>();
        }
        private static List<Genre> GetSuperGenre(MyDBContext context)
        {
   //         MyDBContext context = new MyDBContext();
            List<Genre> genre = context.Genres.Select(h => h).ToList<Genre>();
            return genre;
        }
        private static Dictionary<string, Genre> DicGenre;
        private static Dictionary<string, Actor> DicActor;
        private static List<string> GetGenre(MyDBContext context)
        {
            List<string> strlist = new List<string>();
            DicGenre = new Dictionary<string, Genre>();
       //     MyDBContext context = new MyDBContext();
            List<Genre> genre = context.Genres.Select(h => h).ToList<Genre>();
            foreach (var item in genre)
            {       
                 DicGenre.Add(item.Name, item);
                strlist.Add(item.Name);
            }
            return strlist;
        }

        private static List<string> GetActor(MyDBContext context)
        {
            List<string> strlist = new List<string>();
            DicActor = new Dictionary<string, Actor>();
       //     MyDBContext context = new MyDBContext();
            List<Actor> actor = context.Actors.Select(h => h).ToList<Actor>();
            foreach (var item in actor)
            {
                DicActor.Add(item.FIO, item);
                strlist.Add(item.FIO);
            }
            return strlist;
        }
        public Фильмы()
        {
            InitializeComponent();
            context = new MyDBContext();
            //          using (var context = new MyDBContext())
            FilmsData.ItemsSource = GetFilms(context);// context.Films.ToList();;
            GenreBox.ItemsSource = GetGenre(context); //context.Genres.Select(x => x.Name).ToList();
            ActorBox.ItemsSource = GetActor(context);///context.Actors.Select(x => x.FIO).ToList();
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
            string[] genreMass = genre.Text.ToString().Split(' ');
            List<Genre> genresList = new List<Genre>();
            List<Actor> actorsList = new List<Actor>();
            foreach (var item in genreMass)
            {
                if (item.Length > 2)
                {
                    Genre genres = new Genre();
                    genres = DicGenre[item];
                    genresList.Add(genres);
                }

            }
            foreach (string item in ActorList.Items)
            {
                if (item.Length > 2)
                {
                    Actor actor = new Actor();
                    actor = DicActor[item];
                    actorsList.Add(actor);
                }

            }
            Film film = new Film()
            {
                Name = name.Text,
                Director = rejisor.Text,
                Genres = genresList,
                Actors = actorsList,
                Length = Convert.ToInt32(time.Text),
                Year = Convert.ToInt32(year.Text),
                Production = rejisor.Text
            };
   //         using (var context = new MyDBContext())
            {
                context.Films.Add(film);
                context.SaveChanges();
                FilmsData.ItemsSource = GetFilms(context);
            }
        }

        private void GenreBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            genre.Text += GenreBox.Text + " ";
        }

        private void ActorBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ActorList.Items.Add(ActorBox.Text);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (FilmsData.SelectedItem != null)
            {
                Film Cindex = FilmsData.SelectedItem as Film;
                context.Films.Remove(context.Films.Where(x => x.Id == Cindex.Id).FirstOrDefault());
                context.SaveChanges();
                FilmsData.ItemsSource = context.Films.ToList();
            }
        }
    }
}
