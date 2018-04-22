namespace RedListSpecies.RedListApi
{
    using System.Net.Http;
    using System.Threading.Tasks;
    using Microsoft.Extensions.Options;
    using RedListSpecies.RedListApi.DataModels;
    using RedListSpecies.RedListApi.ResponseModels;

    public class CountriesClient : ListClientBase<CountriesResponse, Country>
    {
        public CountriesClient(HttpClient httpClient, IOptions<Configuration> configuration)
            : base(httpClient, configuration)
        {
        }

        public override async Task<CountriesResponse> List()
        {
            return await base.ExecuteGet("country/list");
        }
    }
}
