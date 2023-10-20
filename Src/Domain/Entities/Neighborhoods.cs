namespace Domain.Entities
{
    public class Neighborhoods
    {
        public int NeighborhoodID { get; set; }
        public int CityID { get; set; }
        public int StateID { get; set; }
        public string? Neighborhood { get; set; }
        public virtual Cities? Cities { get; set; }
        public virtual States? States { get; set; }
    }
}
