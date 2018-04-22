namespace RedListSpecies.RedListApi.Contracts
{
    using System.Threading.Tasks;
    using RedListSpecies.RedListApi.ResponseModels;

    public interface IListClient<ResponseType, ModelType>
        where ResponseType : ListResponseBase<ModelType>
        where ModelType : IDataModel
    {
        Task<ResponseType> List();
    }
}
