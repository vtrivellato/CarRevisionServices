using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    public class Revisao
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(17)]
        [MinLength(17)]
        [ForeignKey("Chassi")]
        public string Chassi { get; set; }

        [Required]
        public double Km { get; set; }

        [Required]
        public DateTime DataRevisao { get; set; }

        [Required]
        public double Valor { get; set; }

        public string Observacao { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? ModifiedAt { get; set; }

        public Veiculo Veiculo { get; set; }
    }
}