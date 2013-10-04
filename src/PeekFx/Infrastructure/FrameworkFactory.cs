using System;
using System.Linq;
using JetBrains.DotPeek.Plugins.PeekFx.Infrastructure.FrameworkDefinitions;

namespace JetBrains.DotPeek.Plugins.PeekFx.Infrastructure
{
    public class FrameworkFactory
    {
        public IFramework Create(string frameworkId)
        {
            var frameworkType = typeof(IFramework).Assembly.GetTypes()
                .FirstOrDefault(t => typeof (IFramework).IsAssignableFrom(t) && t.Name == frameworkId);
            if (frameworkType != null)
            {
                return (IFramework)Activator.CreateInstance(frameworkType);
            }
            return null;
        }
    }
}