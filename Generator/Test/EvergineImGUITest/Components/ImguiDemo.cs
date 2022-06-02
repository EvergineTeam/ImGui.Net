using Evergine.Bindings.Imgui;
using Evergine.Framework.Graphics;
using Evergine.Mathematics;
using EvergineImGUITest.Managers;

namespace EvergineImGUITest.Components
{
    public class ImguiDemo : Drawable3D
    {
        public override unsafe void Draw(DrawContext drawContext)
        {
            byte open = 1;
            ImguiNative.igShowDemoWindow(&open);

            //ImguiNative.igSetNextWindowSize(new Vector2(200, 200), ImGuiCond.Appearing);
            //ImguiNative.igBegin("MyWindow".ToPointer(), &open, ImGuiWindowFlags.None);
            //byte overlay = 1;
            //ImguiNative.igProgressBar(0, new Vector2(1, 0), &overlay);
            //ImguiNative.igProgressBar(0.5f, new Vector2(1, 0), &overlay);
            //ImguiNative.igProgressBar(1.0f, new Vector2(1, 0), &overlay);
            //ImguiNative.igEnd();
        }
    }
}
