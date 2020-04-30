using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Canciones_1.Models
{
    public class SongDbContext: DbContext
    {
        public SongDbContext():base("MyConnection")

        {

        }

        public DbSet<Song> Songs { get; set; }

    }
}