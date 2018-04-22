namespace RedListSpecies.RedListApi.DataModels
{
    using System.Runtime.Serialization;
    using RedListSpecies.RedListApi.Contracts;

    [DataContract]
    public class Species : IDataModel
    {
        [DataMember(Name = "taxonid")]
        public int ID { get; set; } //	ID for the Species/Taxon

        [DataMember(Name = "kingdom_name")]
        public string KingdomName { get; set; }

        [DataMember(Name = "phylum_name")]
        public string PhylumName { get; set; }

        [DataMember(Name = "class_name")]
        public string ClassName { get; set; }

        [DataMember(Name = "order_name")]
        public string OrderName { get; set; }

        [DataMember(Name = "family_name")]
        public string FamilyName { get; set; }

        [DataMember(Name = "genus_name")]
        public string GenusName { get; set; }

        [DataMember(Name = "scientific_name")]
        public string ScientificName { get; set; } //Scientific name of species

        [DataMember(Name = "infra_rank")]
        public string InfraRank { get; set; }

        [DataMember(Name = "infra_name")]
        public string InfraName { get; set; } //sub-species, if available

        [DataMember(Name = "population")]
        public string Population { get; set; } //Population name, if available

        [DataMember(Name = "category")]
        public string Category { get; set; } //The Red List category
    }
}
