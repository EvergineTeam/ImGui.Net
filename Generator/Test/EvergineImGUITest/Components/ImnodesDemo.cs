using Evergine.Bindings.Imgui;
using Evergine.Bindings.Imnodes;
using Evergine.Framework;
using Evergine.Mathematics;
using EvergineImGUITest.Managers;
using System;

namespace EvergineImGUITest.Components
{
    public unsafe class ImnodesDemo : Behavior
    {
        public struct Node
        {
            public string name;
        }

        public Node[] nodes;

        public ImnodesDemo()
        {
            this.nodes = new[]
            {
                new Node() { name = "Add" },
                new Node() { name = "Sine"},
                new Node() { name = "Multiply"},
            };

            ImnodesNative.imnodes_SetNodeEditorSpacePos(0, new Vector2(150, 50));
            ImnodesNative.imnodes_SetNodeEditorSpacePos(3, new Vector2(400, 250));
            ImnodesNative.imnodes_SetNodeEditorSpacePos(6, new Vector2(600, 80));
        }

        protected override void Update(TimeSpan gameTime)
        {
            bool b = true;
            ImguiNative.igBegin("Imnodes Window", b.Ptr(), ImGuiWindowFlags.None);

            ImnodesNative.imnodes_BeginNodeEditor();
            int id = 0;
            for (int i = 0; i < nodes.Length; i++)
            {
                var node = nodes[i];
                
                ImnodesNative.imnodes_BeginNode(id++);

                ImnodesNative.imnodes_BeginNodeTitleBar();
                ImguiNative.igText(node.name);
                ImnodesNative.imnodes_EndNodeTitleBar();

                ImnodesNative.imnodes_BeginInputAttribute(id++, ImNodesPinShape.Circle);
                ImguiNative.igText("input");
                ImnodesNative.imnodes_EndInputAttribute();

                ImnodesNative.imnodes_BeginOutputAttribute(id++, ImNodesPinShape.Circle);
                ImguiNative.igIndent(40);
                ImguiNative.igText("output");
                ImnodesNative.imnodes_EndOutputAttribute();

                ImnodesNative.imnodes_EndNode();
            }

            ImnodesNative.imnodes_EndNodeEditor();

            ImnodesNative.imnodes_MiniMap(0.25f, ImNodesMiniMapLocation.BottomRight, IntPtr.Zero, IntPtr.Zero);

            ImguiNative.igEnd();
        }
    }
}
