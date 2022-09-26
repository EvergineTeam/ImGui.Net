using Evergine.LibraryLoader;

namespace Evergine.Bindings.Imguizmo
{
    internal static class ImguizmoLoader
    {
        static ImguizmoLoader()
        {
            LibraryLoader.LibraryLoader.Instance
                .Register(Library.Create("cimguizmo")
                            .AddConfig(DefaultConfig.Instance)
                            .SetPlatform(Platform.Windows, "cimguizmo.dll"))
                .Load();
        }
    }
}
