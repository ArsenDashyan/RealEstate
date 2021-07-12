using System;
using System.Collections.Generic;

#nullable disable

namespace RealEstate.Models.Estate
{
    public partial class Company
    {
        public Company()
        {
            Estates = new HashSet<Estate>();
        }

        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public int Tel { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string WebAdress { get; set; }

        public virtual ICollection<Estate> Estates { get; set; }
    }
}
