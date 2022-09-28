// See https://aka.ms/new-console-template for more information

using BE7_FS4_UC12.Classes;

PessoaFisica novaPf = new PessoaFisica();

novaPf.nome = "Lozano";

Console.WriteLine(novaPf.nome);
Console.WriteLine("Nome: " + novaPf.nome);
Console.WriteLine($"Nome: {novaPf.nome}");

