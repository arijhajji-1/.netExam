using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class festival
    {
        public int capacite { get; set; }
        public int festivalId { get; set; }
        public string labelle { get; set; }
        public string ville { get; set; }
        public virtual ICollection<concerte> Concerts { get; set; }
    }
}
