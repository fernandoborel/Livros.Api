namespace Livros.Domain;

public class Loan
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public DateOnly LoanDate { get; set; }

    public DateOnly? ReturnDate { get; set; }

    public virtual User User { get; set; } = null!;

    public virtual ICollection<LoanBook> LoanBooks { get; set; } = new List<LoanBook>();
}