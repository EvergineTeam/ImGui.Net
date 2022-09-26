using Evergine.LibraryLoader;

namespace Evergine.Bindings.Imgui
{
    internal static class ImGuiLoader
    {
        static ImGuiLoader()
        {
            LibraryLoader.LibraryLoader.Instance
                .Register(Library.Create("cimgui")
                            .AddConfig(DefaultConfig.Instance)
                            .SetPlatform(Platform.Windows, "cimgui.dll"))
                .Load();
        }
    }
}
