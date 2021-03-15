using System;
using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Cor
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Codigo { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public int Fabricante { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? ModifiedAt { get; set; }
    }
}