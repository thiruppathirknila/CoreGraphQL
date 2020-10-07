using Core.Api.Data.Models;
using GraphQL.Types;

namespace GraphQLCore.Types
{
    public class StoresType : ObjectGraphType<Stores>
    {

        public StoresType()
        {
            Name = "Stores";
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Id");
            Field(x => x.StoreName).Description("Store Name");
           

        }
       
    }
}
