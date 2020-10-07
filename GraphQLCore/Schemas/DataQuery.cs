using System;
using Core.Api.Data;
using GraphQL;
using GraphQL.Types;
using GraphQLCore.Helper;
using GraphQLCore.Types;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace GraphQLCore.Schemas
{
    public class DataQuery : ObjectGraphType
    {
        private IUnitOfWork _unitOfWork;
        public DataQuery(IUnitOfWork unitOfWork ) {

            _unitOfWork = unitOfWork;
            this.Name = "DataQuery";
            this.Description = "Getting Processor Details";

            Field<StringGraphType>("hi", resolve: t => { return "Hello World"; });
            Field<ListGraphType<ResponseCodeType>>("processors", resolve: context => {
                try
                {
                    Logger.InformationLog($"In Field DataQuery processors.Start, context:" + JsonConvert.SerializeObject(context.FieldAst));
                    return _unitOfWork.responseCode.GetAll();

                }
                catch (Exception ex)
                {
                    Logger.ErrorLog($"Exception Field DataQuery processors. exception={ex.Message}, Trace={ex.StackTrace}");
                    throw ex;
                }
              
            });
            Field<ResponseCodeType>("processor", arguments: new QueryArguments(new QueryArgument<IdGraphType> { Name = "id", Description = "Id" }),
                    resolve: context => {
                        try
                        {
                            Logger.InformationLog($"In Field DataQuery processor.Start, context:" + JsonConvert.SerializeObject(context.FieldAst));
                            return _unitOfWork.responseCode.Get(context.GetArgument<int>("id"));
                        }
                        catch (Exception ex)
                        {
                            Logger.ErrorLog($"Exception Field DataQuery processor. exception={ex.Message}, Trace={ex.StackTrace}");
                            throw ex;
                        }

                    });
        }
    }
}
