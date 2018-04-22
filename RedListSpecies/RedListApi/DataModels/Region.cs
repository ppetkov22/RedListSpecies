namespace RedListSpecies.RedListApi.DataModels
{
    using System.Runtime.Serialization;
    using RedListSpecies.RedListApi.Contracts;

    [DataContract]
    public class Region : IDataModel
    {
        [DataMember(Name = "identifier")]
        public string Identifier { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
    }
}
