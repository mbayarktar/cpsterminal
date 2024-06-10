using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Crud.Models
{
    public class CwUsers
    {
        [Column("us_id")]
        [Display(Name = "us_id")]
        public int UsId { get; set; }

        [Column("us_kodu")]
        [Display(Name = "us_kodu")]
        public string? UsKodu { get; set; }
    }
}