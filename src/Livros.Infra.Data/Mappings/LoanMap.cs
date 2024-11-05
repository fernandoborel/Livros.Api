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

        builder.HasOne(d => d.User)
            .WithMany(p => p.Loans)
            .HasForeignKey(d => d.UserId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__Loan__UserId__3F466844");

        // Mapeamento da relação muitos-para-muitos
        builder.HasMany(d => d.LoanBooks)
            .WithOne(lb => lb.Loan)
            .HasForeignKey(lb => lb.LoanId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__LoanBook__LoanId__4222D4EF");

        // Mapeamento da relação entre LoanBook e Book
        builder.Navigation(l => l.LoanBooks)
            .UsePropertyAccessMode(PropertyAccessMode.Property);
    }
}