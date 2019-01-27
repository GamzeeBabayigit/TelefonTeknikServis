using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace EntityProject
{
    class musteriler
    {

        public musteriler()
        {
            cihazlars = new List<cihazlar>();
        }

        [Key]
        public int musteriId { get; set; }
        public string adsoyad { get; set; }
        public string tc { get; set; }
        public string telefon { get; set; }

        public List <cihazlar> cihazlars { get; set; }  //müsteri tekil onun cihazları gibi düşünerek cihazlars yapıldı 
    }
}
