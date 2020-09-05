using System;
using System.Collections.Generic;

namespace StudyCaseGraphQL.Models
{
    public class Cliente
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string PrimeiroNome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool MaiorDeIdade => DataNascimento.Date <= DateTime.Now.AddYears(-18).Date;
        public Endereco Endereco { get; set; }
        public List<Telefone> Telefones { get; set; }
    }
}
