using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OmegaParkingApp.ViewModels
{
    public class EstacionamentoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 3)]
        public string Nome { get; set; }
        
        [DisplayName("Total de vagas para automóveis")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int TotalVagasAutomoveis { get; set; }

        [DisplayName("Total de vagas para motocicletas")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int TotalVagasMotocicletas { get; set; }

        //EF Relations
        public IEnumerable<RegistroViewModel> Registros { get; set; }
    }
}
