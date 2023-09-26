using Dashboard.Models.Müşteri;
using Dashboard.Models.ProjeTakip;
using Dashboard.Models.Satis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dashboard.Models.Personel
{
    public class PersonelBilgileri
    {

        [Key]
        public int PersonelBilgiId { get; set; }

        [DisplayName("MAİL ADRESİ")]
        public string Mail { get; set; }

        [DisplayName("ŞİFRE")]
        [StringLength(25, ErrorMessage = "Şifre 25 karakterden fazla olamaz.")]
        public string Sifre { get; set; }

        [DisplayName("YETKİ")]
        [StringLength(15, ErrorMessage = "Maximum uzunluk 15 karakterden fazla olamaz.")]
        public string Yetki { get; set; }

        [DisplayName("İSİM")]
        [StringLength(25, ErrorMessage = "İsim 25 karakterden fazla olamaz.")]
        public string İsim { get; set; }

        [DisplayName("SOYİSİM")]
        [StringLength(25, ErrorMessage = "Soyisim 25 karakterden fazla olamaz.")]
        public string Soyisim { get; set; }

        [DisplayName("PERSONEL GÖRSELİ")]
        public string PersonelResim { get; set; }

        [DisplayName("TC KİMLİK NO")]
        [StringLength(11, ErrorMessage = "TC Kimlik No 11 karakterden fazla olamaz.")]
        public string TCND { get; set; }

        [DisplayName("DEPARTMAN")]
        [StringLength(25, ErrorMessage = "Maximum uzunluk 25 karakterden fazla olamaz.")]
        public string Departman { get; set; }

        [DisplayName("GÖREV")]
        [StringLength(25, ErrorMessage = "Maximum uzunluk 15 karakterden fazla olamaz.")]
        public string Görev { get; set; }

        [DisplayName("AÇIKLAMA")]
        public string PozisyonAcıklama { get; set; }

        [DisplayName("TELEFON NUMARASI")]
        [StringLength(15, ErrorMessage = "Maximum uzunluk 12 karakterden fazla olamaz.")]
        public string TelefonNumarası { get; set; }

        [DisplayName("ADRES BİLGİLERİ")]
        public string AdresBilgi { get; set; }

        [DisplayName("DOĞUM TARİHİ")]
        public DateTime DogumTarihi { get; set; }

        [DisplayName("İŞE BAŞLAMA TARİHİ")]
        public DateTime IseBaslamaTarihi { get; set; }
        public bool durum { get; set; }
        public List<MusteriBilgi> musteriBilgi { get; set; }
        public List<SatisBilgi> satisBilgi { get; set; }



    }
}