using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LABIV_2
{
    public class Zajecia
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Column("NazwaPrzedmoitu")]
        [MinLength(1)]
        public string Nazwa { get; set; }
        public string Sala { get; set; }
        public DateTime Godzina { get; set; }
        public int IloscObecnych { get; set; }
    }
}
