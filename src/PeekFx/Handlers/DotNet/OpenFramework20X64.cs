using JetBrains.ActionManagement;
using JetBrains.DotPeek.Plugins.PeekFx.Infrastructure.FrameworkDefinitions.DotNet;

namespace JetBrains.DotPeek.Plugins.PeekFx.Handlers.DotNet
{
    [ActionHandler("PeekFx.OpenFx.Net20x64")]
    public class OpenFramework20X64
        : OpenFrameworkHandlerBase, IActionHandler
    {
        public OpenFramework20X64()
        {
            DotNetFramework = new DotNetFramework20X64();
        }
    }
}