//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PRO260_Team2Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class ImageOwner
    {
        public int ImageID { get; set; }
        public int OwnerID { get; set; }
        public string Caption { get; set; }
        public string Title { get; set; }
        public System.DateTime TimeStamp { get; set; }
        public Nullable<long> Price { get; set; }
        public int Likes { get; set; }
    
        public virtual Comment Comment { get; set; }
        public virtual Image Image { get; set; }
        public virtual Member Member { get; set; }
    }
}
