using System.ComponentModel.DataAnnotations;

namespace Livros.Application.Dtos;

public class CriarUserDto
{
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    [Length(2, 100, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres.")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    [EmailAddress(ErrorMessage = "O campo {0} está em um formato inválido.")]
    public string? Email { get; set; }
}