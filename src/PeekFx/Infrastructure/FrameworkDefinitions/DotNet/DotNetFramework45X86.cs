using System.IO;

namespace JetBrains.DotPeek.Plugins.PeekFx.Infrastructure.FrameworkDefinitions.DotNet
{
    public class DotNetFramework45X86
        : DotNetFramework40X86, IFramework
    {
        public override bool IsInstalled()
        {
            return Directory.Exists(Path.Combine(CurrentSystem.FrameworkPathX86, FrameworkVersions.NET40)) && IsDotNet45();
        }
    }
}