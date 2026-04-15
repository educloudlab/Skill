namespace AisectOnline.Common.Clients;

//using AisectOnline.Common.Models;
using System.Net.NetworkInformation;

public static class ResponseStatus
{
    /// <summary>
    /// Map API response messages to Response<T> status and message.
    /// </summary>
    public static Response<T> SetResponseStatus<T>(Response<T> response, MessageType messageType, string? msg = null)
    {
        switch (messageType)
        {
            case MessageType.Success:
                response.Status = ApiStatus.Ok;
                response.Message = messageType.ToString();
                break;

            case MessageType.Error:
                response.Status = ApiStatus.Error;
                response.Message = msg;
                break;

            case MessageType.Unauthorized:
                response.Status = ApiStatus.Unauthorized;
                response.Message = messageType.ToString();
                break;

            case MessageType.Failure:
                response.Status = ApiStatus.Failure;
                response.Message = msg;
                break;
        }

        return response;
    }

    /// <summary>
    /// Map low-level Result to higher-level Response<T>.
    /// </summary>
    public static Response<T> FromResult<T>(Result<T> result)
    {
        var response = new Response<T>();
        if (result.IsSuccess)
        {
            response.Status = ApiStatus.Ok;
            response.Data = result.Data;
            response.Message = "Success";
        }
        else
        {
            response.Status = ApiStatus.Error;
            response.Message = result.ErrorMessage;
        }

        return response;
    }
}
