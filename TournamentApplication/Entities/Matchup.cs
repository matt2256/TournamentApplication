//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Matchup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Matchup()
        {
            this.MatchupEntries = new HashSet<MatchupEntry>();
        }
    
        public int Id { get; set; }
        public Nullable<int> WinnerID { get; set; }
        public Nullable<int> MatchupRound { get; set; }
        public string TeamID_One { get; set; }
        public string TeamID_Two { get; set; }
    
        public virtual Team Team { get; set; }
        public virtual Team Team1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MatchupEntry> MatchupEntries { get; set; }
    }
}
