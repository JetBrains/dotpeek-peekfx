namespace JetBrains.DotPeek.Plugins.PeekFx.Infrastructure.FrameworkDefinitions.DotNet
{
    public abstract class DotNetFramework30
        : DotNetFramework, IFramework
    {
        protected static readonly string ReferencePath30 = "Reference Assemblies\\Microsoft\\Framework\\v3.0";

        protected static readonly string[] SystemAssemblies30 = new string[]
        {
            "Reference Assemblies\\Microsoft\\Framework\\v3.0\\WindowsBase.dll",
            "Reference Assemblies\\Microsoft\\Framework\\v3.0\\PresentationCore.dll",
            "Reference Assemblies\\Microsoft\\Framework\\v3.0\\PresentationFramework.dll",
            "Reference Assemblies\\Microsoft\\Framework\\v3.0\\System.ServiceModel.dll",
            "Reference Assemblies\\Microsoft\\Framework\\v3.0\\System.Workflow.ComponentModel.dll",
            "Reference Assemblies\\Microsoft\\Framework\\v3.0\\System.Workflow.Runtime.dll",
            "Reference Assemblies\\Microsoft\\Framework\\v3.0\\System.Workflow.Activities.dll",
            "Reference Assemblies\\Microsoft\\Framework\\v3.0\\System.IdentityModel.dll",
            "Reference Assemblies\\Microsoft\\Framework\\v3.0\\System.IO.Log.dll",
            "Reference Assemblies\\Microsoft\\Framework\\v3.0\\System.Runtime.Serialization.dll"
        };
    }
}