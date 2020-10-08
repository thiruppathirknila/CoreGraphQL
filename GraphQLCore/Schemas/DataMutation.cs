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
            this.Description = "Manage MerchantReport";

            Field<ResponseCodeType>("addmerchantReport", arguments: new QueryArguments(new QueryArgument<NonNullGraphType<ResponseCodeInputType>> { Name = "requestDetails" }),
               resolve: context =>
               {
                   try
                   {
                       Logger.InformationLog($"In Field DataMutation addmerchantReport.Start, context:" + JsonConvert.SerializeObject(context.FieldAst));
                       var response = context.GetArgument<ResponseCodes>("requestDetails");
                       _unitOfWork.responseCode.Add(response);
                       return response;
                   }
                   catch (Exception ex)
                   {
                       Logger.ErrorLog($"Exception Field DataMutation addmerchantReport. exception={ex.Message}, Trace={ex.StackTrace}");
                       throw ex;
                   }

               });

            Field<ResponseCodeType>("editmerchantReport", arguments: new QueryArguments(new QueryArgument<NonNullGraphType<ResponseCodeInputType>> { Name = "requestDetails" }),
               resolve: context =>
               {
                   try
                   {
                       Logger.InformationLog($"In Field DataMutation editmerchantReport.Start, context:" + JsonConvert.SerializeObject(context.FieldAst));
                       var response = context.GetArgument<ResponseCodes>("requestDetails");
                       response = _unitOfWork.responseCode.GetById(response.id);
                       if (response != null) {
                           response = context.GetArgument<ResponseCodes>("requestDetails");
                           _unitOfWork.responseCode.Update(response);
                       }
                       else { response = new ResponseCodes() { auth_code = "Invalid Id", auth_response = "Please check Id",processor="Empty" }; }
                       return response;
                   }
                   catch (Exception ex)
                   {
                       Logger.ErrorLog($"Exception Field DataMutation editmerchantReport. exception={ex.Message}, Trace={ex.StackTrace}");
                       throw ex;
                   }
               });

            Field<ResponseCodeType>("deletemerchantReport", arguments: new QueryArguments(new QueryArgument<IdGraphType> { Name = "id", Description = "MerchantReport ID" }),
                   resolve: context =>
                   {
                       try
                       {
                           Logger.InformationLog($"In Field DataMutation deletemerchantReport.Start, context:" + JsonConvert.SerializeObject(context.FieldAst));
                           var response = _unitOfWork.responseCode.GetById(context.GetArgument<int>("id"));
                           if (response != null) { _unitOfWork.responseCode.Delete(response); }
                           else { response = new ResponseCodes() { auth_code = "Invalid Id", auth_response = "Please check Id", processor = "Empty" }; }
                           return response;
                       }
                       catch (Exception ex)
                       {
                           Logger.ErrorLog($"Exception Field DataMutation deletemerchantReport. exception={ex.Message}, Trace={ex.StackTrace}");
                           throw ex;
                       }
                   });
        }
    }
}
