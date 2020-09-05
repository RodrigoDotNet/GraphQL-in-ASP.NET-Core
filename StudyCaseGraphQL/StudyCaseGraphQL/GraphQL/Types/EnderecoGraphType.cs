using GraphQL.Types;
using StudyCaseGraphQL.Models;

namespace StudyCaseGraphQL.GraphQL.Types
{
    public class EnderecoGraphType : ObjectGraphType<Endereco>
    {
        public EnderecoGraphType()
        {
            Name = "Endereco";
            Description = "Endereço cliente";
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Endereço Id");
            Field(x => x.Logradouro).Description("Logradouro");
            Field(x => x.Numero).Description("Número");
            Field(x => x.Cep).Description("CEP");
            Field(x => x.Cidade).Description("Cidade");
            Field(x => x.Bairro).Description("Bairro");
            Field(x => x.Complemento).Description("Complemento");
            Field(x => x.Uf).Description("Estado");
        }
    }
}
