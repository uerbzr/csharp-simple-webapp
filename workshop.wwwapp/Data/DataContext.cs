using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using workshop.wwwapp.Models;

namespace workshop.wwwapp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Car> Cars { get; set; }
    }
}
