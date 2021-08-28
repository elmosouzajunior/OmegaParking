using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmegaParkingBusiness.Models
{
    public class Veiculo : Entity
    {
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public string Observacao { get; set; }
        public TipoVeiculo TipoVeiculo { get; set; }             
    }
}
