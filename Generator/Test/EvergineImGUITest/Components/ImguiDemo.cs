using Evergine.Bindings.Imgui;
using Evergine.Bindings.Implot;
using Evergine.Framework;
using Evergine.Framework.Graphics;
using Evergine.Mathematics;
using EvergineImGUITest.Managers;
using System;

namespace EvergineImGUITest.Components
{
    public unsafe class ImguiDemo : Behavior
    {
        protected override void Update(TimeSpan gameTime)
        {
            ImguiNative.igShowDemoWindow(true);

            ImplotNative.ImPlot_ShowDemoWindow(true);

            //ImguiNative.igSetNextWindowSize(new Vector2(200, 200), ImGuiCond.Appearing);
            //ImguiNative.igBegin("MyWindow", true, ImGuiWindowFlags.None);

            //ImguiNative.igProgressBar(0, new Vector2(-1, 0), "0%");
            //ImguiNative.igProgressBar(0.5f, new Vector2(-1, 0), "50%");
            //ImguiNative.igProgressBar(1.0f, new Vector2(-1, 0), "100%");
            //ImguiNative.igEnd();
        }
    }
}
