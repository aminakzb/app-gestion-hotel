//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetGestionHotel.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class images
    {
        public int id_img { get; set; }
        public int id_chambre { get; set; }
        public byte[] image_file { get; set; }
    
        public virtual chambre chambre { get; set; }
    }
}
