using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace JetBrains.DotPeek.Plugins.PeekFx.Infrastructure.FrameworkDefinitions
{
    public class WinMd80Framework
        : IFramework
    {
        public bool IsInstalled()
        {
            return Directory.Exists(Path.Combine(CurrentSystem.WindowsSystem32, "WinMetadata"));
        }

        public IEnumerable<string> GetAssemblies()
        {
            var result = Directory.GetFiles(Path.Combine(CurrentSystem.WindowsSystem32, "WinMetadata"), "*.winmd").AsEnumerable();
            if (Directory.Exists(Path.Combine(CurrentSystem.ProgramFilesX86,"Windows Kits\\8.0\\References\\CommonConfiguration\\Neutral")))
            {
                result = result.Union(Directory.GetFiles(Path.Combine(CurrentSystem.ProgramFilesX86, "Windows Kits\\8.0\\References\\CommonConfiguration\\Neutral"), "*.winmd"));
            }
            return result;
        }
    }
}