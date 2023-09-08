using Dashboard.Models.Müşteri;
using Dashboard.Models.Personel;
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
        public UrunBilgi()
        {
            this.MusteriBilgis = new HashSet<MusteriBilgi>();
            this.PersonelBilgileris = new HashSet<PersonelBilgileri>();
        }
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
        public double SatılanAdet{ get; set; }

       


        public virtual ICollection<MusteriBilgi> MusteriBilgis { get; set; }
        public virtual ICollection<PersonelBilgileri> PersonelBilgileris { get; set; }
    }
}