using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrcEvo.DTO
{
    public class Client
    {
        public int Id { get; set; }
        public bool Prospect { get; set; }
        public string Code { get; set; }
        public string Societe { get; set; }
        public string Civilite { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public string TypeTel1 { get; set; }
        public string PrefTel1 { get; set; }
        public string NumTel1 { get; set; }
        public string TypeTel2 { get; set; }
        public string PrefTel2 { get; set; }
        public string NumTel2 { get; set; }
        public string TypeTel3 { get; set; }
        public string PrefTel3 { get; set; }
        public string NumTel3 { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Remarques { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ICollection<Pays> Pays { get; set; }
        public ICollection<ClientCategorie> ClientsCategories { get; set; }
    }
}
