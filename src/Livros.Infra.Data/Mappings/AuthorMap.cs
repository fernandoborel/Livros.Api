using Livros.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Livros.Infra.Data.Mappings;

public class AuthorMap : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK__Author__3214EC07C7141588");

        builder.ToTable("Author");

        builder.Property(e => e.Name).HasMaxLength(100);
    }
}