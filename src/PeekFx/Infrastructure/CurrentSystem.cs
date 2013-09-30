using System;
using System.IO;

namespace JetBrains.DotPeek.Plugins.PeekFx.Infrastructure
{
    public class CurrentSystem
    {
        public static string WindowsPath
        {
            get
            {
                return Environment.GetEnvironmentVariable("windir") ?? Environment.GetEnvironmentVariable("SystemRoot");
            }
        }

        public static string WindowsSystem32
        {
            get
            {
                return Environment.GetEnvironmentVariable("system32") ?? Path.Combine(WindowsPath, "system32");
            }
        }

        public static string ProgramFilesX86
        {
            get
            {
                return Environment.GetEnvironmentVariable("ProgramFiles(x86)") ?? Environment.GetEnvironmentVariable("ProgramFiles");
            }
        }

        public static string ProgramFilesX64
        {
            get
            {
                return Environment.GetEnvironmentVariable("ProgramFilesX64") ?? ProgramFilesX86.Replace(" (x86)", "");
            }
        }

        public static string FrameworkPathX86
        {
            get
            {
                return Path.Combine(WindowsPath, "Microsoft.NET\\Framework\\");
            }
        }

        public static string FrameworkPathX64
        {
            get
            {
                return Path.Combine(WindowsPath, "Microsoft.NET\\Framework64\\");
            }
        }
    }
}