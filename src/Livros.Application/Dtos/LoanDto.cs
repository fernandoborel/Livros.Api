namespace Livros.Application.Dtos;

public class LoanDto
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public DateOnly LoanDate { get; set; }
    public DateOnly? ReturnDate { get; set; }
}