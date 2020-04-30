using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Canciones_1.Models
{
    public class Song
    {
        public int Id { get; set; }

        public string Artist { get; set; }

        public string SongName { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public string Duration { get; set; }


    }
}