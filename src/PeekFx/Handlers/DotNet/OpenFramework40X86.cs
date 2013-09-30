using JetBrains.ActionManagement;
using JetBrains.DotPeek.Plugins.PeekFx.Infrastructure.FrameworkDefinitions.DotNet;

namespace JetBrains.DotPeek.Plugins.PeekFx.Handlers.DotNet
{
    [ActionHandler("PeekFx.OpenFx.Net40x86")]
    public class OpenFramework40X86
        : OpenFrameworkHandlerBase, IActionHandler
    {
        public OpenFramework40X86()
        {
            DotNetFramework = new DotNetFramework40X86();
        }
    }
}