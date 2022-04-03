using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShoes.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebShoes.Configurations
{
    public class CategoriesHomeConfigurations : IEntityTypeConfiguration<CategoriesHome>
    {
        public void Configure(EntityTypeBuilder<CategoriesHome> builder)
        {
            builder.ToTable("CategoriesHome");
            builder.HasKey(t => new { t.CategoriesHomeId });
        }
    }
}
