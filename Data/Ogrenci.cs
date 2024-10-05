using System.ComponentModel.DataAnnotations;

namespace DBProject.Data
{
    public class Ogrenci
    {
        [Key]
        public int OgrenciId { get; set; }
        public string? OgrenciAd { get; set; }
        public string? OgrenciSoyad { get; set; }
        public string? Eposta { get; set; }
        public int Telofon { get; set; }
    }
}