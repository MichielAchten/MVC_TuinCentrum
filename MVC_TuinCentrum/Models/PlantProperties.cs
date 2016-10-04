﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_TuinCentrum.Models
{
    public class PlantProperties
    {
        [Range(0, 1000)]
        public decimal VerkoopPrijs { get; set; }
    }
}