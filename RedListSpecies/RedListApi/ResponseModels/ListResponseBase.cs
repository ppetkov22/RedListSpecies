namespace RedListSpecies.RedListApi.ResponseModels
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using RedListSpecies.RedListApi.Contracts;

    [DataContract]
    public abstract class ListResponseBase<T>
        where T : IDataModel
    {
        [DataMember(Name = "count")]
        public int Count { get; set; }

        [DataMember(Name = "results")]
        public List<T> List { get; set; }
    }
}
