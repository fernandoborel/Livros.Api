using Livros.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

public class BookMap : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasKey(e => e.Id)
            .HasName("PK__Book__3214EC0704DF0778");

        builder.ToTable("Book");

        builder.Property(e => e.IsAvailable)
            .HasColumnName("IsAvailable")
            .HasDefaultValue(true);

        builder.Property(e => e.Title)
            .HasMaxLength(200);

        builder.HasOne(d => d.Author)
            .WithMany(p => p.Books)
            .HasForeignKey(d => d.AuthorId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__Book__AuthorId__398D8EEE");
    }
}