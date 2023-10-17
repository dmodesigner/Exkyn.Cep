using System.Net;

namespace Domain.Interfaces.Models
{
    public interface IReturnModel
    {
        public bool Success { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public string? Message { get; set; }
    }
}
