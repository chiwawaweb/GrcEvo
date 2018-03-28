using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrcEvo.DTO
{
    public class Pays
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Abrv { get; set; }
        public bool Actif { get; set; }

        //[Required]
        //[Column("DEVIS_ID")]
        /*
        public int DevisId { get; set; }
        [Required]
        [ForeignKey("DevisId")]
        public virtual Devis Devis { get; set; }
        */
    }
}
