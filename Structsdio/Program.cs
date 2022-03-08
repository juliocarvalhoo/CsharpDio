using static System.Console;

Pessoa p1 = new Pessoa();

p1.Nome = "Ricardo";
p1.Idade = 30;

p1.EnderecoPessoa = new Endereco()
{
    Logradouro = "Rua dos bobos",
    Numero = 13,
    CEP = "13000",
    Cidade = "Cunha",
};
