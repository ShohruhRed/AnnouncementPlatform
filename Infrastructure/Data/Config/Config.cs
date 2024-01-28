using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Infrastructure.Data.Config
{
    internal class AnnounceConfiguration : IEntityTypeConfiguration<Announce>
    {
        public void Configure(EntityTypeBuilder<Announce> builder)
        {
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.Header).IsRequired();
            builder.Property(p => p.Text).IsRequired();
            builder.Property(p => p.Source).IsRequired();
            builder.Property(p => p.PublicationDate).IsRequired();
            builder.Property(p => p.Location).IsRequired();

            builder.HasOne(b => b.AnnounceType).WithMany()
                .HasForeignKey(p => p.ProductTypeId);
           
        }
    }
}
