using Domain.Interfaces.Models;

namespace Domain.Models
{
    public class ReturnModel : IReturnModel
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
    }

    public class ReturnModel<T> : IReturnModel
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
        public T? Object { get; set; }
        public List<T>? List { get; set; }
    }
}
