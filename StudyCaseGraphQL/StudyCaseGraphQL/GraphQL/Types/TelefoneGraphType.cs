using GraphQL.Types;
using StudyCaseGraphQL.Models;

namespace StudyCaseGraphQL.GraphQL.Types
{
    public class TelefoneGraphType : ObjectGraphType<Telefone>
    {
        public TelefoneGraphType()
        {
            Name = "Telefone";
            Description = "Telefone cliente";
            Field(x => x.Ddd).Description("DDD");
            Field(x => x.Numero).Description("Número");
        }
    }
}
