using Livros.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Livros.Infra.Data.Mappings;

public class UserMap : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK__User__3214EC072EE889BA");

        builder.ToTable("User");

        builder.HasIndex(e => e.Email, "UQ__User__A9D105345A17C647").IsUnique();

        builder.Property(e => e.Email).HasMaxLength(100);
        builder.Property(e => e.Name).HasMaxLength(100);
    }
}