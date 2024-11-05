namespace Livros.Application.Dtos;

public class BookResponseDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public bool IsAvailable { get; set; }
    public string AuthorName { get; set; }
}
