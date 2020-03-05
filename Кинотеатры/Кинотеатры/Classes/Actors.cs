using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Кинотератры
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string FIO { get; set; }

        public string FilmName { get; set; }

        public virtual Film Film { get; set; }
    }
}
