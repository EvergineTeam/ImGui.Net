using Evergine.Mathematics;
using Evergine.Bindings.Imgui;
using System;

namespace Evergine.Bindings.Imnodes
{
	[Flags]
	public enum ImNodesAttributeFlags
	{
		None = 0,
		EnableLinkDetachWithDragClick = 1,
		EnableLinkCreationOnSnap = 2,
	}

	public enum ImNodesCol
	{
		NodeBackground = 0,
		NodeBackgroundHovered = 1,
		NodeBackgroundSelected = 2,
		NodeOutline = 3,
		TitleBar = 4,
		TitleBarHovered = 5,
		TitleBarSelected = 6,
		Link = 7,
		LinkHovered = 8,
		LinkSelected = 9,
		Pin = 10,
		PinHovered = 11,
		BoxSelector = 12,
		BoxSelectorOutline = 13,
		GridBackground = 14,
		GridLine = 15,
		GridLinePrimary = 16,
		MiniMapBackground = 17,
		MiniMapBackgroundHovered = 18,
		MiniMapOutline = 19,
		MiniMapOutlineHovered = 20,
		MiniMapNodeBackground = 21,
		MiniMapNodeBackgroundHovered = 22,
		MiniMapNodeBackgroundSelected = 23,
		MiniMapNodeOutline = 24,
		MiniMapLink = 25,
		MiniMapLinkSelected = 26,
		MiniMapCanvas = 27,
		MiniMapCanvasOutline = 28,
		COUNT = 29,
	}

	public enum ImNodesMiniMapLocation
	{
		BottomLeft = 0,
		BottomRight = 1,
		TopLeft = 2,
		TopRight = 3,
	}

	public enum ImNodesPinShape
	{
		Circle = 0,
		CircleFilled = 1,
		Triangle = 2,
		TriangleFilled = 3,
		Quad = 4,
		QuadFilled = 5,
	}

	[Flags]
	public enum ImNodesStyleFlags
	{
		None = 0,
		NodeOutline = 1,
		GridLines = 4,
		GridLinesPrimary = 8,
		GridSnapping = 16,
	}

	public enum ImNodesStyleVar
	{
		GridSpacing = 0,
		NodeCornerRounding = 1,
		NodePadding = 2,
		NodeBorderThickness = 3,
		LinkThickness = 4,
		LinkLineSegmentsPerLength = 5,
		LinkHoverDistance = 6,
		PinCircleRadius = 7,
		PinQuadSideLength = 8,
		PinTriangleSideLength = 9,
		PinLineThickness = 10,
		PinHoverRadius = 11,
		PinOffset = 12,
		MiniMapPadding = 13,
		MiniMapOffset = 14,
		COUNT = 15,
	}

}
