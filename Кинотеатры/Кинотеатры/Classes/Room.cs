using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Кинотератры
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string CinemaName { get; set; }

        //public virtual ICollection<Session> Sessions { get; set; }
    }
}
