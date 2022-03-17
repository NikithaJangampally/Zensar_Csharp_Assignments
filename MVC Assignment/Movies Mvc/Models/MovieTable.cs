namespace MvcMovies.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MovieTable
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string ReleaseDate { get; set; }
    }
}
