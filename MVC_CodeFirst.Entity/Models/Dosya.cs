using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_CodeFirst.Entity.Models
{
    [Table("Dosyalar")]
    public class Dosya : Temel<long>
    {
        public string DosyaYolu { get; set; }
        public string Uzanti { get; set; }
        public long? UrunId { get; set; }
        public int? KategoriId { get; set; }


        [ForeignKey("UrunId")]
        public Urun Urun { get; set; }

        [ForeignKey("KategoriId")]
        public virtual Kategori Kategori { get; set; }

    }
}
