using JetBrains.ActionManagement;
using JetBrains.DotPeek.Plugins.PeekFx.Infrastructure.FrameworkDefinitions.DotNet;

namespace JetBrains.DotPeek.Plugins.PeekFx.Handlers.DotNet
{
    [ActionHandler("PeekFx.OpenFx.Net20x86")]
    public class OpenFramework20X86
        : OpenFrameworkHandlerBase, IActionHandler
    {
        public OpenFramework20X86()
        {
            DotNetFramework = new DotNetFramework20X86();
        }
    }
}