using System.ComponentModel.DataAnnotations;

namespace Livros.Application.Dtos;

public class CriarAuthorDto
{
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    [Length(3, 100, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres.")]
    public string? Name { get; set; }
}