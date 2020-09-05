using GraphQL.Types;
using StudyCaseGraphQL.Models;

namespace StudyCaseGraphQL.GraphQL.Types
{
    public class ClienteGraphType : ObjectGraphType<Cliente>
    {
        public ClienteGraphType()
        {
            Name = "Cliente";
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Cliente Id");
            Field(x => x.PrimeiroNome).Description("Primeiro nome cliente");
            Field(x => x.Sobrenome).Description("Sobrenome cliente");
            Field(x => x.Email).Description("Email cliente");
            Field(x => x.DataNascimento.Date).Description("Data nascimento cliente").Name("DataNascimento");
            Field(x => x.MaiorDeIdade).Description("Cliente maior de idade");

            Field<EnderecoGraphType>(nameof(Cliente.Endereco));
            Field<ListGraphType<TelefoneGraphType>>(nameof(Cliente.Telefones));
        }
    }
}
