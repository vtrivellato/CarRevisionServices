using System;

namespace api.Models
{
    public class Veiculo 
    {
        public int Veiculo_Id { get; set; }
        public string Chassi { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public DateTime DataVenda { get; set; }
        public string Cor { get; set; }
        public double Valor { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}