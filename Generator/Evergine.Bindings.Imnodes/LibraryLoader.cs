using Evergine.LibraryLoader;

namespace Evergine.Bindings.Imnodes
{
    internal static class ImnodesLoader
    {
        static ImnodesLoader()
        {
            LibraryLoader.LibraryLoader.Instance
                .Register(Library.Create("cimnodes")
                            .AddConfig(DefaultConfig.Instance)
                            .SetPlatform(Platform.Windows, "cimnodes.dll"))
                .Load();
        }
    }
}
