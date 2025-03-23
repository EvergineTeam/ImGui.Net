using Evergine.Bindings.Imgui;
using Evergine.Bindings.Implot;
using Evergine.Common.Input;
using Evergine.Common.Input.Keyboard;
using Evergine.Framework;
using Evergine.Framework.Services;
using Evergine.Mathematics;
using EvergineImGUITest.Managers;
using System;
using System.Runtime.CompilerServices;

namespace EvergineImGUITest.Components
{
    public unsafe class ImguiDemo : Behavior
    {
        [BindService]
        protected GraphicsPresenter graphicsPresenter;

        protected override void Update(TimeSpan gameTime)
        {
            ImguiNative.igShowDemoWindow(default);

            //ImplotNative.ImPlot_ShowDemoWindow(default);
        }
    }
}
