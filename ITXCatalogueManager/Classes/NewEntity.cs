using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITXCatalogueManager.Classes
{
    class NewEntity
    {
        public Guid Id_Entity { get; set; }
        public Guid Id_City { get; set; }
        public Guid Id_EntityType { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string description { get; set; }
        public string URL { get; set; }
        public string code { get; set; }
        public bool Status { get; set; }

    }
}
