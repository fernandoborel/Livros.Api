namespace Livros.Domain;

public class Book
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public bool IsAvailable { get; set; }

    public int AuthorId { get; set; }

    public virtual Author Author { get; set; } = null!;

    public virtual ICollection<LoanBook> LoanBooks { get; set; } = new List<LoanBook>();
}