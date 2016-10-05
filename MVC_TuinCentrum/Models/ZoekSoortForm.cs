using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_TuinCentrum.Models
{
    public class ZoekSoortForm
    {
        [Display(Name = "Begin soortnaam:")]
        [Required(ErrorMessage = "Verplicht")]
        public string BeginNaam { get; set; }
        public List<Soort> Soorten { get; set; }
    }
}