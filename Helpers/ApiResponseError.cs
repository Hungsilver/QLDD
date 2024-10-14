
namespace Digitization.Helpers
{
    public record ApiResponseError<T>(int code, string message, T? result, bool isOK);
}
