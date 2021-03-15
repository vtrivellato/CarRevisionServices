using System;
using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Fabricante
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int Codigo { get; set; }

        [Required]
        public string Nome { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? ModifiedAt { get; set; }
    }
}