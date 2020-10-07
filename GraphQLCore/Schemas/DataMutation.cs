using Core.Api.Data;
using Core.Api.Data.Models;
using GraphQL;
using GraphQL.Types;
using GraphQLCore.Helper;
using GraphQLCore.Types;
using Newtonsoft.Json;
using System;
namespace GraphQLCore.Schemas
{
    public class DataMutation : ObjectGraphType
    {
        private IUnitOfWork _unitOfWork;
        public DataMutation(IUnitOfWork unitOfWork)
        {

            _unitOfWork = unitOfWork;

            this.Name = "DataMutation";
            this.Description = "Processor Manage";

            Field<ResponseCodeType>("addProcessor", arguments: new QueryArguments(new QueryArgument<NonNullGraphType<ResponseCodeInputType>> { Name = "responseCodeDetails" }),
               resolve: context =>
               {
                   try
                   {
                       Logger.InformationLog($"In Field DataMutation addProcessor.Start, context:" + JsonConvert.SerializeObject(context.FieldAst));
                       var response = context.GetArgument<ResponseCodes>("responseCodeDetails");
                       _unitOfWork.responseCode.Add(response);
                       return response;
                   }
                   catch (Exception ex)
                   {
                       Logger.ErrorLog($"Exception Field DataMutation addProcessor. exception={ex.Message}, Trace={ex.StackTrace}");
                       throw ex;
                   }

               });

            Field<ResponseCodeType>("editProcessor", arguments: new QueryArguments(new QueryArgument<NonNullGraphType<ResponseCodeInputType>> { Name = "responseCodeDetails" }),
               resolve: context =>
               {
                   try
                   {
                       Logger.InformationLog($"In Field DataMutation editProcessor.Start, context:" + JsonConvert.SerializeObject(context.FieldAst));
                       var response = context.GetArgument<ResponseCodes>("responseCodeDetails");
                       response = _unitOfWork.responseCode.GetById(response.Id);
                       if (response != null) { _unitOfWork.responseCode.Update(response); }
                       else { response = new ResponseCodes() { Message = "Invalid Id", Description = "Please check Id",Processor="Empty" }; }
                       return response;
                   }
                   catch (Exception ex)
                   {
                       Logger.ErrorLog($"Exception Field DataMutation editProcessor. exception={ex.Message}, Trace={ex.StackTrace}");
                       throw ex;
                   }
               });

            Field<ResponseCodeType>("deleteProcessor", arguments: new QueryArguments(new QueryArgument<IdGraphType> { Name = "id", Description = "Processor ID" }),
                   resolve: context =>
                   {
                       try
                       {
                           Logger.InformationLog($"In Field DataMutation deleteProcessor.Start, context:" + JsonConvert.SerializeObject(context.FieldAst));
                           var response = _unitOfWork.responseCode.GetById(context.GetArgument<int>("id"));
                           if (response != null) { _unitOfWork.responseCode.Delete(response); }
                           else { response = new ResponseCodes() { Message = "Invalid Id", Description = "Please check Id" }; }
                           return response;
                       }
                       catch (Exception ex)
                       {
                           Logger.ErrorLog($"Exception Field DataMutation deleteProcessor. exception={ex.Message}, Trace={ex.StackTrace}");
                           throw ex;
                       }
                   });
        }
    }
}
