using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmegaParkingBusiness.Models
{
    public class Registro : Entity
    {
        public Guid EstacionamentoId { get; set; }

        public DateTime RegistroEntrada { get; set; }
        public DateTime RegistroSaida { get; set; }
        public decimal ValorCobrado { get; set; }
                
        //EF Relations
        public Estacionamento Estacionamento { get; set; }
        public Veiculo Veiculo { get; set; }
    }
}
