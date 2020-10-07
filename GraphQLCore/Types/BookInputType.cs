using GraphQL.Types;

namespace GraphQLCore.Types
{
    public class StoreInputType : InputObjectGraphType
    {
        public StoreInputType()
        {
            Name = "StoreInputType";

            Field<NonNullGraphType<IntGraphType>>("Id").Description = "Id";
            Field<NonNullGraphType<StringGraphType>>("StoreName").Description = "Store Name";
            //Field<NonNullGraphType<StringGraphType>>("Publisher").Description = "Book Publisher";
            //Field<NonNullGraphType<StringGraphType>>("Author").Description = " Autor Name";
            //Field<NonNullGraphType<StringGraphType>>("Genre").Description = "Book Genre";
            //Field<NonNullGraphType<IntGraphType>>("Price").Description = " Book Price";
        }
    }
}
