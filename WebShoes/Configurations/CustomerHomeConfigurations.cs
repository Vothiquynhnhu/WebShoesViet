using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShoes.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebShoes.Configurations
{
    public class CustomerHomeConfigurations : IEntityTypeConfiguration<CustomerHome>
    {
        public void Configure(EntityTypeBuilder<CustomerHome> builder)
        {
            builder.ToTable("CustomerHome");
            builder.HasKey(t => new { t.CustomerHomeId });
        }
    }
}
