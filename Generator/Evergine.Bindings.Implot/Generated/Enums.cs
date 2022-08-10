using Evergine.Mathematics;
using Evergine.Bindings.Imgui;
using System;

namespace Evergine.Bindings.Implot
{
	public enum ImAxis
	{
		X1 = 0,
		X2 = 1,
		X3 = 2,
		Y1 = 3,
		Y2 = 4,
		Y3 = 5,
		COUNT = 6,
	}

	[Flags]
	public enum ImPlotAxisFlags
	{
		None = 0,
		NoLabel = 1,
		NoGridLines = 2,
		NoTickMarks = 4,
		NoTickLabels = 8,
		NoInitialFit = 16,
		NoMenus = 32,
		Opposite = 64,
		Foreground = 128,
		Invert = 256,
		AutoFit = 512,
		RangeFit = 1024,
		PanStretch = 2048,
		LockMin = 4096,
		LockMax = 8192,
		Lock = 12288,
		NoDecorations = 15,
		AuxDefault = 66,
	}

	[Flags]
	public enum ImPlotBarGroupsFlags
	{
		None = 0,
		Horizontal = 1024,
		Stacked = 2048,
	}

	[Flags]
	public enum ImPlotBarsFlags
	{
		None = 0,
		Horizontal = 1024,
	}

	public enum ImPlotBin
	{
		None = 0,
		Sqrt = -1,
		Sturges = -2,
		Rice = -3,
		Scott = -4,
	}

	public enum ImPlotCol
	{
		Line = 0,
		Fill = 1,
		MarkerOutline = 2,
		MarkerFill = 3,
		ErrorBar = 4,
		FrameBg = 5,
		PlotBg = 6,
		PlotBorder = 7,
		LegendBg = 8,
		LegendBorder = 9,
		LegendText = 10,
		TitleText = 11,
		InlayText = 12,
		AxisText = 13,
		AxisGrid = 14,
		AxisTick = 15,
		AxisBg = 16,
		AxisBgHovered = 17,
		AxisBgActive = 18,
		Selection = 19,
		Crosshairs = 20,
		COUNT = 21,
	}

	[Flags]
	public enum ImPlotColormapScaleFlags
	{
		None = 0,
		NoLabel = 1,
		Opposite = 2,
		Invert = 4,
	}

	public enum ImPlotColormap
	{
		Deep = 0,
		Dark = 1,
		Pastel = 2,
		Paired = 3,
		Viridis = 4,
		Plasma = 5,
		Hot = 6,
		Cool = 7,
		Pink = 8,
		Jet = 9,
		Twilight = 10,
		RdBu = 11,
		BrBG = 12,
		PiYG = 13,
		Spectral = 14,
		Greys = 15,
	}

	public enum ImPlotCond
	{
		None = 0,
		Always = 1,
		Once = 2,
	}

	[Flags]
	public enum ImPlotDigitalFlags
	{
		None = 0,
	}

	[Flags]
	public enum ImPlotDragToolFlags
	{
		None = 0,
		NoCursors = 1,
		NoFit = 2,
		NoInputs = 4,
		Delayed = 8,
	}

	[Flags]
	public enum ImPlotDummyFlags
	{
		None = 0,
	}

	[Flags]
	public enum ImPlotErrorBarsFlags
	{
		None = 0,
		Horizontal = 1024,
	}

	[Flags]
	public enum ImPlotFlags
	{
		None = 0,
		NoTitle = 1,
		NoLegend = 2,
		NoMouseText = 4,
		NoInputs = 8,
		NoMenus = 16,
		NoBoxSelect = 32,
		NoChild = 64,
		NoFrame = 128,
		Equal = 256,
		Crosshairs = 512,
		CanvasOnly = 55,
	}

	[Flags]
	public enum ImPlotHeatmapFlags
	{
		None = 0,
		ColMajor = 1024,
	}

