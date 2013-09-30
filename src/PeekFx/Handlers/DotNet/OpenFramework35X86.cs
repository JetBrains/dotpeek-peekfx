using JetBrains.ActionManagement;
using JetBrains.DotPeek.Plugins.PeekFx.Infrastructure.FrameworkDefinitions.DotNet;

namespace JetBrains.DotPeek.Plugins.PeekFx.Handlers.DotNet
{
    [ActionHandler("PeekFx.OpenFx.Net35x86")]
    public class OpenFramework35X86
        : OpenFrameworkHandlerBase, IActionHandler
    {
        public OpenFramework35X86()
        {
            DotNetFramework = new DotNetFramework35X86();
        }
    }
}