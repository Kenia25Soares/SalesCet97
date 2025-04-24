using Microsoft.EntityFrameworkCore;
using SalesCet97.Web.Data.Entities;

namespace SalesCet97.Web.Data
{
    public class DataContext : DbContext
    {

        //coloco dentro das opções o meu datacontex que eu vou fazer e passo para a base, estou a injetar o meu datacontex dentro da base e passar para lá.
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }
    }
}
