
namespace Demo.DAL.Data.Configuration
{
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(dept=>dept.id).UseIdentityColumn();
            builder.Property(dept => dept.Code).HasColumnType("varchar(20)");
            builder.Property(dept => dept.Name).HasColumnType("varchar(20)");

            builder.Property(dept => dept.CreatedOn).HasDefaultValueSql("GETDATEE()");
            builder.Property(dept => dept.LastModifiedOn).HasComputedColumnSql("GETDATEE()");


        }
    }
}
