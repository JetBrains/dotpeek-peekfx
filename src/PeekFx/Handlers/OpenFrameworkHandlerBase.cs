using System.Linq;
using JetBrains.ActionManagement;
using JetBrains.Application.DataContext;
using JetBrains.DotPeek.Plugins.PeekFx.Infrastructure.FrameworkDefinitions;
using JetBrains.ProjectModel;
#if DP10
using JetBrains.DotPeek.AssemblyExplorer;
#else
using JetBrains.ReSharper.Features.Browsing.AssemblyExplorer;
#endif
using JetBrains.Util;

namespace JetBrains.DotPeek.Plugins.PeekFx.Handlers
{
    public abstract class OpenFrameworkHandlerBase
        : IActionHandler
    {
        protected IFramework DotNetFramework { get; set; }

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

            var explorerManager = SolutionEx.GetComponent<IAssemblyExplorerManager>(solution);
            explorerManager.AddItemsByPath(DotNetFramework.GetAssemblies().Select(p => new FileSystemPath(p)).ToArray());
        }
    }
}