using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace JetBrains.DotPeek.Plugins.PeekFx.Infrastructure.FrameworkDefinitions.DotNet
{
    public class DotNetFramework40X86
        : DotNetFramework40, IFramework
    {
        protected bool IsDotNet45()
        {
            string mscorlib = Path.Combine(CurrentSystem.FrameworkPathX86, FrameworkVersions.NET40, "mscorlib.dll");
            return File.Exists(mscorlib) && FileVersionInfo.GetVersionInfo(mscorlib).FilePrivatePart > 15000;
        }

        public override bool IsInstalled()
        {
            return Directory.Exists(Path.Combine(CurrentSystem.FrameworkPathX86, FrameworkVersions.NET40)) && !IsDotNet45();
        }

        public override IEnumerable<string> GetAssemblies()
        {
            return CoreAssemblies.Select(p => Path.Combine(CurrentSystem.FrameworkPathX86, FrameworkVersions.NET40, p))
                .Union(Directory.GetFiles(Path.Combine(CurrentSystem.FrameworkPathX86, FrameworkVersions.NET40), "System.*.dll"))
                .Union(WpfAssemblies40.Select(p => Path.Combine(CurrentSystem.FrameworkPathX86, FrameworkVersions.NET40, p)));
        }
    }
}