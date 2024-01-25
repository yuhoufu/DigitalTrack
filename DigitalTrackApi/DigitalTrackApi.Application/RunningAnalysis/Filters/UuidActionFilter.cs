using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Threading.Tasks;


namespace DigitalTrackApi.Application.RunningAnalysis.Filters
{
    public class UuidActionFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            foreach (var argument in context.ActionArguments.Values)
            {
                if (argument is RunningAnalysisData data)
                {
                    // 检查 Uuid 属性是否为空或无效
                    if (string.IsNullOrWhiteSpace(data.Uuid) || !Guid.TryParse(data.Uuid, out var _))
                    {
                        // 如果 Uuid 为空或不是有效的 Guid 字符串，生成一个新的 Guid 字符串
                        data.Uuid = Guid.NewGuid().ToString();
                    }
                }
            }

            // 继续执行后续的拦截器和动作方法
            await next();
        }
    }
}