	[Flags]
	public enum ImPlotHistogramFlags
	{
		None = 0,
		Horizontal = 1024,
		Cumulative = 2048,
		Density = 4096,
		NoOutliers = 8192,
		ColMajor = 16384,
	}

	[Flags]
	public enum ImPlotImageFlags
	{
		None = 0,
	}

	[Flags]
	public enum ImPlotInfLinesFlags
	{
		None = 0,
		Horizontal = 1024,
	}

	[Flags]
	public enum ImPlotItemFlags
	{
		None = 0,
		NoLegend = 1,
		NoFit = 2,
	}

	[Flags]
	public enum ImPlotLegendFlags
	{
		None = 0,
		NoButtons = 1,
		NoHighlightItem = 2,
		NoHighlightAxis = 4,
		NoMenus = 8,
		Outside = 16,
		Horizontal = 32,
	}

	[Flags]
	public enum ImPlotLineFlags
	{
		None = 0,
		Segments = 1024,
		Loop = 2048,
		SkipNaN = 4096,
		NoClip = 8192,
	}

	public enum ImPlotLocation
	{
		Center = 0,
		North = 1,
		South = 2,
		West = 4,
		East = 8,
		NorthWest = 5,
		NorthEast = 9,
		SouthWest = 6,
		SouthEast = 10,
	}

	public enum ImPlotMarker
	{
		None = -1,
		Circle = 0,
		Square = 1,
		Diamond = 2,
		Up = 3,
		Down = 4,
		Left = 5,
		Right = 6,
		Cross = 7,
		Plus = 8,
		Asterisk = 9,
		COUNT = 10,
	}

	[Flags]
	public enum ImPlotMouseTextFlags
	{
		None = 0,
		NoAuxAxes = 1,
		NoFormat = 2,
		ShowAlways = 4,
	}

	[Flags]
	public enum ImPlotPieChartFlags
	{
		None = 0,
		Normalize = 1024,
	}

	public enum ImPlotScale
	{
		Linear = 0,
		Time = 1,
		Log10 = 2,
		SymLog = 3,
	}

	[Flags]
	public enum ImPlotScatterFlags
	{
		None = 0,
		NoClip = 1024,
	}

	[Flags]
	public enum ImPlotShadedFlags
	{
		None = 0,
	}

	[Flags]
	public enum ImPlotStairsFlags
	{
		None = 0,
		PreStep = 1024,
	}

	[Flags]
	public enum ImPlotStemsFlags
	{
		None = 0,
		Horizontal = 1024,
	}

	public enum ImPlotStyleVar
	{
		LineWeight = 0,
		Marker = 1,
		MarkerSize = 2,
		MarkerWeight = 3,
		FillAlpha = 4,
		ErrorBarSize = 5,
		ErrorBarWeight = 6,
		DigitalBitHeight = 7,
		DigitalBitGap = 8,
		PlotBorderSize = 9,
		MinorAlpha = 10,
		MajorTickLen = 11,
		MinorTickLen = 12,
		MajorTickSize = 13,
		MinorTickSize = 14,
		MajorGridSize = 15,
		MinorGridSize = 16,
		PlotPadding = 17,
		LabelPadding = 18,
		LegendPadding = 19,
		LegendInnerPadding = 20,
		LegendSpacing = 21,
		MousePosPadding = 22,
		AnnotationPadding = 23,
		FitPadding = 24,
		PlotDefaultSize = 25,
		PlotMinSize = 26,
		COUNT = 27,
	}

	[Flags]
	public enum ImPlotSubplotFlags
	{
		None = 0,
		NoTitle = 1,
		NoLegend = 2,
		NoMenus = 4,
		NoResize = 8,
		NoAlign = 16,
		ShareItems = 32,
		LinkRows = 64,
		LinkCols = 128,
		LinkAllX = 256,
		LinkAllY = 512,
		ColMajor = 1024,
	}

	[Flags]
	public enum ImPlotTextFlags
	{
		None = 0,
		Vertical = 1024,
	}

}
