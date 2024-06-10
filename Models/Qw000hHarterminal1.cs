using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Crud.Models
{
    public class Cw000Harterminal1
    {

        [Column("kayitno")]
        [Display(Name = "kayitno")]
        public int Kayitno { get; set; }

        [Column("userid")]
        [Display(Name = "userid")]
        public int Userid { get; set; }

        [Column("islem")]
        [Display(Name = "islem")]
        public short Islem { get; set; }

        [Column("idepo")]
        [Display(Name = "idepo")]
        public string? Idepo { get; set; }

        [Column("ilokasyon")]
        [Display(Name = "ilokasyon")]
        public string? Ilokasyon { get; set; }

        [Column("tdepo")]
        [Display(Name = "tdepo")]
        public string? Tdepo { get; set; }

        [Column("tlokasyon")]
        [Display(Name = "tlokasyon")]
        public string? Tlokasyon { get; set; }

        [Column("sevkemri")]
        [Display(Name = "sevkemri")]
        public string? Sevkemri { get; set; }

        [Column("serialno")]
        [Display(Name = "serialno")]
        public int Serialno { get; set; }

        [Column("sonuc")]
        [Display(Name = "sonuc")]
        public int Sonuc { get; set; }

        [Column("aciklama")]
        [Display(Name = "aciklama")]
        public string? Aciklama { get; set; }

        [Column("reserveno")]
        [Display(Name = "reserveno")]
        public string? Reserveno { get; set; }

    }
}