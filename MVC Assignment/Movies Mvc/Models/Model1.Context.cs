namespace MvcMovies.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MoviesEntities : DbContext
    {
        public MoviesEntities()
            : base("name=MoviesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<MovieTable> MovieTables { get; set; }
    }
}
