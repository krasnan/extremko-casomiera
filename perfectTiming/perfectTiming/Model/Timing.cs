//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace perfectTiming.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Timing
    {
        public int id { get; set; }
        public int competitor_id { get; set; }
        public int race_id { get; set; }
        public Nullable<double> lap_time { get; set; }
        public Nullable<int> lap_number { get; set; }
    
        public virtual Competitor Competitor { get; set; }
        public virtual Race Race { get; set; }
    }
}