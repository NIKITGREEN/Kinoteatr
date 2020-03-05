using System;
using System.Collections.Generic;
using System.Text;

namespace Кинотератры
{
    public class Session
    {
        public int Id { get; set; }

        public string FilmName { get; set; }

        public string RoomName { get; set; }

        public string CinemaName { get; set; }

        public int Time { get; set; }

        public int Cost { get; set; }

        public string Date { get; set; }

        //public virtual Film Film { get; set; }
        //public virtual Room Room { get; set; }
        //public virtual Cinema Cinema { get; set; }

    }
}
