using MVC_CodeFirst.Entity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCodeFirst.DAL
{
    public class MyContext : DbContext
    {

        public MyContext()
            : base("name=MyCon")
        { }

        public virtual DbSet<Kategori> Kategoriler { get; set; }
        public virtual DbSet<Urun> Urunler { get; set; }
        public virtual DbSet<Dosya> Dosyalar { get; set; }
    }
}
