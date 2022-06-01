using Evergine.Bindings.Imgui;
using Evergine.Framework.Graphics;

namespace EvergineImGUITest.Components
{
    public class ImguiDemo : Drawable3D
    {
        public override unsafe void Draw(DrawContext drawContext)
        {
            byte open = 1;
            ImguiNative.igShowDemoWindow(&open);
        }        
    }
}
