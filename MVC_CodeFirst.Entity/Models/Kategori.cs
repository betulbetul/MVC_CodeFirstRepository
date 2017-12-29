using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_CodeFirst.Entity.Models
{
    [Table("Kategoriler")]
    public class Kategori : Temel<int>
    {
        [Required]
        [StringLength(50)]
        public string KategoriAdi { get; set; }
        public string Aciklama { get; set; }
        //Self Join işlemi
        public int? UstKategoriId { get; set; }

        [ForeignKey("UstKategoriId")]
        public virtual Kategori UstKategori { get; set; }

        public virtual List<Dosya> Dosyalar { get; set; } = new List<Dosya>();
    }
}
