using System;

namespace api.DTOs
{
    public class VeiculoReadDTO
    {        
        public string Chassi { get; set; }

        public string Placa { get; set; }

        public DateTime DataVenda { get; set; }

        public int Fabricante { get; set; }

        public string Modelo { get; set; }

        public string Cor { get; set; }

        public double Valor { get; set; }
    }
}