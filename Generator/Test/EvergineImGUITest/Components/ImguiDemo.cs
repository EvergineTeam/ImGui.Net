using Evergine.Bindings.Imgui;
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
            byte open = 1;
            ImguiNative.igShowDemoWindow(&open);

            //ImguiNative.igSetNextWindowSize(new Vector2(200, 200), ImGuiCond.Appearing);
            //ImguiNative.igBegin("MyWindow".ToPointer(), &open, ImGuiWindowFlags.None);
            
            //ImguiNative.igProgressBar(0, new Vector2(-1, 0), "0%".ToPointer());
            //ImguiNative.igProgressBar(0.5f, new Vector2(-1, 0), "50%".ToPointer());
            //ImguiNative.igProgressBar(1.0f, new Vector2(-1, 0), "100%".ToPointer());
            //ImguiNative.igEnd();
        }
    }
}
