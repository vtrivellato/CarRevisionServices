using System;

namespace api.DTOs.Revisao
{
    public class RevisaoReadDTO
    {
        public string Chassi { get; set; }

        public double Km { get; set; }

        public DateTime DataRevisao { get; set; }

        public double Valor { get; set; }

        public string Observacao { get; set; }
    }
}