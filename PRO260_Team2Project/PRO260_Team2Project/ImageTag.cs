
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
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class ImageTag
    {
        [Key]
        [Column(Order = 0)]
        public int ImageID { get; set; }
        [Key]
        [Column(Order = 1)]
        public string Tag { get; set; }

        public virtual Image Image { get; set; }
    }
}
