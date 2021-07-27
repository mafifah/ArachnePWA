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
        public DbSet<DbT0JenisSupplier> T0JenisSupplierDbSet { get; set; }
        public DbSet<DbT0Company> T0CompanySbSet { get; set; }
        public DbSet<DbT0Kurs> T0KursDbSet { get; set; }
        public DbSet<DbT0DivisiBarang> T0DivisiBarangDbSet { get; set; }
        public DbSet<DbT1SubDivisiBarang> T1SubDivisiBarangDbSet { get; set; }
        public DbSet<DbT0KategoriBarang> T0KategoriBarangDbSet { get; set; }
        public DbSet<DbT1SubKategoriBarang> T1SubKategoriBarangDbSet { get; set; }
        public DbSet<DbT6PenawaranPembelian> T6PenawaranPembelianDbSet { get; set; }
        public DbSet<DbT7PenawaranPembelian> T7PenawaranPembelianDbSet { get; set; }
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
                entity.HasKey(e => new { e.IdSatuan, e.IdGudang });
            });

            modelBuilder.Entity<DbT5CompanySatuan>(entity =>
            {
                entity.ToTable("T5CompanySatuan");
                entity.HasKey(e => e.IdCompany);
            });

            modelBuilder.Entity<DbT0JenisSupplier>(entity =>
            {
                entity.ToTable("T0JenisSupplier");
                entity.HasKey(e => e.IdJenisSupplier);
            });
            modelBuilder.Entity<DbT0Company>(entity =>
            {
                entity.ToTable("T0Company");
                entity.HasKey(e => e.IdCompany);
            });
            modelBuilder.Entity<DbT0Kurs>(entity =>
            {
                entity.ToTable("T0Kurs");
                entity.HasKey(e => e.IdKurs);
            });
            modelBuilder.Entity<DbT0DivisiBarang>(entity =>
            {
                entity.ToTable("T0DivisiBarang");
                entity.HasKey(e => e.IdDivisiBarang);
            });
            modelBuilder.Entity<DbT1SubDivisiBarang>(entity =>
            {
                entity.ToTable("T1SubDivisiBarang");
                entity.HasKey(e => e.IdSubDivisiBarang);
            });
            modelBuilder.Entity<DbT0KategoriBarang>(entity =>
            {
                entity.ToTable("T0KategoriBarang");
                entity.HasKey(e => e.IdKategoriBarang);
            });
            modelBuilder.Entity<DbT1SubKategoriBarang>(entity =>
            {
                entity.ToTable("T1SubKategoriBarang");
                entity.HasKey(e => e.IdSubKategoriBarang);
            });
            modelBuilder.Entity<DbT6PenawaranPembelian>(entity =>
            {
                entity.ToTable("T6PenawaranPembelian");
                entity.HasKey(e => e.IdPenawaranPembelian);
            });
            modelBuilder.Entity<DbT7PenawaranPembelian>(entity =>
            {
                entity.ToTable("T7PenawaranPembelian");
                entity.HasKey(e => e.IdDetilPenawaranPembelian);
            });

        }
    }
}
