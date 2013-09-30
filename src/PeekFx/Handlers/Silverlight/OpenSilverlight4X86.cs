using JetBrains.ActionManagement;
using JetBrains.DotPeek.Plugins.PeekFx.Infrastructure.FrameworkDefinitions.Silverlight;

namespace JetBrains.DotPeek.Plugins.PeekFx.Handlers.Silverlight
{
    [ActionHandler("PeekFx.OpenFx.SL4x86")]
    public class OpenSilverlight4X86
        : OpenFrameworkHandlerBase, IActionHandler
    {
        public OpenSilverlight4X86()
        {
            DotNetFramework = new SilverlightFramework4X86();
        }
    }
}