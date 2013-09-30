namespace JetBrains.DotPeek.Plugins.PeekFx.Infrastructure.FrameworkDefinitions.DotNet
{
    public abstract class DotNetFramework35
        : DotNetFramework30, IFramework
    {
        protected static readonly string ReferencePath35 = "Reference Assemblies\\Microsoft\\Framework\\v3.5";

        protected static readonly string[] SystemAssemblies35 = new string[]
        {
            "Reference Assemblies\\Microsoft\\Framework\\v3.5\\System.Core.dll",
            "Reference Assemblies\\Microsoft\\Framework\\v3.5\\System.Xml.Linq.dll",
            "Reference Assemblies\\Microsoft\\Framework\\v3.5\\System.Data.DataSetExtensions.dll"
        };
    }
}