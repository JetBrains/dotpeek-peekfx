using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace JetBrains.DotPeek.Plugins.PeekFx.Infrastructure.FrameworkDefinitions.DotNet
{
    public class DotNetFramework20X64
        : DotNetFramework20, IFramework
    {
        public override bool IsInstalled()
        {
            return Directory.Exists(Path.Combine(CurrentSystem.FrameworkPathX64, FrameworkVersions.NET20));
        }

        public override IEnumerable<string> GetAssemblies()
        {
            return CoreAssemblies.Select(p => Path.Combine(CurrentSystem.FrameworkPathX64, FrameworkVersions.NET20, p))
                .Union(SystemAssemblies20.Select(p => Path.Combine(CurrentSystem.FrameworkPathX64, FrameworkVersions.NET20, p)));
        }
    }
}