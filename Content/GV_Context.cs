using GestorVisitas.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace GestorVisitas.Data.Content
{
    public class GV_Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("FinalProyect_2022_0405");
        }

        public DbSet<Category> Categories { get; set; }
    }

}
