namespace Domain.Interfaces.Models
{
    public interface IReturnModel
    {
        public bool Success { get; set; }
        public uint Code { get; set; }
        public string? Message { get; set; }
    }
}
