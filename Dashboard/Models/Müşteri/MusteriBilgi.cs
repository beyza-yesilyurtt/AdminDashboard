using Dashboard.Models.Personel;
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
        public MusteriBilgi ()
        {
            this.UrunBilgis = new HashSet<UrunBilgi>();
        }

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
        public double İletişimeGecenKisi { get; set; }


        public virtual ICollection<UrunBilgi> UrunBilgis { get; set; }
        public virtual ICollection<PersonelBilgileri> PersonelBilgileris { get; set; }
    }
}