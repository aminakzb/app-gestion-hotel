using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetGestionHotel.Models
{
    public class indexViewModel
    {
        public  List<administrateur> administrateurModelObject { get; set; }
        public List<client> clientModelObject { get; set; }
        public List<reservation> reservationModelObject { get; set; }
        public List<commentaire> commentaireModelObject { get; set; }
    }
}