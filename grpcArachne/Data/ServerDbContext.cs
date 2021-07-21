using grpcArachne.Models;
using Microsoft.EntityFrameworkCore;

namespace grpcArachne.Data
{
    public class ServerDbContext : DbContext
    {
        public ServerDbContext(DbContextOptions options) : base(options) { }
        public DbSet<DbT1Supplier> T1SupplierDbSet { get; set; }
        public DbSet<DbT2Barang> T2BarangDbSet { get; set; }
        public DbSet<DbTUserSupplier> TUserSupplierDbSet { get; set; }
        public DbSet<DbT3Satuan> T3SatuanDbSet { get; set; }
        public DbSet<DbT5SupplierSatuan> T5SupplierSatuanDbSet { get; set; }
        public DbSet<DbT5StokGudang> T5StokGudangDbSet { get; set; }
        public DbSet<DbT5CompanySatuan> T5CompanySatuanDbSet { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DbT1Supplier>(entity =>
            {
                entity.ToTable("T1Supplier");
                entity.HasKey(e => e.IdSupplier);
            });

            modelBuilder.Entity<DbT2Barang>(entity =>
            {
                entity.ToTable("T2Barang");
                entity.HasKey(e => e.IdBarang);
            });

            modelBuilder.Entity<DbT3Satuan>(entity =>
            {
                entity.ToTable("T3Satuan");
                entity.HasKey(e => e.IdSatuan);
            });

            modelBuilder.Entity<DbT5SupplierSatuan>(entity =>
            {
                entity.ToTable("T5SupplierSatuan");
                entity.HasKey(e => e.IdSatuan);
            });

            modelBuilder.Entity<DbTUserSupplier>(entity =>
            {
                entity.ToTable("TUserSupplier");
                entity.HasKey(e => e.IdUser);
            });

            modelBuilder.Entity<DbT5StokGudang>(entity =>
            {
                entity.ToTable("T5StokGudang");
                entity.HasKey(e => e.IdSatuan);
            });

            modelBuilder.Entity<DbT5CompanySatuan>(entity =>
            {
                entity.ToTable("T5CompanySatuan");
                entity.HasKey(e => e.IdCompany);
            });

        }
    }
}
