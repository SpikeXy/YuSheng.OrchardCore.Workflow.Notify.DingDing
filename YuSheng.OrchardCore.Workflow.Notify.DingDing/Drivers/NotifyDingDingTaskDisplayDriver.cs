using OrchardCore.Workflows.Display;
using OrchardCore.Workflows.Models;
using YuSheng.OrchardCore.Workflow.Notify.DingDing.Activities;
using YuSheng.OrchardCore.Workflow.Notify.DingDing.ViewModels;

namespace YuSheng.OrchardCore.Workflow.Notify.DingDing.Drivers
{
    public class NotifyDingDingTaskDisplayDriver : ActivityDisplayDriver<NotifyDingDingTask, NotifyDingDingTaskViewModel>
    {
        protected override void EditActivity(NotifyDingDingTask source, NotifyDingDingTaskViewModel model)
        {
            model.Webhook = source.Webhook.Expression;
            model.Message = source.Message.Expression;
        }

        protected override void UpdateActivity(NotifyDingDingTaskViewModel model, NotifyDingDingTask activity)
        {
            activity.Webhook = new WorkflowExpression<string>(model.Webhook);
            activity.Message = new WorkflowExpression<object>(model.Message);
        }
    }
}
