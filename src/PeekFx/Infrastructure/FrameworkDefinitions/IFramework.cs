using System.Collections.Generic;

namespace JetBrains.DotPeek.Plugins.PeekFx.Infrastructure.FrameworkDefinitions
{
    public interface IFramework
    {
        bool IsInstalled();
        IEnumerable<string> GetAssemblies();
    }
}