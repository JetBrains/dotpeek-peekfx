using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace JetBrains.DotPeek.Plugins.PeekFx.Infrastructure.FrameworkDefinitions.DotNet
{
    public class DotNetFramework30X64
        : DotNetFramework30, IFramework
    {
        public override bool IsInstalled()
        {
            return Directory.Exists(Path.Combine(CurrentSystem.ProgramFilesX64, ReferencePath30));
        }

        public override IEnumerable<string> GetAssemblies()
        {
            return CoreAssemblies.Select(p => Path.Combine(CurrentSystem.FrameworkPathX64, FrameworkVersions.NET20, p))
                .Union(SystemAssemblies30.Select(p => Path.Combine(CurrentSystem.ProgramFilesX64, p)));
        }
    }
}