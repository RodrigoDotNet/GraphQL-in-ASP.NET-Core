using Bogus;
using Bogus.DataSets;
using StudyCaseGraphQL.Models;
using System;
using System.Collections.Generic;

namespace StudyCaseGraphQL.Builder
{
    public static class GeradorCliente
    {
        public static List<Cliente> GerarClientes(int quantidade)
        {
            var genero = new Faker().PickRandom<Name.Gender>();

            var clientes = new Faker<Cliente>("pt_BR")
                .CustomInstantiator(f => new Cliente
                {
                    PrimeiroNome = f.Name.FirstName(genero),
                    Sobrenome = f.Name.LastName(genero),
                    DataNascimento = f.Date.Past(50, DateTime.Now.AddYears(-18)),
                    Telefones = new List<Telefone>
                    {
                        new Telefone
                        {
                            Ddd = 19,
                            Numero = f.Phone.PhoneNumber("####-####")
                        }
                    },
                    Endereco = new Endereco
                    {
                        Logradouro = f.Address.StreetAddress(),
                        Numero = f.Address.BuildingNumber(),
                        Cep = f.Address.ZipCode(),
                        Cidade = f.Address.City(),
                        Uf = f.Address.State()
                    },
                }).RuleFor(c => c.Email, (f, c) =>
                      f.Internet.Email(c.PrimeiroNome.ToLower(), c.Sobrenome.ToLower()));

            return clientes.Generate(quantidade);
        }
    }
}