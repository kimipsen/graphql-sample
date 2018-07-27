using CurriculumVitaeAPI.Models;
using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CurriculumVitaeAPI.Controllers
{
    [Produces("application/json")]
    [Route("[controller]")]
    public class GraphQLController : Controller
    {
        private readonly IDocumentExecuter documentExecuter;
        private readonly ISchema schema;

        /// <summary>
        /// GraphQL query engine handler
        /// </summary>
        /// <param name="documentExecuter"></param>
        /// <param name="schema"></param>
        public GraphQLController(IDocumentExecuter documentExecuter, ISchema schema)
        {
            this.documentExecuter = documentExecuter;
            this.schema = schema;
        }

        /// <summary>
        /// Single endpoint access for the GraphQL query engine.
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]GraphQLQuery query)
        {
            if(query == null)
            {
                throw new ArgumentNullException(nameof(query));
            }
            var inputs = query.Variables.ToInputs();
            var executionOptions = new ExecutionOptions
            {
                Schema = schema,
                Query = query.Query,
                Inputs = inputs
            };

            var result = await documentExecuter
                .ExecuteAsync(executionOptions)
                .ConfigureAwait(false);

            if(result.Errors != null 
                && result.Errors.Count > 0)
            {
                return NotFound();
            }

            return Ok(result);
        }
    }
}