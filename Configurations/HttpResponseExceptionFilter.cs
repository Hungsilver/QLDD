using Digitization.Helpers;
using Digitization.Helpers.CustomException;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace QLDD.Configurations
{
    public class HttpResponseExceptionFilter: IExceptionFilter
    {
        private readonly ILogger<HttpResponseExceptionFilter> _logger;
        public HttpResponseExceptionFilter(ILogger<HttpResponseExceptionFilter> logger)
        {
            _logger = logger;
        }

        public void OnException(ExceptionContext context)
        {
            _logger.LogError(context.Exception, "An unhandled exception has occurred.");
            var errorResponse = new ApiResponseError<object>
            (
                code: context.Exception switch
                {
                    NotFoundException => StatusCodes.Status404NotFound,
                    BadRequestException => StatusCodes.Status400BadRequest,
                    UnauthorizedAccessException => StatusCodes.Status401Unauthorized,
                    ValidationCustomException => StatusCodes.Status400BadRequest,
                    _ => StatusCodes.Status500InternalServerError //default
                },
                message: context.Exception.Message,
                isOK: false,
                result: null
                );

            context.Result = new ObjectResult(errorResponse)
            {
                StatusCode = errorResponse.code
            };

            context.ExceptionHandled = true;
        }
    }
}
