using System;
using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }
        
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
        [Range(1, int.MaxValue, ErrorMessage = "The Fabricante field must have a value greater or equal than {1}")]
        public int Fabricante { get; set; }

        [MaxLength(8)]
        [Required]
        public string Modelo { get; set; }

        [MaxLength(8)]
        public string Cor { get; set; }

        public double Valor { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? ModifiedAt { get; set; }
    }
}