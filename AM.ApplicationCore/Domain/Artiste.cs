using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class Artiste
    {
        [Key]
        public int artisteId { get; set; }
        public string contact { get; set; }
        public DateTime datedenaissance { get; set; }
        public string nationalite { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        [NotMapped]
        public string FullName { get { return nom + " " + prenom; } }
        public virtual ICollection<concerte> Concerts { get; set; }
        public virtual ICollection<chanson> Chansons { get; set; }

    }
}
