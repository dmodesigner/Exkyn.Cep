namespace Domain.Entities
{
    public class Adresses
    {
        public int AddressID { get; set; }
        public int NeighborhoodID { get; set; }
        public int CityID { get; set; }
        public int StateID { get; set; }
        public string? ZipCode { get; set; }
        public string? Address { get; set; }
        public virtual Neighborhoods? Neighborhoods { get; set; }
        public virtual Cities? Cities { get; set; }
        public virtual States? States { get; set; }
    }
}
