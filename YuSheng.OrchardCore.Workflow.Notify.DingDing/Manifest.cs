using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "YuSheng OrchardCore Workflow Notify DingDing",
    Author = "spike",
    Website = "",
    Version = "0.0.1"
)]

[assembly: Feature(
    Id = "YuSheng OrchardCore Workflow Notify DingDing",
    Name = "YuSheng OrchardCore Workflow Notify DingDing",
    Description = "Provides dingding notify ",
    Dependencies = new[] { "OrchardCore.Workflows" },
    Category = "Workflows"
)]
