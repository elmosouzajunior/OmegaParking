using OmegaParkingBusiness.Interfaces;
using OmegaParkingBusiness.Models;
using OmegaParkingData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmegaParkingData.Repository
{
    public class RegistroRepository : Repository<Registro>, IRegistroRepository
    {
        public RegistroRepository(OmegaParkingDbContext context) : base(context)
        {
        }
    }
}
