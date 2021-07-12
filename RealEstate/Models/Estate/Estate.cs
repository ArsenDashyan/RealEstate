using System;
using System.Collections.Generic;

#nullable disable

namespace RealEstate.Models.Estate
{
    public partial class Estate
    {
        public int EstateId { get; set; }
        public string Street { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int CompanyId { get; set; }

        public virtual Company Company { get; set; }
    }
}
