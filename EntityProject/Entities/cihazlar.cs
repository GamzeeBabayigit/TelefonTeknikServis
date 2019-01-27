using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace EntityProject
{
    class cihazlar
    {
        [Key]
        public int cihazId { get; set; }
        public string marka { get; set; }
        public string model { get; set; }
        public string serino { get; set; }
        public string sikayet { get; set; }
        public string yapilanislem { get; set; }
        public string ucret { get; set; }
        public string cihazsahibi { get; set; }
        public DateTime kayit_tarihi { get; set; }
        public musteriler musteriler { get; set; }


    }
}
