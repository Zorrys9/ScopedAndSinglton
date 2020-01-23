using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SingletonAndScoped.Services;
namespace SingletonAndScoped.Middleware
{
    public class TimerMiddleware
    {
        private readonly RequestDelegate _next;
        public TimerMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context, TimerService timerService)
        {
            context.Response.ContentType = "text/html;charset=utf-8";
            await context.Response.WriteAsync($"Текущее время: {timerService?.GetTime()}");
        }

    }
}
