using ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IServiceArtiste:IService<Artiste>
    {

        double PlusHautCachet(festival f);
        int NbNationnalite(festival f, string nationnalite);
    }

}
