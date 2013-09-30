using JetBrains.ActionManagement;
using JetBrains.DotPeek.Plugins.PeekFx.Infrastructure.FrameworkDefinitions.DotNet;

namespace JetBrains.DotPeek.Plugins.PeekFx.Handlers.DotNet
{
    [ActionHandler("PeekFx.OpenFx.Net30x64")]
    public class OpenFramework30X64
        : OpenFrameworkHandlerBase, IActionHandler
    {
        public OpenFramework30X64()
        {
            DotNetFramework = new DotNetFramework30X64();
        }
    }
}