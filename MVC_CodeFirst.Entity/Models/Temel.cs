using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_CodeFirst.Entity.Models
{
    public abstract class Temel<T> : ITemel
    {
        [Key]
        public T id { get; set; }
        public bool AktifMi { get; set; } = true;
        public DateTime EklenmeTarihi { get; set; } = new DateTime();
    }
}
