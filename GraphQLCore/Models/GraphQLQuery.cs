using GraphQL;
namespace GraphQLCore.Models
{
    public class GraphQLQuery
    {
        public string Query { get; set; }
        public Inputs Variables { get; set; }
        public string OprationName { get; set; }
    }
}
