using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AisectOnline.Common.Clients
{
    public enum MessageType
    {
        Success,
        Error,
        Unauthorized,
        Failure
    }

    public enum ApiStatus
    {
        Ok,
        Error,
        Unauthorized,
        Failure
    }

    public class Response<T>
    {
        public ApiStatus Status { get; set; }
        public string? Message { get; set; }
        public T? Data { get; set; }
    }

    public class Result<T>
    {
        public bool IsSuccess { get; set; }
        public T? Data { get; set; }
        public string? ErrorMessage { get; set; }

        public static Result<T> Success(T data) => new() { IsSuccess = true, Data = data };
        public static Result<T> Failure(string error) => new() { IsSuccess = false, ErrorMessage = error };
    }

}
