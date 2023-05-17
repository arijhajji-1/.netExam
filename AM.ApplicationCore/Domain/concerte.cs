using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class concerte
    {
        public double cachet { get; set; }
        public DateTime dateconcert { get; set; }
        public int duree { get; set; } 
        public virtual Artiste Artiste { get; set; }
        [ForeignKey("artiste")]
        public int artisteFK { get; set; }
        public virtual festival Festival { get; set; }
        [ForeignKey("festival")]
        public int festivalFK { get; set; }



    }
}
