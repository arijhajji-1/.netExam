using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ServiceChanson : Service<chanson>, IServiceChanson
    {
        public ServiceChanson(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public void GetMusicalStyle(stylemusicale st)
        {
            var req = GetMany(c => c.stylemusicale == st).Select(c => c.Artiste).SelectMany(a => a.Concerts);
            foreach (var item in req)
                Console.WriteLine("Date: " + item.dateconcert + "Ville: " + item.Festival.ville);
        }

        public IEnumerable<string> GetSongsTitles(Artiste a)
        {
            return GetMany(c => (DateTime.Now - c.datesortie).TotalDays < 730 && c.Artiste == a)
                .OrderBy(c => c.vueyt).Take(5).Select(c => c.titre);
        }
    }

}
