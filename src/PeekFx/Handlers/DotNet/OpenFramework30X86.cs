using JetBrains.ActionManagement;
using JetBrains.DotPeek.Plugins.PeekFx.Infrastructure.FrameworkDefinitions.DotNet;

namespace JetBrains.DotPeek.Plugins.PeekFx.Handlers.DotNet
{
    [ActionHandler("PeekFx.OpenFx.Net30x86")]
    public class OpenFramework30X86
        : OpenFrameworkHandlerBase, IActionHandler
    {
        public OpenFramework30X86()
        {
            DotNetFramework = new DotNetFramework30X86();
        }
    }
}