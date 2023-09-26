using Dashboard.Models.Satis;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dashboard.Models.GenelSatis
{
    public class genelSatis
    {
        [Key]
        public int genelSatisId { get; set; }
        public bool durum { get; set; }
        public List <SatisBilgi> satisBilgi { get; set; }

    }
}