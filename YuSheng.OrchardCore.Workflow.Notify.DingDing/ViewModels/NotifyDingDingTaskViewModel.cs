using System.ComponentModel.DataAnnotations;

namespace YuSheng.OrchardCore.Workflow.Notify.DingDing.ViewModels
{
    public class NotifyDingDingTaskViewModel
    {
        [Required]
        public string Webhook { get; set; }

        [Required]
        public string Message { get; set; }
    }
}
