
namespace mbcPhone.Models
{
    using System.Data.Entity;

    public class DataContext:DbContext 
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<mbcPhone.Models.Phone> Phones { get; set; }
    }

}