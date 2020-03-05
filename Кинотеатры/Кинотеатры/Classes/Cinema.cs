using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Кинотератры
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public string CinemaName { get; set; }

        public string Adress { get; set; }

        public string Phone { get; set; }

        public string Transport { get; set; }

       // public virtual ICollection<Room> Rooms { get; set; }


    }
}
