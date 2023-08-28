using Dashboard.Models.Personel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dashboard.Models.ProjeTakip
{
    public class PersonelProje
    {
        public PersonelProje()
        {
            this.PersonelBilgileris = new HashSet<PersonelBilgileri>();
        }

        [Key]
        public int PersonelProjeId { get; set; }

        [DisplayName("PROJE İSMİ")]
        [StringLength(100, ErrorMessage = "Proje ismi 100 karakterden fazla olamaz.")]
        public string ProjeIsim { get; set; }

        [DisplayName("AÇIKLAMA")]
        public string ProjeAcıklama { get; set; }

        [DisplayName("PROJE BAŞLANGIÇ TARİHİ")]
        public DateTime ProjeBaslangıcTarihi { get; set; }

        [DisplayName("ÖNCELİK DURUMU")]
        [StringLength(25, ErrorMessage = "Öncelik durumu 25 karakterden fazla olamaz.")]
        public string PriorityStatus { get; set; }

        [DisplayName("TAMAMLANMA ORANI")]
        public int TamamlanmaOranı { get; set; }

        [DisplayName("TAMAMLANMA TARİHİ")]
        public DateTime TamamlanmaTarihi { get; set; }

        [DisplayName("PROJE DURUMU")]
        public bool ProjeDurumu { get; set; }
        public virtual ICollection<PersonelBilgileri> PersonelBilgileris { get; set; }
    }
}