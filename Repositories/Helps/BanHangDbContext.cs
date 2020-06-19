namespace Repositories.Helps
{
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using Models;
    public partial class BanHangDbContext : DbContext 
    {
        public virtual DbSet<Models.TableModels.KhachHang> KhachHangs { get; set; }
        public virtual DbSet<Models.TableModels.Product> Products { get; set; }
        public virtual DbSet<Models.TableModels.User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<BanHangDbContext>(null);
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //base.OnModelCreating(modelBuilder);
        }
    }
}