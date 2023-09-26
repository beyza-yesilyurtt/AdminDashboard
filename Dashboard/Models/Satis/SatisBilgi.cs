using Dashboard.Models.Müşteri;
using Dashboard.Models.Personel;
using Dashboard.Models.Urunler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dashboard.Models.Satis
{
    public class SatisBilgi
    {
        
        [Key]
        public int SatısId { get; set; }

        [DisplayName("SATIŞ DURUMU")]
        public bool durum { get; set; }
        public string satisTakip { get; set; }

        [DisplayName("SATIŞ KAZANÇ")]
        public double kazanc { get; set; }

        [DisplayName("SATIŞ TARİHİ")]
        public string SatisTarih { get; set; }

        [DisplayName("SATILAN ADET")]
        public string SatısAdet { get; set; }
        public int MusteriBilgiId { get; set; }
        public MusteriBilgi musteriBilgi { get; set; }
        public int PersonelBilgiId { get; set; }
        public PersonelBilgileri personelBilgileri { get; set; }
        public List<UrunBilgi> urunBilgi { get; set; }

    }
}