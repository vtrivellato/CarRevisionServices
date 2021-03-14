using System;
using System.ComponentModel.DataAnnotations;

namespace api.DTOs
{
    public class VeiculoCreateDTO
    {        
        [Required]
        [MaxLength(17)]
        [MinLength(17)]
        public string Chassi { get; set; }

        [MaxLength(7)]
        [MinLength(7)]
        [Required]
        public string Placa { get; set; }

        [Required]
        public DateTime DataVenda { get; set; }

        [Required]
        public int Fabricante { get; set; }

        [MaxLength(8)]
        [Required]
        public string Modelo { get; set; }

        [MaxLength(8)]
        public string Cor { get; set; }

        public double Valor { get; set; }
    }
}