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
    
    public partial class CASTING
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CASTING()
        {
            this.ORGANISATIONs = new HashSet<ORGANISATION>();
            this.FILTRES = new HashSet<FILTRE>();
            this.CATEGORIES = new HashSet<CATEGORy>();
            this.USERS = new HashSet<USER>();
        }
    
        public int ID_CASTING { get; set; }
        public string LABEL { get; set; }
        public string DOM_METIERS { get; set; }
        public string METIERS { get; set; }
        public string TYPE_CONTRACT { get; set; }
        public Nullable<int> DUREE_DIFFUSION { get; set; }
        public System.DateTime DATE_DEB_CONTRACT { get; set; }
        public int NB_POSTES { get; set; }
        public string LOCALISATION { get; set; }
        public string DESC_POSTE { get; set; }
        public string DESC_PROFIL { get; set; }
        public string COORDONNEES { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORGANISATION> ORGANISATIONs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FILTRE> FILTRES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CATEGORy> CATEGORIES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USER> USERS { get; set; }
    }
}
