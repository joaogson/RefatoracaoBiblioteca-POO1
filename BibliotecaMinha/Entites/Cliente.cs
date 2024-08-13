using System;

namespace BibliotecaMinha;

public class Cliente : Pessoa
{

    public int Id { get; private set; }
    public static int count=0;
    public string Tel { get; private set; }

    public Cliente(string tel, string nome, DateTime dataNascimento) : base(nome, dataNascimento)
    {

        if (string.IsNullOrEmpty(tel))
            throw new ArgumentNullException("Deve ser inserido telefone para contato");
           
        Id = count;
        Tel = tel;
        count++;
        
    }

    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();

        Console.WriteLine($"Id: {Id}\nTelefone:{Tel}");
    }

}