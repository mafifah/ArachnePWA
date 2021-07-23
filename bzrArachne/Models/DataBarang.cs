namespace bzrArachne.Models
{
    public class DataBarang
    {
        public long IdBarang { get; set; }
        public long IdDivisiBarang { get; set; }
        public long IdSubDivisiBarang { get; set; }
        public long IdKategoriBarang { get; set; }
        public long IdSubKategoriBarang { get; set; }
        public long IdSupplier { get; set; }
        public long IdJenisSupplier { get; set; }
        public long IdSatuan { get; set; }
        public string Nama { get; set; }
        public string Satuan { get; set; }
        public int Stok { get; set; }
        public long Minimum { get; set; }
        public long Maksimum { get; set; }
        public string NamaSupplier { get; set; }
        public string AlamatSupplier { get; set; }
    }
}
