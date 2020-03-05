using System;
using System.Collections.Generic;
using System.Text;

namespace Кинотератры
{
    public class Genre
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual Film Film { get; set; }
    }
}
