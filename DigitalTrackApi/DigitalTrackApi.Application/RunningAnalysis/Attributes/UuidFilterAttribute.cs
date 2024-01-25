using DigitalTrackApi.Application.RunningAnalysis.Filters;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DigitalTrackApi.Application.RunningAnalysis.Attributes
{
    public class UuidFilterAttribute : ActionFilterAttribute
    {
        public override async void OnActionExecuting(ActionExecutingContext context)
        {
            UuidActionFilter filter = new UuidActionFilter();
            await filter.OnActionExecutionAsync(context, () => Task.FromResult(new ActionExecutedContext(context, context.Filters, context.Controller)));
        }
    }
}
