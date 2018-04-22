namespace RedListSpecies.RedListApi
{
    using System.Net.Http;
    using System.Threading.Tasks;
    using Microsoft.Extensions.Options;
    using RedListSpecies.RedListApi.DataModels;
    using RedListSpecies.RedListApi.ResponseModels;

    public class SpeciesClient : ListClientBase<SpeciesResponse, Species>
    {
        public SpeciesClient(HttpClient httpClient, IOptions<Configuration> configuration)
            : base(httpClient, configuration)
        {
        }

        public override async Task<SpeciesResponse> List()
        {
            return await this.List(null, 0);
        }

        public async Task<SpeciesResponse> List(string region = null, int page = 0)
        {
            region = region == null ? string.Empty : $"region/{region}/";
            return await base.ExecuteGet($"species/{region}page/{page}");
        }
    }
}
