using System;
using System.Collections.Generic;

namespace testApplication.Models
{
    public partial class Artists
    {
        public Artists()
        {
            Songs = new HashSet<Songs>();
        }

        public int ArtistId { get; set; }
        public string ArtistName { get; set; }

        public ICollection<Songs> Songs { get; set; }
    }
}
