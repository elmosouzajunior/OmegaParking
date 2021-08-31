using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OmegaParkingApp.ViewModels
{
    public class RegistroViewModel
    {
        [Key]
        public Guid Id { get; set; }
                
        public DateTime RegistroEntrada { get; set; }
        public DateTime RegistroSaida { get; set; }
        public decimal ValorCobrado { get; set; }

        //EF Relations
        public EstacionamentoViewModel Estacionamento { get; set; }
        public VeiculoViewModel Veiculo { get; set; }
    }
}
