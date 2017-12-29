using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_CodeFirst.Entity.Models
{
    [Table("Urunler")]
    public class Urun : Temel<long>
    {
        [Required]
        [StringLength(100)]
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; set; } = 0;
        public decimal? EskiFiyat { get; set; } = 0;
        public int KategoriId { get; set; }
        public virtual List<Urun> Urunler { get; set; } = new List<Urun>();

        [ForeignKey("KategoriId")]
        public virtual Kategori Kategori { get; set; }
        public virtual List<Dosya> Dosyalar { get; set; } = new List<Dosya>();

    }
}
