using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Models.Estate
{
    public interface IEstateRepository
    {
        IEnumerable<Estate> Estates { get; }

        public List<Estate> GetAllEstate();
        public Estate GetEstateById(int id);
    }
}
