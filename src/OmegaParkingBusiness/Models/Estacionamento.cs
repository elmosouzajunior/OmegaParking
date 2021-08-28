using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmegaParkingBusiness.Models
{
    public class Estacionamento : Entity
    {
        public string Nome { get; set; }
        public int TotalVagasAutomoveis { get; set; }
        public int TotalVagasMotocicletas { get; set; }

        //EF Relations
        public IEnumerable<Registro> Registros { get; set; }
    }
}
