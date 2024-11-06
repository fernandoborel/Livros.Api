using System.ComponentModel.DataAnnotations;

namespace Livros.Application.Dtos;

public class CriarLoanDto
{
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    public int UserId { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    public int BookId { get; set; }
}