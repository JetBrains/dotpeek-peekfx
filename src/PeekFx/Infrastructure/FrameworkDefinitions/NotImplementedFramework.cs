using System.Collections.Generic;

namespace JetBrains.DotPeek.Plugins.PeekFx.Infrastructure.FrameworkDefinitions
{
    public class NotImplementedFramework
        : IFramework
    {
        public bool IsInstalled()
        {
            return false;
        }

        public IEnumerable<string> GetAssemblies()
        {
            return new string[] {};
        }
    }
}