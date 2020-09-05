using GraphQL;
using GraphQL.Types;
using StudyCaseGraphQL.Builder;
using StudyCaseGraphQL.GraphQL.Types;
using System;
using System.Linq;

namespace StudyCaseGraphQL.GraphQL.Queries
{
    public class ClienteQuery : ObjectGraphType
    {
        public ClienteQuery()
        {
            Name = "Query";
            Field<ListGraphType<ClienteGraphType>>("clientes", "Retorna lista de clientes", resolve: context => GeradorCliente.GerarClientes(10));
            Field<ClienteGraphType>("cliente", "Retorna um cliente",
                new QueryArguments(new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "id", Description = "Cliente Id" }),
                    context => GeradorCliente.GerarClientes(1).Single(x => x.Id == context.Arguments["id"].GetPropertyValue<Guid>()));
        }
    }
}
