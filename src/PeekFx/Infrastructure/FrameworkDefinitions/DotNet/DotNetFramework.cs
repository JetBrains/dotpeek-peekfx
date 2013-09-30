using System.Collections.Generic;

namespace JetBrains.DotPeek.Plugins.PeekFx.Infrastructure.FrameworkDefinitions.DotNet
{
    public abstract class DotNetFramework
        : IFramework
    {
        public abstract bool IsInstalled();
        public abstract IEnumerable<string> GetAssemblies();

        protected static readonly string[] CoreAssemblies = new string[]
        {
            "mscorlib.dll",
            "System.dll",
            "System.Data.dll",
            "System.Drawing.dll",
            "System.Web.dll",
            "System.Windows.Forms.dll",
            "System.Xml.dll"
        };
    }
}