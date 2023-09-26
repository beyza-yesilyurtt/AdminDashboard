using Dashboard.Models.Personel;
using Dashboard.Models.Satis;
using Dashboard.Models.Urunler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dashboard.Models.Müşteri
{
    public class MusteriBilgi
    {


        [Key]
        public int MusteriBilgiId { get; set; }

        [DisplayName("MÜŞTERİ İSMİ")]
        [StringLength(50, ErrorMessage = "Ürün ismi 50 karakterden fazla olamaz.")]
        public string MusteriIsim { get; set; }

        [DisplayName("MÜŞTERİ SOYİSİM")]
        [StringLength(50, ErrorMessage = "Ürün ismi 50 karakterden fazla olamaz.")]
        public string MusteriSoyisim { get; set; }

        [DisplayName("MÜŞTERİ MAİL")]
        public string MusteriMail { get; set; }

        [DisplayName("MÜŞTERİ TELEFON")]
        public string MusteriIletisim { get; set; }

        [DisplayName("ŞİRKET İSMİ")]
        public string SirketIsmi { get; set; }

        [DisplayName("SATILAN ÜRÜN")]
        public string SatılanUrun { get; set; }

        [DisplayName("İLETİŞİME GEÇEN KİŞİ")]
        public string IletisimeGecenKisi { get; set; }
        public List<UrunBilgi> urun {get; set;}
        public bool durum { get; set; }
        public int PersonelBilgiId { get; set; }
        public PersonelBilgileri personelBilgileri { get; set; }
        public List<UrunBilgi> urunBilgi { get; set; }
        public List<SatisBilgi> satisBilgi { get; set; }



    }
}