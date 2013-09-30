namespace JetBrains.DotPeek.Plugins.PeekFx.Infrastructure.FrameworkDefinitions.DotNet
{
    public abstract class DotNetFramework20
        : DotNetFramework, IFramework
    {
        protected static readonly string[] SystemAssemblies20 = new string[]
        {
            "System.configuration.dll",
            "System.Configuration.Install.dll",
            "System.Data.OracleClient.dll",
            "System.Data.SqlXml.dll",
            "System.Deployment.dll",
            "System.Design.dll",
            "System.DirectoryServices.dll",
            "System.DirectoryServices.Protocols.dll",
            "System.Drawing.Design.dll",
            "System.EnterpriseServices.dll",
            "System.Management.dll",
            "System.Messaging.dll",
            "System.Runtime.Remoting.dll",
            "System.Runtime.Serialization.Formatters.Soap.dll",
            "System.Security.dll",
            "System.ServiceProcess.dll",
            "System.Transactions.dll",
            "System.Web.Mobile.dll",
            "System.Web.RegularExpressions.dll",
            "System.Web.Services.dll"
        };
    }
}