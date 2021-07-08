using System.Collections.Generic;
using System.Linq;

namespace RealEstate.Models.Estate
{
    public class EstateRepository : IEstateRepository
    {
        private List<Estate> estates = new List<Estate>()
        {
                new Estate{Company = new Company{ CompanyName = "Ardo Realte",CompanyId =1, Description ="TTTTTTTTT uuuuuuuuuu kkkkkkkkk" },
                           Street = "Bashinjaxyan 23/1",
                           Image = "/img/1.jpg",
                           Price = 478_000,
                           EstateId = 1,
                           EstateDescription ="Bnakarany arevkox e uni 100qm taracq, 2 balkon"},
                new Estate{Company = new Company{ CompanyName = "AAT Realte",CompanyId =1, Description ="adOOO O OO LML MMKLMK kkkk" },
                           Street = "Komitas 22/2",
                           Image = "/img/2.jpg",
                           Price = 578_000,
                           EstateId = 2,
                           EstateDescription ="Bnakarany arevkox e uni 120qm taracq, 4 balkon"},
                new Estate{Company = new Company{ CompanyName = "Bagrat and Sons Realte",CompanyId =1, Description ="adyyuu  aOSHJD KJLJLJL KKJK kkkk" },
                           Street = "Artshakh str. 3/3",
                           Image = "/img/3.jpg",
                           Price = 501_400,
                           EstateId = 3,
                           EstateDescription ="Bnakarany arevkox e uni 126qm taracq, 1 balkon"},
                new Estate{Company = new Company{ CompanyName = "VVV Realte",CompanyId =1, Description ="adtysayty sakkhjk klkhjkjs jjhkjs nnkkkk" },
                           Street = "Qochar str. 4",
                           Image = "/img/4.jpg",
                           Price = 693_600,
                           EstateId = 4,
                           EstateDescription ="Bnakarany arevkox e uni 90qm taracq, 3 balkon"},
            };

        public IEnumerable<Estate> Estates => estates;

        public List<Estate> GetAllEstate()
        {
            return estates;
        }

        public Estate GetEstateById(int id)
        {
            return estates.Where(e => e.EstateId == id).FirstOrDefault();
        }
    }
}
