using ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IServiceChanson : IService<chanson>
    {
   
    void GetMusicalStyle(stylemusicale st);
    IEnumerable<string> GetSongsTitles(Artiste a);
    }
}
