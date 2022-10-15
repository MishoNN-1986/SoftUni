namespace Eventures.App.Infrastructure.Filters
{
    using Microsoft.AspNetCore.Mvc.Filters;
    using Microsoft.Extensions.Logging;
    using System;

    public class AdminActivityLoggerFilter : IActionFilter
    {
        private readonly ILogger<AdminActivityLoggerFilter> logger;

        public AdminActivityLoggerFilter(ILogger<AdminActivityLoggerFilter> logger)
        {
            this.logger = logger;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            throw new NotImplementedException();
            //if (context.ActionDescriptor.DisplayName.Contains("EventsController") &&
            //    context.ActionDescriptor.DisplayName.Contains("Create"))
            //{
            //    this.logger.LogInformation("MINA");
            //}
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
        }
    }
}
