using System.ComponentModel.DataAnnotations;

namespace Livros.Application.Dtos;

public class CriarBookDto
{
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public string? Title { get; set; }
    
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public int AuthorId { get; set; }
    
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public bool? IsAvailable { get; set; }
}