using JetBrains.ActionManagement;
using JetBrains.DotPeek.Plugins.PeekFx.Infrastructure.FrameworkDefinitions;

namespace JetBrains.DotPeek.Plugins.PeekFx.Handlers
{
    [ActionHandler("PeekFx.OpenFx.WinMd80")]
    public class OpenWinMd80
        : OpenFrameworkHandlerBase, IActionHandler
    {
        public OpenWinMd80()
        {
            DotNetFramework = new WinMd80Framework();
        }
    }
}