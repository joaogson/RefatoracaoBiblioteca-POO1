using System;

namespace BibliotecaMinha;

public class Livro
{
    public int Id { get; private set; }
    public static int count=0;
    public string Titulo { get; private set; }
    public string Autor { get; private set; }
    public bool Disponivel { get; private set; }


    public Livro(string titulo, string autor)
    {
        if(string.IsNullOrEmpty(titulo))
           throw new ArgumentNullException("O livro deve ter um titulo",nameof(titulo)); 

        if(string.IsNullOrEmpty(autor))
            throw new ArgumentNullException("O livro deve possuir um autor",nameof(autor));
        
        Id = count;
        Titulo = titulo;
        Autor = autor;
        Disponivel = true;
        count++;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Livr:\nId: {Id}\nTitulo: {Titulo}\nAutor: {Autor}\n Disponivel: {Disponivel}");
    }

}