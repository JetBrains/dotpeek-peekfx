using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace JetBrains.DotPeek.Plugins.PeekFx.Infrastructure.FrameworkDefinitions.DotNet
{
    public class DotNetFramework35X86
        : DotNetFramework35, IFramework
    {
        public override bool IsInstalled()
        {
            return Directory.Exists(Path.Combine(CurrentSystem.ProgramFilesX86, ReferencePath35));
        }

        public override IEnumerable<string> GetAssemblies()
        {
            return CoreAssemblies.Select(p => Path.Combine(CurrentSystem.FrameworkPathX86, FrameworkVersions.NET20, p))
                .Union(SystemAssemblies30.Select(p => Path.Combine(CurrentSystem.ProgramFilesX86, p)))
                .Union(SystemAssemblies35.Select(p => Path.Combine(CurrentSystem.ProgramFilesX86, p)));
        }
    }
}