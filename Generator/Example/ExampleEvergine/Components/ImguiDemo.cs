using Evergine.Bindings.Imgui;
using Evergine.Bindings.Implot;
using Evergine.Common.Input;
using Evergine.Common.Input.Keyboard;
using Evergine.Framework;
using Evergine.Framework.Services;
using Evergine.Mathematics;
using ExampleEvergine.Managers;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ExampleEvergine.Components
{
    public unsafe class ImguiDemo : Behavior
    {
        [BindService]
        protected GraphicsPresenter graphicsPresenter;
        Vector4 my_color = new Vector4(1, 0, 0, 1);

        protected override void Update(TimeSpan gameTime)
        {
            // ImGUI Demo
            ImguiNative.igShowDemoWindow(default);

            ImguiNative.igBegin("MyWindow", null, ImGuiWindowFlags.MenuBar);

            if (ImguiNative.igBeginMenuBar())
            {
                if (ImguiNative.igBeginMenu("File", true))
                {
                    if (ImguiNative.igMenuItem_Bool("Open", "Ctrl+O", true, true)) { }
                    if (ImguiNative.igBeginMenu("Source", true))
                    {
                        if (ImguiNative.igMenuItem_Bool("Button1", "Ctrl+S", true, true)) { }
                        if (ImguiNative.igMenuItem_Bool("Button2", "Ctrl+C", true, true)) { }
                        ImguiNative.igEndMenu();
                    }
                    if (ImguiNative.igMenuItem_Bool("Save", "Ctrl+S", true, true)) { }
                    if (ImguiNative.igMenuItem_Bool("Close", "Ctrl+C", true, true)) { }

                    ImguiNative.igEndMenu();
                }

                ImguiNative.igEndMenuBar();
            }

            // Edit a color stored as 4 floats
            Vector4 colorPtr = my_color;
            ImguiNative.igColorEdit4("Color", &colorPtr, ImGuiColorEditFlags.Float);
            my_color = colorPtr;

            // Generate samples and plot them
            float* samples = stackalloc float[100];
            for (int n = 0; n < 100; n++)
                samples[n] = (float)Math.Sin(n * 0.5d + ImguiNative.igGetTime() * 1.5d);

            ImguiNative.igPlotLines_FloatPtr("Samples", samples, 100, 0, "", -1, 1, new Vector2(200, 20), sizeof(float));

            // Display contents in a scrolling region
            ImguiNative.igTextColored(new Vector4(1, 1, 0, 1), "Important Stuff");
            ImguiNative.igBeginChild_Str("Scrolling", Vector2.Zero, ImGuiChildFlags.None, ImGuiWindowFlags.None);
            for (int n = 0; n < 50; n++)
                ImguiNative.igText($"{n}: Some text");
            ImguiNative.igEndChild();
            ImguiNative.igText("Hello, world!");
            ImguiNative.igEnd();

            // Implot Demo
            ImplotNative.ImPlot_ShowDemoWindow(default);
        }
    }
}
