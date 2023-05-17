using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ServiceArtiste :Service<Artiste>, IServiceArtiste
    {
        public ServiceArtiste(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public int NbNationnalite(festival f, string nationnalite)
        {
            return f.Concerts.Select(c => c.Artiste).Where(a => a.nationalite == nationnalite).Count();
        }

        public double PlusHautCachet(festival f)
        {
            return f.Concerts.Where(c => c.dateconcert.Year == DateTime.Now.Year).Max(c => c.cachet);

        }
  


    }
}
