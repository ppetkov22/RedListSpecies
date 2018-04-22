namespace RedListSpecies.Models
{
    using System.Collections.Generic;
    using RedListSpecies.RedListApi.Contracts;

    public abstract class ListViewModel<T>
        where T : IDataModel
    {
        public List<T> List { get; set; }
    }
}
