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
    
    public partial class MatchupEntries
    {
        public int Id { get; set; }
        public Nullable<int> MatchupID { get; set; }
        public Nullable<int> ParrentMatchupID { get; set; }
        public int TeamCompedingID { get; set; }
        public Nullable<int> Score { get; set; }
    
        public virtual Matchup Matchup { get; set; }
    }
}