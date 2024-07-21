using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Localization;
using OrchardCore.Workflows.Abstractions.Models;
using OrchardCore.Workflows.Activities;
using OrchardCore.Workflows.Models;
using OrchardCore.Workflows.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;


namespace YuSheng.OrchardCore.Workflow.Notify.DingDing.Activities
{
    public class NotifyDingDingTask : TaskActivity
    {
        private readonly IWorkflowScriptEvaluator _scriptEvaluator;
        private readonly IStringLocalizer S;
        private readonly IHtmlHelper _htmlHelper;
        private readonly IWorkflowExpressionEvaluator _expressionEvaluator;
        public NotifyDingDingTask(IWorkflowScriptEvaluator scriptEvaluator,
            IWorkflowExpressionEvaluator expressionEvaluator,
            IHtmlHelper htmlHelper,
            IStringLocalizer<NotifyDingDingTask> localizer)
        {
            _scriptEvaluator = scriptEvaluator;
            _expressionEvaluator = expressionEvaluator;
            S = localizer;
            _htmlHelper = htmlHelper;

        }

        public override string Name => nameof(NotifyDingDingTask);

        public override LocalizedString DisplayText => S["Notify DingDing Task"];

        public override LocalizedString Category => S["Notify"];

        public WorkflowExpression<string> Webhook
        {
            get => GetProperty(() => new WorkflowExpression<string>());
            set => SetProperty(value);
        }

        public WorkflowExpression<object> Message
        {
            get => GetProperty(() => new WorkflowExpression<object>());
            set => SetProperty(value);
        }

        public override IEnumerable<Outcome> GetPossibleOutcomes(WorkflowExecutionContext workflowContext, ActivityContext activityContext)
        {
            return Outcomes(S["Done"]);
        }

        public override async Task<ActivityExecutionResult> ExecuteAsync(WorkflowExecutionContext workflowContext, ActivityContext activityContext)
        {

            var webhook = Webhook.Expression;
            var message = Message.Expression;
            return Outcomes("Done");
        }
    }
}
