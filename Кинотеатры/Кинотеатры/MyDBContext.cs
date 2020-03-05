using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace Кинотератры
{
    public class MyDBContext : DbContext
    {
        public MyDBContext() : base ("DBConnection")
        {
        }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Session> Sessions { get; set; }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
