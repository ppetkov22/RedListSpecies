namespace RedListSpecies.RedListApi
{
    using System.Net.Http;
    using System.Threading.Tasks;
    using Microsoft.Extensions.Options;
    using RedListSpecies.RedListApi.Contracts;
    using RedListSpecies.RedListApi.ResponseModels;

    public abstract class ListClientBase<ResponseType, ModelType> : ClientBase<ResponseType>
        where ResponseType : ListResponseBase<ModelType>
        where ModelType : IDataModel

    {
        public ListClientBase(HttpClient httpClient, IOptions<Configuration> configuration)
            : base(httpClient, configuration)
        {
        }

        public abstract Task<ResponseType> List();
    }
}
