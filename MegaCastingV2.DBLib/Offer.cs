//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MegaCastingV2.DBLib
{
    using System;
    using System.Collections.Generic;
    
    public partial class Offer
    {
        public long Identifier { get; set; }
        public string Name { get; set; }
        public string Reference { get; set; }
        public long IdentifierJob { get; set; }
        public long IdentifierContractType { get; set; }
        public Nullable<System.DateTime> PublishDateTime { get; set; }
        public int Duration { get; set; }
        public Nullable<System.DateTime> StartContractDate { get; set; }
        public Nullable<int> PostCount { get; set; }
        public string JobDescription { get; set; }
        public string ProfilDescription { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public long IdentifierProducer { get; set; }
        public long IdentifierCategory { get; set; }
        public long IdentifierFilters { get; set; }
        public Nullable<long> IdentifierApply { get; set; }
    
        public virtual Apply Apply { get; set; }
        public virtual Category Category { get; set; }
        public virtual ContractType ContractType { get; set; }
        public virtual Filtre Filtre { get; set; }
        public virtual Job Job { get; set; }
        public virtual Producer Producer { get; set; }
    }
}
