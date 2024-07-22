using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;
using OrchardCore.Workflows.Helpers;
using YuSheng.OrchardCore.Workflow.Notify.DingDing.Activities;
using YuSheng.OrchardCore.Workflow.Notify.DingDing.Drivers;

namespace YuSheng.OrchardCore.Workflow.Notify.DingDing
{
    [Feature("YuSheng.OrchardCore.Workflow.Notify.DingDing")]
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {

            services.AddActivity<NotifyDingDingTask, NotifyDingDingTaskDisplayDriver>(); ;


        }
    }
}
