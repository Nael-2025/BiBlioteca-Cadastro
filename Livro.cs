using System;

public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string ISBN { get; set; }

    private int _quantidade;
    public int Quantidade
    {
        get => _quantidade;
        set
        {
            if (value < 0)
                throw new ArgumentException("A quantidade não pode ser negativa.");
            _quantidade = value;
        }
    }

    public Livro(string titulo, string autor, string isbn, int quantidade)
    {
        Titulo = titulo;
        Autor = autor;
        ISBN = isbn;
        Quantidade = quantidade;
    }
}