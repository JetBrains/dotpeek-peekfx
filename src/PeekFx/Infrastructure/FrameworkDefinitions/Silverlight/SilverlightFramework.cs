using System.Collections.Generic;

namespace JetBrains.DotPeek.Plugins.PeekFx.Infrastructure.FrameworkDefinitions.Silverlight
{
    public abstract class SilverlightFramework
        : IFramework
    {
        protected readonly string[] CoreAssemblies = new string[]
        {
            "mscorlib.dll"
        };

        protected static readonly string ReferencePath = "Reference Assemblies\\Microsoft\\Framework\\Silverlight";

        public abstract bool IsInstalled();
        public abstract IEnumerable<string> GetAssemblies();
    }
}