using System.ComponentModel.DataAnnotations;

namespace Livros.Application.Dtos;

public class CriarBookDto
{
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    [Length(2, 100, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres.")]
    public string? Title { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public int AuthorId { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public bool? IsAvailable { get; set; }
}