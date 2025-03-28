using Evergine.Mathematics;
using Evergine.Bindings.Imgui;
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Evergine.Bindings.Imnodes
{
	public unsafe partial struct EmulateThreeButtonMouse
	{
		public byte* Modifier;
	}

	public unsafe partial struct ImNodesIO
	{
		public EmulateThreeButtonMouse EmulateThreeButtonMouse;
		public LinkDetachWithModifierClick LinkDetachWithModifierClick;
		public MultipleSelectModifier MultipleSelectModifier;
		public int AltMouseButton;
		public float AutoPanningSpeed;
	}

	public unsafe partial struct ImNodesStyle
	{
		public float GridSpacing;
		public float NodeCornerRounding;
		public Vector2 NodePadding;
		public float NodeBorderThickness;
		public float LinkThickness;
		public float LinkLineSegmentsPerLength;
		public float LinkHoverDistance;
		public float PinCircleRadius;
		public float PinQuadSideLength;
		public float PinTriangleSideLength;
		public float PinLineThickness;
		public float PinHoverRadius;
		public float PinOffset;
		public Vector2 MiniMapPadding;
		public Vector2 MiniMapOffset;
		public ImNodesStyleFlags Flags;
		public fixed uint Colors[29];
	}

	public unsafe partial struct LinkDetachWithModifierClick
	{
		public byte* Modifier;
	}

	public unsafe partial struct MultipleSelectModifier
	{
		public byte* Modifier;
	}

}

