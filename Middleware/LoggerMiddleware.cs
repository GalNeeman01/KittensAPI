﻿namespace AssafFinkelshtein;

public class LoggerMiddleware
{
    private readonly RequestDelegate _next;
    private readonly Logger _logger = new Logger();

    public LoggerMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        string remoteIp = context.Connection.RemoteIpAddress!.ToString();
        string method = context.Request.Method;
        string path = context.Request.Path;

        string message = $"{DateTime.Now}\tMethod: {method}\tPath:{path}\tIP:{remoteIp}";

        await _logger.Log(message);
        await _next(context);
    }

}
