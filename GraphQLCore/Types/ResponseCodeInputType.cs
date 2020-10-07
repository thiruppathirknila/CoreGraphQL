using GraphQL.Types;

namespace GraphQLCore.Types
{
    public class ResponseCodeInputType : InputObjectGraphType
    {
        public ResponseCodeInputType()
        {
            Name = "ResponseCodeInputType";

            Field<NonNullGraphType<IntGraphType>>("Id").Description = "Id";
            Field<NonNullGraphType<StringGraphType>>("Processor").Description = "Processor Name";
            Field<NonNullGraphType<StringGraphType>>("Response_Code").Description = "Response Code";
            Field<NonNullGraphType<StringGraphType>>("Message").Description = "Message";
            Field<NonNullGraphType<StringGraphType>>("Description").Description = "Description";
            Field<NonNullGraphType<StringGraphType>>("Type").Description = "Type";
            Field<NonNullGraphType<BooleanGraphType>>("Can_Retry").Description = "Can Retry";
        }
       
    }
}
