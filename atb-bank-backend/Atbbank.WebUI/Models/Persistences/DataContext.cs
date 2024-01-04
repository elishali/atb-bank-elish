using Microsoft.EntityFrameworkCore;

namespace Atbbank.WebUI.Models.Persistences
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options)
            :base(options)
        {

        }

    }
}
