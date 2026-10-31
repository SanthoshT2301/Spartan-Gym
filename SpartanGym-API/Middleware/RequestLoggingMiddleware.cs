using System.Diagnostics;

namespace SpartanGym_API.Middleware
{
    public class RequestLoggingMiddleware
    {
        public readonly RequestDelegate _next;
        public readonly ILogger<RequestLoggingMiddleware> _logger;
        public RequestLoggingMiddleware(RequestDelegate next, ILogger<RequestLoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }
        public async Task InvokeAsync(HttpContext context) {
            var stopwatch = Stopwatch.StartNew();
            var method = context.Request.Method;
            var path= context.Request.Path;
            _logger.LogInformation($"Request Started {method} {path}");
            try
            {
                await _next(context);
                stopwatch.Stop();
                var status = context.Response.StatusCode;
                var level = status > 500 ? LogLevel.Error :
                    status > 400 && status < 500 ? LogLevel.Warning : LogLevel.Information;
                _logger.Log(level, $"Request finished: {method} {path} responded {status} in {stopwatch.ElapsedMilliseconds} ms");
            }
            catch (Exception ex) {
                stopwatch.Stop();
                _logger.LogError(ex, "Request failed: {Method} {Path} after {ElapsedMs} ms",
                    method, path, stopwatch.ElapsedMilliseconds);
                throw;
            }
        }
    }
}
