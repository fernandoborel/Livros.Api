using Livros.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

public class LoanBookMap : IEntityTypeConfiguration<LoanBook>
{
    public void Configure(EntityTypeBuilder<LoanBook> builder)
    {
        builder.ToTable("LoanBooks");

        builder.HasKey(lb => new { lb.LoanId, lb.BookId });

        // relacionamento com Loan
        builder
            .HasOne(lb => lb.Loan)
            .WithMany(l => l.LoanBooks)
            .HasForeignKey(lb => lb.LoanId);

        // relacionamento com Book
        builder
            .HasOne(lb => lb.Book)
            .WithMany(b => b.LoanBooks)
            .HasForeignKey(lb => lb.BookId);
    }
}