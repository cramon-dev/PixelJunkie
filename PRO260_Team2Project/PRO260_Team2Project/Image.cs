
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
    using PRO260_Team2Project;

    public partial class Image
    {

        public Image()
        {
            this.Comments = new HashSet<Comment>();
            this.ImageOwners = new HashSet<ImageOwner>();
            this.ImageTags = new HashSet<ImageTag>();
            this.Flags = new HashSet<Flag>();
        }

        public int ImageID { get; set; }
        public System.DateTime DateOfUpload { get; set; }
        public int OriginalPosterID { get; set; }
        public byte[] Image1 { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<ImageOwner> ImageOwners { get; set; }
        public virtual ICollection<ImageTag> ImageTags { get; set; }
        public virtual ICollection<Flag> Flags { get; set; }
    }
}
