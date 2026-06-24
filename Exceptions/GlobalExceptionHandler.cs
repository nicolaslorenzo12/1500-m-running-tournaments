using Microsoft.AspNetCore.Diagnostics;
using RunningRaceSimulation.Exceptions;

namespace RunningRaceSimulation.Exceptions;

public class GlobalExceptionHandler : IExceptionHandler
{
    public async ValueTask<bool> TryHandleAsync(
        HttpContext httpContext,
        Exception exception,
        CancellationToken cancellationToken)
    {
        switch (exception)
        {
            case RaceNotFoundException:
                httpContext.Response.StatusCode = StatusCodes.Status404NotFound;
                break;

            case RaceAlreadyStartedException:
                httpContext.Response.StatusCode = StatusCodes.Status409Conflict;
                break;

            default:
                httpContext.Response.StatusCode =
                    StatusCodes.Status500InternalServerError;
                break;
        }

        await httpContext.Response.WriteAsJsonAsync(
            new { error = exception.Message },
            cancellationToken);


        // I handled the exception, nothing else should be done
        return true;
    }
}