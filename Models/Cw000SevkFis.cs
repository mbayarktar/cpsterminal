using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Crud.Models
{
    public class Cw000Sevkfis
    {

        [Column("sevk_referans")]
        [Display(Name = "sevk_referans")]
        public int SevkReferans { get; set; }

        [Column("sevk_tris")]
        [Display(Name = "sevk_tris")]
        public short SevkTris { get; set; }

        [Column("sevk_type")]
        [Display(Name = "sevk_type")]
        public byte SevkType { get; set; }

        [Column("sevk_fisno")]
        [Display(Name = "sevk_fisno")]
        public string? SevkFisno { get; set; }
    }
}