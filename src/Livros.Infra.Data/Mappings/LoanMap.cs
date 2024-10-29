using Livros.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Livros.Infra.Data.Mappings;

public class LoanMap : IEntityTypeConfiguration<Loan>
{
    public void Configure(EntityTypeBuilder<Loan> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK__Loan__3214EC07F11BFFEB");

        builder.ToTable("Loan");

        builder.HasOne(d => d.User).WithMany(p => p.Loans)
            .HasForeignKey(d => d.UserId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__Loan__UserId__3F466844");

        builder.HasMany(d => d.Books).WithMany(p => p.Loans)
            .UsingEntity<Dictionary<string, object>>(
                "LoanBook",
                r => r.HasOne<Book>().WithMany()
                    .HasForeignKey("BookId")
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LoanBook__BookId__4316F928"),
                l => l.HasOne<Loan>().WithMany()
                    .HasForeignKey("LoanId")
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LoanBook__LoanId__4222D4EF"),
                j =>
                {
                    j.HasKey("LoanId", "BookId").HasName("PK__LoanBook__2C84D877A8ABA48D");
                    j.ToTable("LoanBook");
                });
    }
}