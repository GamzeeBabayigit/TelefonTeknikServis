using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
namespace EntityProject
{
    class iadeedilenler:cihazlar
    {
        [Key]
        public int iadeId { get; set; }
        public DateTime iade_tarihi { get; set; }


       //   public string marka { get; set; }
       //   public string model { get; set; }
       //   public string serino { get; set; }
       //   public string sikayet { get; set; }
       //   public string cihaz_sahibi { get; set; }
    }
}
