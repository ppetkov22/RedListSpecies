namespace RedListSpecies.RedListApi.ResponseModels
{
    using System.Runtime.Serialization;
    using RedListSpecies.RedListApi.DataModels;

    [DataContract]
    public class SpeciesResponse : ListResponseBase<Species>
    {
        [DataMember(Name = "page")]
        public int Page { get; set; }
    }
}
