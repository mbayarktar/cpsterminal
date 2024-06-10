using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Crud.Models
{
    public class Cw000Warehouse
    {

        [Column("dep_referans")]
        [Display(Name = "dep_referans")]
        public int DepReferans { get; set; }

        [Column("dep_kodu")]
        [Display(Name = "dep_kodu")]
        public string? DepKodu { get; set; }

        [Column("dep_desc")]
        [Display(Name = "dep_desc")]
        public string? DepDesc { get; set; }
    }
}