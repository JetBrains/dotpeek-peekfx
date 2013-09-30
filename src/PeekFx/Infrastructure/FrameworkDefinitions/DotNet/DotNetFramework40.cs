namespace JetBrains.DotPeek.Plugins.PeekFx.Infrastructure.FrameworkDefinitions.DotNet
{
    public abstract class DotNetFramework40
        : DotNetFramework, IFramework
    {
        protected static readonly string[] WpfAssemblies40 = new string[]
        {
            "WPF\\PresentationCore.dll",
            "WPF\\PresentationFramework.dll",
            "WPF\\WindowsBase.dll"
        };
    }
}