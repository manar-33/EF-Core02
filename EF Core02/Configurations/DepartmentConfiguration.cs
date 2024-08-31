using EF_Core02.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core02.Configurations
{
    internal class DepartmentConfigration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(D => D.Id);
            builder.Property(D => D.Name)
                   .IsRequired()
                   .HasMaxLength(20);

        }
    }
}
