using Core.Api.Data.Models;
using GraphQL.Types;

namespace GraphQLCore.Types
{
    public class ResponseCodeType : ObjectGraphType<ResponseCodes>
    {
        public ResponseCodeType()
        {
            Name = "ResponseCode";
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Id");
            Field(x => x.Processor).Description("Processor Name");
            Field(x => x.Response_Code).Description("Response Code");
            Field(x => x.Message).Description("Message");
            Field(x => x.Description).Description("Description");
            Field(x => x.Type,nullable:true).Description("Type");
            Field(x => x.Can_Retry,nullable:true).Description("Can Retry");
        }
    }
}
