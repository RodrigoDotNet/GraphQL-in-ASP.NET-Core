using GraphQL;
using GraphQL.Types;
using StudyCaseGraphQL.GraphQL.Queries;

namespace StudyCaseGraphQL.GraphQL
{
    public class DemoSchema : Schema
    {
        public DemoSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<ClienteQuery>();
        }
    }
}
