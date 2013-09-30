using JetBrains.ActionManagement;
using JetBrains.DotPeek.Plugins.PeekFx.Infrastructure.FrameworkDefinitions.DotNet;

namespace JetBrains.DotPeek.Plugins.PeekFx.Handlers.DotNet
{
    [ActionHandler("PeekFx.OpenFx.Net45x64")]
    public class OpenFramework45X64
        : OpenFrameworkHandlerBase, IActionHandler
    {
        public OpenFramework45X64()
        {
            DotNetFramework = new DotNetFramework45X64();
        }
    }
}