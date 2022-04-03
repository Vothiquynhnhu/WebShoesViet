﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShoes.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebShoes.Configurations
{
    public class SliderHomeConfigurations : IEntityTypeConfiguration<SliderHome>
    {
        public void Configure(EntityTypeBuilder<SliderHome> builder)
        {
            builder.ToTable("SliderHome");
            builder.HasKey(t => new { t.SliderId });

        }
    }
}
