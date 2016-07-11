using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Web.Compilation;
using AutoTecEditor.Models;

namespace AutoTecEditor.DAL
{
    public class AutoTecContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Modification> Modifications { get; set; }

        public DbSet<ServicePlanEvent> ServicePlanEvents { get; set; }
        public DbSet<Service> Services { get; set; }

        public DbSet<WorkType> WorkTypes { get; set; }

        public AutoTecContext() : base("AutoTecContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}