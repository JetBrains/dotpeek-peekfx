using JetBrains.ActionManagement;
using JetBrains.DotPeek.Plugins.PeekFx.Infrastructure.FrameworkDefinitions.DotNet;

namespace JetBrains.DotPeek.Plugins.PeekFx.Handlers.DotNet
{
    [ActionHandler("PeekFx.OpenFx.Net35x64")]
    public class OpenFramework35X64
        : OpenFrameworkHandlerBase, IActionHandler
    {
        public OpenFramework35X64()
        {
            DotNetFramework = new DotNetFramework35X64();
        }
    }
}