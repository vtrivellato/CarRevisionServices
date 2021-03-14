using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    public class RevisaoUpdateDTO
    {        
        [Required]
        [MaxLength(17)]
        [MinLength(17)]
        [ForeignKey("Chassi")]
        public string Chassi { get; set; }

        [Required]
        [Range(1, double.MaxValue, ErrorMessage = "The Km field must have a value greater or equal than {1}")]
        public double Km { get; set; }

        [Required]
        public DateTime DataRevisao { get; set; }

        [Required]
        [Range(1, double.MaxValue, ErrorMessage = "The Valor field must have a value greater or equal than {1}")]
        public double Valor { get; set; }

        [Required]
        [MaxLength(256)]
        public string Observacao { get; set; }
    }
}