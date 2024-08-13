using System;
using System.Security.Cryptography.X509Certificates;

namespace BibliotecaMinha;

public class Biblioteca
{
    List<Cliente> Clientes { get; set; }
    List<Livro> Livros { get; set; }
    List <Emprestimo> Emprestimos {get; set;}

    public Biblioteca()
    {

        Clientes = new List<Cliente>();
        Livros = new List<Livro>();
        Emprestimos = new List<Emprestimo>();

    }

    public void EmprestarLivro(int idLivro, int idCliente)
    {
        if(Livros.Find(Livros => Livros.Id == idLivro) == null)
            Console.WriteLine("Id inexistente");
        
        else
            if (Livros.Find(Livros => Livros.Id == idLivro).Disponivel == false)
                Console.WriteLine("Livro indisponivel"); 
    }
    

    public void DevolverLivro()
    {

    }

    public void SalvarDados()
    {

    }

    public void CarregarDados()
    {

    }

    public void AdicionarCliente(string nome, string tel, DateTime dataNascimento)
    {

        Cliente clienteNovo = new Cliente(tel, nome, dataNascimento);
        Clientes.Add(clienteNovo);
        Console.WriteLine($"Cliente {clienteNovo.Nome} adicionado com sucesso!");

    }

    public void AdicionarFuncionario(string cargo, string nome, DateTime dataAdmissao, DateTime dataNascimento)
    {
        Funcionario novoFuncionario = new Funcionario(cargo, dataAdmissao, nome, 
        dataNascimento);
        Console.WriteLine($"Funcionario {novoFuncionario.Nome} adicionado com sucesso!");
    }

    public void AdicionarLivro(string livro, string autor)
    {
        Livro novoLivro = new Livro(livro, autor);
        Livros.Add(novoLivro);
        Console.WriteLine($"Livro: {novoLivro.Titulo} adicionado com sucesso!");
    }

}