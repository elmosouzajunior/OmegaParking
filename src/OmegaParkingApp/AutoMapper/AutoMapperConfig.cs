using AutoMapper;
using OmegaParkingApp.ViewModels;
using OmegaParkingBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OmegaParkingApp.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Estacionamento, EstacionamentoViewModel>().ReverseMap();
            CreateMap<Registro, RegistroViewModel>().ReverseMap();
            CreateMap<Veiculo, VeiculoViewModel>().ReverseMap();
        }
    }
}
