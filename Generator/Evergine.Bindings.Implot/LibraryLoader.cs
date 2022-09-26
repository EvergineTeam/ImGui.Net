using Evergine.LibraryLoader;

namespace Evergine.Bindings.Implot
{
    internal static class ImplotLoader
    {
        static ImplotLoader()
        {
            LibraryLoader.LibraryLoader.Instance
                .Register(Library.Create("cimplot")
                            .AddConfig(DefaultConfig.Instance)
                            .SetPlatform(Platform.Windows, "cimplot.dll"))
                .Load();
        }
    }
}
