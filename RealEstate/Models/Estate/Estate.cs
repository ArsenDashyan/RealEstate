namespace RealEstate.Models.Estate
{
    public class Estate
    {
        public int EstateId { get; set; }
        public string Street { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
        public Company Company { get; set; }
        public string EstateDescription { get; set; }

    }
}
