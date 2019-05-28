using System;
using System.Collections.Generic;

namespace testApplication.Models
{
    public partial class Songs
    {
        public int SongId { get; set; }
        public int ArtistId { get; set; }
        public string SongName { get; set; }

        public Artists Artist { get; set; }
    }
}
