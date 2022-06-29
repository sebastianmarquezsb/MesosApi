using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MesosAPI.Models
{
    public class VehiculoView
    {
      
        public string Patente { get; set; }
        
        public int Ano { get; set; }
        
        public string Marca { get; set; }
        
        public string Modelo { get; set; }
        
        public string Color { get; set; }
        public bool TieneSeguro { get; set; }
    }
}
