using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Кинотератры
{
    public class Film
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Director { get; set; }

        public string Production { get; set; }

        public int Length { get; set; }

        public int Year { get; set; }

        public  List<Session> Sessions { get; set; }
        public  List<Actor> Actors { get; set; }
        public  List<Genre> Genres { get; set; }


    }
}
