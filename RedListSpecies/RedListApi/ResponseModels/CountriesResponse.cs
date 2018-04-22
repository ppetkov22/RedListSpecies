namespace RedListSpecies.RedListApi.ResponseModels
{
    using System.Runtime.Serialization;
    using RedListSpecies.RedListApi.DataModels;

    [DataContract]
    public class CountriesResponse : ListResponseBase<Country>
    {
    }
}
