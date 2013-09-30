using System.IO;

namespace JetBrains.DotPeek.Plugins.PeekFx.Infrastructure.FrameworkDefinitions.DotNet
{
    public class DotNetFramework45X64
        : DotNetFramework40X64, IFramework
    {
        public override bool IsInstalled()
        {
            return Directory.Exists(Path.Combine(CurrentSystem.FrameworkPathX64, FrameworkVersions.NET40)) && IsDotNet45();
        }
    }
}