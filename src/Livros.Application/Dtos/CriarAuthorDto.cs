using System.ComponentModel.DataAnnotations;

namespace Livros.Application.Dtos;

public class CriarAuthorDto
{
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public string Name { get; set; }
}