using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace JetBrains.DotPeek.Plugins.PeekFx.Infrastructure.FrameworkDefinitions.Silverlight
{
    public class SilverlightFramework3X86
        : SilverlightFramework, IFramework
    {
        public override bool IsInstalled()
        {
            return Directory.Exists(Path.Combine(CurrentSystem.ProgramFilesX86, ReferencePath, FrameworkVersions.SLV30));
        }

        public override IEnumerable<string> GetAssemblies()
        {
            return CoreAssemblies.Select(p => Path.Combine(CurrentSystem.ProgramFilesX86, ReferencePath, FrameworkVersions.SLV30, p))
                .Union(Directory.GetFiles(Path.Combine(CurrentSystem.ProgramFilesX86, ReferencePath, FrameworkVersions.SLV30), "System.*.dll"));
        }
    }
}