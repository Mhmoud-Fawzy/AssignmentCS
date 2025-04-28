using EF04.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF04.Data.Configurations
{
    internal class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).UseIdentityColumn();

            builder.Property<string>("Address")
                      .HasColumnType("varchar(50)")
                      .HasDefaultValue("Cairo");//Column Not In Model
            builder.OwnsOne(e => e.DetailedAddress);
        }
    }
}
