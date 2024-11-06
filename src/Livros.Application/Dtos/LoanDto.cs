using System.ComponentModel.DataAnnotations;

namespace Livros.Application.Dtos;

public class LoanDto
{
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    public int Id { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    public int UserId { get; set; }
    public DateOnly LoanDate { get; set; }
    public DateOnly? ReturnDate { get; set; }
}