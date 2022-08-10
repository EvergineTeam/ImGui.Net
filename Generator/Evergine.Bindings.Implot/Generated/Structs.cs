using Evergine.Mathematics;
using Evergine.Bindings.Imgui;
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Evergine.Bindings.Implot
{
	public unsafe partial struct ImPlotInputMap
	{
		public ImGuiMouseButton Pan;
		public ImGuiModFlags PanMod;
		public ImGuiMouseButton Fit;
		public ImGuiMouseButton Select;
		public ImGuiMouseButton SelectCancel;
		public ImGuiModFlags SelectMod;
		public ImGuiModFlags SelectHorzMod;
		public ImGuiModFlags SelectVertMod;
		public ImGuiMouseButton Menu;
		public ImGuiModFlags OverrideMod;
		public ImGuiModFlags ZoomMod;
		public float ZoomRate;

		public ImPlotInputMap* self => (ImPlotInputMap*)Unsafe.AsPointer(ref this);

	}

	public unsafe partial struct ImPlotPoint
	{
		public double x;
		public double y;

		public ImPlotPoint* self => (ImPlotPoint*)Unsafe.AsPointer(ref this);

	}

	public unsafe partial struct ImPlotRange
	{
		public double Min;
		public double Max;

		public ImPlotRange* self => (ImPlotRange*)Unsafe.AsPointer(ref this);


		public double Clamp(double value)
		{
			return ImplotNative.ImPlotRange_Clamp(self, value);
		}

		public bool Contains(double value)
		{
			return ImplotNative.ImPlotRange_Contains(self, value);
		}

		public double Size()
		{
			return ImplotNative.ImPlotRange_Size(self);
		}
	}

	public unsafe partial struct ImPlotRect
	{
		public ImPlotRange X;
		public ImPlotRange Y;

		public ImPlotRect* self => (ImPlotRect*)Unsafe.AsPointer(ref this);


		public ImPlotPoint Clamp_PlotPoInt(ImPlotPoint p)
		{
			ImPlotPoint pOut;
			ImplotNative.ImPlotRect_Clamp_PlotPoInt(&pOut, self, p);

			return pOut;
		}

		public ImPlotPoint Clamp_double(double x, double y)
		{
			ImPlotPoint pOut;
			ImplotNative.ImPlotRect_Clamp_double(&pOut, self, x, y);

			return pOut;
		}

		public bool Contains_PlotPoInt(ImPlotPoint p)
		{
			return ImplotNative.ImPlotRect_Contains_PlotPoInt(self, p);
		}

		public bool Contains_double(double x, double y)
		{
			return ImplotNative.ImPlotRect_Contains_double(self, x, y);
		}

		public ImPlotPoint Max()
		{
			ImPlotPoint pOut;
			ImplotNative.ImPlotRect_Max(&pOut, self);

			return pOut;
		}

		public ImPlotPoint Min()
		{
			ImPlotPoint pOut;
			ImplotNative.ImPlotRect_Min(&pOut, self);

			return pOut;
		}

		public ImPlotPoint Size()
		{
			ImPlotPoint pOut;
			ImplotNative.ImPlotRect_Size(&pOut, self);

			return pOut;
		}
	}

	public unsafe partial struct ImPlotStyle
	{
		public float LineWeight;
		public int Marker;
		public float MarkerSize;
		public float MarkerWeight;
		public float FillAlpha;
		public float ErrorBarSize;
		public float ErrorBarWeight;
		public float DigitalBitHeight;
		public float DigitalBitGap;
		public float PlotBorderSize;
		public float MinorAlpha;
		public Vector2 MajorTickLen;
		public Vector2 MinorTickLen;
		public Vector2 MajorTickSize;
		public Vector2 MinorTickSize;
		public Vector2 MajorGridSize;
		public Vector2 MinorGridSize;
		public Vector2 PlotPadding;
		public Vector2 LabelPadding;
		public Vector2 LegendPadding;
		public Vector2 LegendInnerPadding;
		public Vector2 LegendSpacing;
		public Vector2 MousePosPadding;
		public Vector2 AnnotationPadding;
		public Vector2 FitPadding;
		public Vector2 PlotDefaultSize;
		public Vector2 PlotMinSize;
		public Vector4 Colors_0;
		public Vector4 Colors_1;
		public Vector4 Colors_2;
		public Vector4 Colors_3;
		public Vector4 Colors_4;
		public Vector4 Colors_5;
		public Vector4 Colors_6;
		public Vector4 Colors_7;
		public Vector4 Colors_8;
		public Vector4 Colors_9;
		public Vector4 Colors_10;
		public Vector4 Colors_11;
		public Vector4 Colors_12;
		public Vector4 Colors_13;
		public Vector4 Colors_14;
		public Vector4 Colors_15;
		public Vector4 Colors_16;
		public Vector4 Colors_17;
		public Vector4 Colors_18;
		public Vector4 Colors_19;
		public Vector4 Colors_20;
		public ImPlotColormap Colormap;
		public byte UseLocalTime;
		public byte UseISO8601;
		public byte Use24HourClock;

		public ImPlotStyle* self => (ImPlotStyle*)Unsafe.AsPointer(ref this);

	}

}

