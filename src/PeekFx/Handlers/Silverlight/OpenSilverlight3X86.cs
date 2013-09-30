using JetBrains.ActionManagement;
using JetBrains.DotPeek.Plugins.PeekFx.Infrastructure.FrameworkDefinitions.Silverlight;

namespace JetBrains.DotPeek.Plugins.PeekFx.Handlers.Silverlight
{
    [ActionHandler("PeekFx.OpenFx.SL3x86")]
    public class OpenSilverlight3X86
        : OpenFrameworkHandlerBase, IActionHandler
    {
        public OpenSilverlight3X86()
        {
            DotNetFramework = new SilverlightFramework3X86();
        }
    }
}