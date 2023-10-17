using Domain.Interfaces.Models;
using System.Net;

namespace Domain.Models
{
    public class ReturnModel : IReturnModel
    {
        public bool Success { get; set; } = true;
        public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.OK;
        public string? Message { get; set; }
    }

    public class ReturnModel<T> : IReturnModel
    {
        public bool Success { get; set; } = true;
        public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.OK;
        public string? Message { get; set; }
        public T? Object { get; set; }
        public List<T>? List { get; set; }
    }
}
