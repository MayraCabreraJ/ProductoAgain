namespace ProyectoBackEnd.Models
{
using System.Data.Entity;

    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<ProyectoBackEnd.Models.Product> Productoes { get; set; }
    }
}