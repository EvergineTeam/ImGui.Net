using Evergine.Bindings.Imgui;
using Evergine.Bindings.Imnodes;
using Evergine.Framework;
using Evergine.Mathematics;
using ExampleEvergine.Managers;
using System;

namespace ExampleEvergine.Components
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
        }

        protected override void Update(TimeSpan gameTime)
        {
            int id = 0;
            ImguiNative.igBegin("Imnodes Window", default, ImGuiWindowFlags.None);

            ImnodesNative.imnodes_BeginNodeEditor();
            
            // Node 1
            ImnodesNative.imnodes_BeginNode(id++);

            ImnodesNative.imnodes_BeginNodeTitleBar();
            ImguiNative.igText("Node 1");
            ImnodesNative.imnodes_EndNodeTitleBar();

            ImnodesNative.imnodes_BeginInputAttribute(id++, ImNodesPinShape.Circle);
            ImguiNative.igText("input");
            ImnodesNative.imnodes_EndInputAttribute();

            ImnodesNative.imnodes_BeginOutputAttribute(id++, ImNodesPinShape.Circle);
            ImguiNative.igIndent(40);
            ImguiNative.igText("output");
            ImnodesNative.imnodes_EndOutputAttribute();

            ImnodesNative.imnodes_EndNode();

            //Node 2
            ImnodesNative.imnodes_BeginNode(id++);

            ImnodesNative.imnodes_BeginNodeTitleBar();
            ImguiNative.igText("Node 2");
            ImnodesNative.imnodes_EndNodeTitleBar();

            ImnodesNative.imnodes_BeginInputAttribute(id++, ImNodesPinShape.Circle);
            ImguiNative.igText("input");
            ImnodesNative.imnodes_EndInputAttribute();

            ImnodesNative.imnodes_BeginOutputAttribute(id++, ImNodesPinShape.Circle);
            ImguiNative.igIndent(40);
            ImguiNative.igText("output");
            ImnodesNative.imnodes_EndOutputAttribute();

            ImnodesNative.imnodes_EndNode();

            ImnodesNative.imnodes_Link(id++, 2, 4);

            ImnodesNative.imnodes_MiniMap(0.25f, ImNodesMiniMapLocation.TopRight, 0, 0);
            ImnodesNative.imnodes_EndNodeEditor();
            ImguiNative.igEnd();
        }
    }
}
