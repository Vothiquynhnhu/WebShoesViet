using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShoes.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebShoes.Configurations
{
    public class FeatureHomeConfigurations : IEntityTypeConfiguration<FeatureHome>
    {
        public void Configure(EntityTypeBuilder<FeatureHome> builder)
        {
            builder.ToTable("FeatureHome");
            builder.HasKey(t => new { t.FeatureHomeId });

        }
    }
}
