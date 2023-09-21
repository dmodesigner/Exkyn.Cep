namespace Domain.Entities
{
    public class Cities
    {
        public int CityID { get; set; }
        public int StateID { get; set; }
        public string? ZipCode { get; set; }
        public string? City { get; set; }
        public bool Capital { get; set; }
        public virtual States? States { get; set; }
    }
}
