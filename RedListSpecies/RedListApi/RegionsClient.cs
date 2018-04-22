namespace RedListSpecies.RedListApi
{
    using System.Net.Http;
    using System.Threading.Tasks;
    using Microsoft.Extensions.Options;
    using RedListSpecies.RedListApi.DataModels;
    using RedListSpecies.RedListApi.ResponseModels;

    public class RegionsClient : ListClientBase<RegionsResponse, Region>
    {
        public RegionsClient(HttpClient httpClient, IOptions<Configuration> configuration)
            : base(httpClient, configuration)
        {
        }

        public override async Task<RegionsResponse> List()
        {
            return await base.ExecuteGet("region/list");
        }
    }
}
