using System.Linq;
using JetBrains.ActionManagement;
using JetBrains.Application.DataContext;
using JetBrains.DotPeek.Plugins.PeekFx.Infrastructure;
using JetBrains.DotPeek.Plugins.PeekFx.Infrastructure.FrameworkDefinitions;
using JetBrains.DotPeek.Plugins.PeekFx.Infrastructure.FrameworkDefinitions.DotNet;
using JetBrains.ProjectModel;
#if DP10
using JetBrains.DotPeek.AssemblyExplorer;
#else
using JetBrains.ReSharper.Features.Browsing.AssemblyExplorer;
#endif
using JetBrains.Util;

namespace JetBrains.DotPeek.Plugins.PeekFx.Handlers
{
    [ActionHandler(
        "PeekFx.OpenFx.DotNetFramework20X86",
        "PeekFx.OpenFx.DotNetFramework20X64",
        "PeekFx.OpenFx.DotNetFramework30X86",
        "PeekFx.OpenFx.DotNetFramework30X64",
        "PeekFx.OpenFx.DotNetFramework35X86",
        "PeekFx.OpenFx.DotNetFramework35X64",
        "PeekFx.OpenFx.DotNetFramework40X86",
        "PeekFx.OpenFx.DotNetFramework40X64",
        "PeekFx.OpenFx.DotNetFramework45X86",
        "PeekFx.OpenFx.DotNetFramework45X64",
        "PeekFx.OpenFx.SilverlightFramework3X86",
        "PeekFx.OpenFx.SilverlightFramework4X86",
        "PeekFx.OpenFx.SilverlightFramework5X86",
        "PeekFx.OpenFx.WinMd80Framework")]
    public class OpenFrameworkHandler
        : IActionHandler
    {
        protected IFramework DotNetFramework { get; set; }

        public OpenFrameworkHandler(string actionId)
        {
            string frameworkId = actionId.Replace("PeekFx.OpenFx.", "");
            var factory = new FrameworkFactory();
            DotNetFramework = factory.Create(frameworkId);
            if (DotNetFramework == null)
            {
                DotNetFramework = new NotImplementedFramework();
            }
        }

        public bool Update(IDataContext context, ActionPresentation presentation, DelegateUpdate nextUpdate)
        {
            return context.GetData<ISolution>(JetBrains.ProjectModel.DataContext.DataConstants.SOLUTION) != null && DotNetFramework.IsInstalled();
        }

        public void Execute(IDataContext context, DelegateExecute nextExecute)
        {
            ISolution solution = context.GetData<ISolution>(JetBrains.ProjectModel.DataContext.DataConstants.SOLUTION);
            if (solution == null)
            {
                return;
            }

            var assemblyExplorerManager = SolutionEx.GetComponent<IAssemblyExplorerManager>(solution);

            var assemblyExplorer = assemblyExplorerManager.Opened;
            if (assemblyExplorer == null)
            {
                return;
            }

            assemblyExplorerManager.AddItemsByPath(DotNetFramework.GetAssemblies().Select(p => new FileSystemPath(p)).ToArray());
        }
    }
}