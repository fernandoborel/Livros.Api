namespace Livros.Domain;

public class LoanBook
{
    public int LoanId { get; set; }
    public virtual Loan Loan { get; set; } = null!;

    public int BookId { get; set; }
    public virtual Book Book { get; set; } = null!;
}