using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Api.Data;
using GraphQL;
using GraphQL.Types;
using GraphQLCore.Helper;
using GraphQLCore.Models;
using GraphQLCore.Schemas;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace GraphQLCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GraphQLController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;
        private readonly ILogger<GraphQLController> _logger;

        public GraphQLController(ILogger<GraphQLController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GraphQLQuery graphQLQuery)
        {
            try
            {
                Logger.InformationLog($"In GraphQLController.Post, Post Process Start, graphQLQuery Request: " + JsonConvert.SerializeObject(graphQLQuery));

                var result = await new DocumentExecuter().ExecuteAsync(_ => {
                    _.Schema = new Schema() { Query = new DataQuery(_unitOfWork),Mutation=new DataMutation(_unitOfWork)};
                    _.Query = graphQLQuery.Query;
                    _.Inputs = graphQLQuery.Variables;
                    _.OperationName = graphQLQuery.OprationName;

                });

                if (result.Errors?.Count > 0)
                {
                    return BadRequest();
                }
                Logger.InformationLog($"In TransactionController.Post, Response: " + JsonConvert.SerializeObject(result.Data));

                return Ok(new { Data = result.Data });
            }
            catch (Exception ex)
            {
                Logger.ErrorLog($"Exception GraphQLController.Post .exception={ex.Message}, Trace={ex.StackTrace}");
            }
            finally
            {
                Logger.InformationLog($"Out GraphQLController.Post, Post Process End");
            }
            return BadRequest();
        }

    }
}
