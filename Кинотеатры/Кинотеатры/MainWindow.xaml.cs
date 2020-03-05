using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Кинотератры
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User x = new User();
            if ((x.login == login.Text) && (x.password == password.Password))
            {
                using (var context1 = new MyDBContext())
                {
                    if (context1.Genres.Count() == 0)
                    {
                        List<Genre> genre = new List<Genre>()
                    {
                        new Genre(){ Name = "Боевик"},
                        new Genre(){ Name = "Драма"},
                        new Genre(){ Name = "Хорор"},
                        new Genre(){ Name = "Аниме"},
                        new Genre(){ Name = "Детектив"},
                        new Genre(){ Name = "Фентези"},
                    };

                        context1.Genres.AddRange(genre);
                        context1.SaveChanges();
                    }
                    if (context1.Actors.Count() == 0)
                    {
                        List<Actor> actors = new List<Actor>()
                    {
                        new Actor(){ FIO = "Александра Бортич"},
                        new Actor(){ FIO = "Машков Владимир"},
                        new Actor(){ FIO = "Хабенский Константин"},
                        new Actor(){ FIO = "Миронов Евгений"},
                        new Actor(){ FIO = "Петренко Игорь"},
                        new Actor(){ FIO = "Федоров Петр"},
                        new Actor(){ FIO = "Степанов Юрий"},
                        new Actor(){ FIO = "Пореченков Михаил"},
                    };
                        context1.Actors.AddRange(actors);
                        context1.SaveChanges();
                    }
                        
                    
                }

                Wind.кинотеатры = new Кинотеатры();
                Wind.залы = new Залы();
                Wind.информация_О_Фильме = new Информация_о_фильме();
                Wind.информация_Об_Кинотеатре = new Информация_об_кинотеатре();
                Wind.поиск = new Поиск();
                Wind.репертуар_Кинотеатра = new Репертуар_кинотеатра();
                Wind.сеансы = new Сеансы();
                Wind.фильмы = new Фильмы();

                Wind.кинотеатры.Show();
                this.Hide();

            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
