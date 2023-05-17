using ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configurations
{
    public class ConcertConfiguration : IEntityTypeConfiguration<concerte>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<concerte> builder)

        {
            builder.HasKey(f => new { f.festivalFK, f.artisteFK,f.dateconcert });
            builder.HasOne<festival>(f=>f.Festival).WithMany(f=>f.Concerts).HasForeignKey(f => f.festivalFK);
            builder.HasOne<Artiste>(f => f.Artiste).WithMany(f => f.Concerts).HasForeignKey(f => f.artisteFK);
        }
    }
}
