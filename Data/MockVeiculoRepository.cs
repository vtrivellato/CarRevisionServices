using System;
using System.Collections.Generic;
using api.Models;

namespace api.Data
{
    public class MockveiculoRepository : IVeiculoRepository
    {
        public IEnumerable<Veiculo> GetVeiculos()
        {
            var veiculos = new List<Veiculo>
            {
                new Veiculo {
                    Veiculo_Id = 1,
                    Chassi = "TESTETESTETESTE11",
                    Placa = "ABC1234",
                    DataVenda = DateTime.Now
                }, new Veiculo {
                    Veiculo_Id = 1,
                    Chassi = "TESTETESTETESTE12",
                    Placa = "ABC4321",
                    DataVenda = DateTime.Now
                }, new Veiculo {
                    Veiculo_Id = 1,
                    Chassi = "TESTETESTETESTE13",
                    Placa = "FPZ8T82",
                    DataVenda = DateTime.Now
                }, new Veiculo {
                    Veiculo_Id = 1,
                    Chassi = "TESTETESTETESTE14",
                    Placa = "ERG4957",
                    DataVenda = DateTime.Now
                }
            };

            return  veiculos;
        }

        public Veiculo GetveiculoById(int id)
        {
            return new Veiculo
            {
                Veiculo_Id = 1,
                Chassi = "TESTETESTETESTE12",
                Placa = "ABC1234",
                DataVenda = new DateTime(2021, 03, 13)
            };
        }
    }
}