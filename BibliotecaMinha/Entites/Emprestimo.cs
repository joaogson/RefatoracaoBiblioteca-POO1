using System;

namespace BibliotecaMinha;

public class Emprestimo
{
    public Cliente ClienteEmprestimo { get; set; }
    public Livro LivroEmprestado { get; set; }
    public DateTime DataEmprestimo { get; set; }
    public DateTime DataDevolucaoPrevista { get; set; }
    public DateTime DataDevolucao { get; set; }

    public Emprestimo(Cliente cliente, Livro livro, DateTime dataEmp, DateTime dataDevP, DateTime dataDev)
    {
        if (cliente == null)
         throw new ArgumentNullException("O emprestimo deve ter um cliente",nameof(cliente));

        if (livro == null)
            throw new ArgumentNullException("O emprestimo deve ter um livro", nameof(livro));

        if (dataEmp > dataDevP)
            throw new ArgumentNullException("Data de empréstimo invalida", nameof(dataEmp));

        if (dataDevP < dataEmp)
            throw new ArgumentNullException("Data de devolução inválida", nameof(dataDevP));

        ClienteEmprestimo = cliente;
        LivroEmprestado = livro;
        DataEmprestimo = dataEmp;
        DataDevolucaoPrevista = dataDevP;            
    }

    public bool Devolvido(){

        return false;
        
    }

}