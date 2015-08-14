using System.Data.Entity;
using DevRu.EF.DomainModels;

namespace DevRu.EF
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext()
            : base("DevRuConnection") { }

        public DbSet<Company> Companies { get; set; }
    }
}
