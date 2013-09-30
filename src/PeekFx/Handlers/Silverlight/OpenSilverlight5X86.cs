using JetBrains.ActionManagement;
using JetBrains.DotPeek.Plugins.PeekFx.Infrastructure.FrameworkDefinitions.Silverlight;

namespace JetBrains.DotPeek.Plugins.PeekFx.Handlers.Silverlight
{
    [ActionHandler("PeekFx.OpenFx.SL5x86")]
    public class OpenSilverlight5X86
        : OpenFrameworkHandlerBase, IActionHandler
    {
        public OpenSilverlight5X86()
        {
            DotNetFramework = new SilverlightFramework5X86();
        }
    }
}