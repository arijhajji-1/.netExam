using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class chanson
    {
        [Key]
        public int chansonId { get; set; }
        [DataType(DataType.Date)]
        public DateTime datesortie { get; set; }
        public int duree { get; set; }
        [MaxLength(12)]
        [MinLength(3)]
        public string titre { get; set; }
        [Range(0, int.MaxValue , ErrorMessage ="erreur")]
        
        public int vueyt { get; set; }
        public stylemusicale stylemusicale { get; set; }
        [ForeignKey("Artiste")]
        public int artisteFK { get; set; }
        public virtual Artiste Artiste { get; set; }
    }
}
