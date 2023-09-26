using Dashboard.Models.Müşteri;
using Dashboard.Models.Personel;
using Dashboard.Models.Satis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dashboard.Models.Urunler
{
    public class UrunBilgi
    {
       
        [Key]
        public int UrunBilgiId { get; set; }

        [DisplayName("ÜRÜN İSMİ")]
        [StringLength(50, ErrorMessage = "Ürün ismi 50 karakterden fazla olamaz.")]
        public string UrunIsim { get; set; }

        [DisplayName("ÜRÜN AÇIKLAMASI")]
        public string UrunAciklama { get; set; }

        [DisplayName("ÜRÜN FİYATI")]
        public double UrunFiyat { get; set; }

        [DisplayName("SATILAN ADET")]
        public double ToplamSatılanAdet{ get; set; }
        public bool durum { get; set; }
        public List<SatisBilgi> satisBilgi { get; set; }
        public List<MusteriBilgi> musteriBilgi { get; set; }






    }
}