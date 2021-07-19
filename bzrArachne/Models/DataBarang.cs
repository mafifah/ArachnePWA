namespace bzrArachne.Models
{
    public class DataBarang
    {
        public long IdBarang { get; set; }
        public string Nama { get; set; }
        public string Satuan { get; set; }
        public int Stok { get; set; }
        public long Minimum { get; set; }
        public long Maksimum { get; set; }
    }
}
