using System.Reflection;
using JetBrains.ActionManagement;
using JetBrains.Application.PluginSupport;

[assembly: ActionsXml("JetBrains.DotPeek.Plugins.PeekFx.Actions.xml")]

// The following information is displayed in the Plugins dialog
[assembly: PluginTitle("PeekFx")]
[assembly: PluginDescription("PeekFx allows loading and decompilation of groups of .NET framework assemblies.")]
[assembly: PluginVendor("Maarten Balliauw")]

[assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyFileVersion("1.0.0.0")]