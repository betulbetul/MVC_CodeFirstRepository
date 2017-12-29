using MVC_CodeFirst.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCodeFirst.BLL.Repository
{

    public class UrunRepo : RepositoryBase<Urun, long> { }
    public class KategoriRepo : RepositoryBase<Kategori, int> { }
    public class DosyaRepo : RepositoryBase<Dosya, long> { }


}
