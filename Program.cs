using System;
using System.Collections.Generic;

// Definição da classe Pessoa
public class Pessoa
{
    public string Nome { get; }

    public Pessoa(string nome)
    {
        Nome = nome;
    }
}

// Definição da classe Suíte
public class Suite
{
    public string Tipo { get; }
    public int Capacidade { get; }
    public double ValorDiaria { get; }

    public Suite(string tipoSuite, int capacidade, double valorDiaria)
    {
        Tipo = tipoSuite;
        Capacidade = capacidade;
        ValorDiaria = valorDiaria;
    }
}

// Definição da classe Reserva
public class Reserva
{
    private List<Pessoa> hospedes;
    private Suite suite;
    private int diasReservados;

    public Reserva(int diasReservados)
    {
        this.diasReservados = diasReservados;
        hospedes = new List<Pessoa>();
    }

    public void CadastrarSuite(Suite suite)
    {
        this.suite = suite;
    }

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        this.hospedes.AddRange(hospedes);
    }

    public int ObterQuantidadeHospedes()
    {
        return hospedes.Count;
    }

    public double CalcularValorDiaria()
    {
        return suite.ValorDiaria;
    }

    public double CalcularValorTotal()
    {
        double valorTotal = diasReservados * suite.ValorDiaria;

        // Aplica desconto de 10% para reservas com mais de 10 dias
        if (diasReservados > 10)
        {
            valorTotal *= 0.9;
        }

        return valorTotal;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Cria os modelos de hóspedes e cadastra na lista de hóspedes
        List<Pessoa> hospedes = new List<Pessoa>
        {
            new Pessoa(nome: "Hóspede 1"),
            new Pessoa(nome: "Hóspede 2")
        };

        // Cria a suíte
        Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

        // Cria uma nova reserva, passando a suíte e os hóspedes
        Reserva reserva = new Reserva(diasReservados: 5);
        reserva.CadastrarSuite(suite);
        reserva.CadastrarHospedes(hospedes);

        // Exibe a quantidade de hóspedes e o valor da diária
        Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
        Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");

        // Exibe o valor total da reserva
        Console.WriteLine($"Valor total da reserva: {reserva.CalcularValorTotal()}");
    }
}