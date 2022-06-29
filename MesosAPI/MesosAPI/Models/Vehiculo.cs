using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MesosAPI.Models
{
    public class Vehiculo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Patente { get; set; }
        [Required]
        public int Ano { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public string Modelo { get; set; }
        [Required]
        public string Color { get; set; }
        public bool TieneSeguro { get; set; }
    }
}
