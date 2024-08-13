using System;

namespace BibliotecaMinha;

public class Funcionario : Pessoa
{
	// Propriedade com getters públicos e setters privados para melhor encapsulamento
	public int Id { get; private set; }
	public static int count=0;
	public string Cargo { get; private set; }
	public DateTime DataAdmissao { get; private set; }
	
	public Funcionario(string cargo, DateTime dataAdmissao, string nome, DateTime dataNascimento) : base(nome, dataNascimento)
	{
		if (string.IsNullOrEmpty (cargo))
			throw new ArgumentNullException ("O cargo não pode ser nulo ou vazio", nameof (cargo));
		
		if (dataAdmissao > DateTime.Now)
			throw new ArgumentException ("A data não pode ser no futuro", nameof(dataAdmissao));
		
		Id = count;
		Cargo = cargo;
		DataAdmissao = dataAdmissao;
		count++;
	}
	
	
	public override void  ExibirInformacoes()
	{
		base.ExibirInformacoes();
		
		Console.WriteLine($"ID: {Id}\nCargo: {Cargo}\nData de Adimissão: {DataAdmissao.ToString("dd-MM-yyyy")}");
	}
}