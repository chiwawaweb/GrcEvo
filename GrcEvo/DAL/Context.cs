using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using GrcEvo.DTO;
using GrcEvo.Migrations;

namespace GrcEvo.DAL
{
    public class Context : DbContext
    {
        public Context() : base("DefaultConnection")
        {
            Database.SetInitializer<Context>(new ContextInitializer());
        }

        public DbSet<Civilite> Civilites { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientCategorie> ClientsCategories { get; set; }
        public DbSet<Pays> Pays { get; set; }

        public class ContextInitializer : DropCreateDatabaseIfModelChanges<Context>
        {
            protected override void Seed(Context context)
            {
                base.Seed(context);
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Context, Configuration>());
        }

    }
}
