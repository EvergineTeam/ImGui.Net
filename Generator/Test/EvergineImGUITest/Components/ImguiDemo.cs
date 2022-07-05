using Evergine.Bindings.Imgui;
////using Evergine.Bindings.Implot;
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

        private static bool open = true;

        protected override void Update(TimeSpan gameTime)
        {
            bool alwaysOpen = true;
            ImguiNative.igShowDemoWindow(alwaysOpen.Ptr());

            ////ImplotNative.ImPlot_ShowDemoWindow(alwaysOpen.Ptr());

            ////ImguiNative.igSetNextWindowSize(new Vector2(200, 200), ImGuiCond.Appearing);

            ////if (open)
            ////{
            ////    byte* v = (byte*)Unsafe.AsPointer(ref open);
            ////    ImguiNative.igBegin("MyWindow", open.Ptr(), ImGuiWindowFlags.None);
            ////    int selected = 0;
            ////    string[] options = new[] { "One", "Two", "Three" };
            ////    ImguiNative.igListBox_Str_arr("names", &selected, options, options.Length, -1);
            ////    ImguiNative.igEnd();
            ////}

            ////KeyboardDispatcher keyboardDispatcher = this.graphicsPresenter.FocusedDisplay?.KeyboardDispatcher;

            ////if (keyboardDispatcher?.ReadKeyState(Keys.Space) == ButtonState.Pressing)
            ////{
            ////    open = true;
            ////}
        }
    }
}
