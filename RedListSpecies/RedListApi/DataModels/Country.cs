namespace RedListSpecies.RedListApi.DataModels
{
    using System.Runtime.Serialization;
    using RedListSpecies.RedListApi.Contracts;

    [DataContract]
    public class Country : IDataModel
    {
        [DataMember(Name = "isocode")]
        public string IsoCode { get; set; }
        [DataMember(Name = "country")]
        public string Name { get; set; }
    }
}
