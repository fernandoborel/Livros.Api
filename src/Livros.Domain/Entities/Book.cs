﻿namespace Livros.Domain;

public class Book
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public int AuthorId { get; set; }

    public bool? IsAvailable { get; set; }

    public virtual Author Author { get; set; } = null!;

    public virtual ICollection<Loan> Loans { get; set; } = new List<Loan>();
}