using JetBrains.ActionManagement;
using JetBrains.DotPeek.Plugins.PeekFx.Infrastructure.FrameworkDefinitions.DotNet;

namespace JetBrains.DotPeek.Plugins.PeekFx.Handlers.DotNet
{
    [ActionHandler("PeekFx.OpenFx.Net40x64")]
    public class OpenFramework40X64
        : OpenFrameworkHandlerBase, IActionHandler
    {
        public OpenFramework40X64()
        {
            DotNetFramework = new DotNetFramework40X64();
        }
    }
}