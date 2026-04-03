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
		public int PanMod;
		public ImGuiMouseButton Fit;
		public ImGuiMouseButton Select;
		public ImGuiMouseButton SelectCancel;
		public int SelectMod;
		public int SelectHorzMod;
		public int SelectVertMod;
		public ImGuiMouseButton Menu;
		public int OverrideMod;
		public int ZoomMod;
		public float ZoomRate;
	}

	public unsafe partial struct ImPlotPoint
	{
		public double x;
		public double y;
	}

	public unsafe partial struct ImPlotRange
	{
		public double Min;
		public double Max;

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

		public ImPlotRange* self => (ImPlotRange*)Unsafe.AsPointer(ref this);

	}

	public unsafe partial struct ImPlotRect
	{
		public ImPlotRange X;
		public ImPlotRange Y;

		public ImPlotPoint_c Clamp_PlotPoint(ImPlotPoint p)
		{
			return ImplotNative.ImPlotRect_Clamp_PlotPoint(self, p);
		}

		public ImPlotPoint_c Clamp_double(double x, double y)
		{
			return ImplotNative.ImPlotRect_Clamp_double(self, x, y);
		}

		public bool Contains_PlotPoint(ImPlotPoint p)
		{
			return ImplotNative.ImPlotRect_Contains_PlotPoint(self, p);
		}

		public bool Contains_double(double x, double y)
		{
			return ImplotNative.ImPlotRect_Contains_double(self, x, y);
		}

		public ImPlotPoint_c Max()
		{
			return ImplotNative.ImPlotRect_Max(self);
		}

		public ImPlotPoint_c Min()
		{
			return ImplotNative.ImPlotRect_Min(self);
		}

		public ImPlotPoint_c Size()
		{
			return ImplotNative.ImPlotRect_Size(self);
		}

		public ImPlotRect* self => (ImPlotRect*)Unsafe.AsPointer(ref this);

	}

	public unsafe partial struct ImPlotSpec
	{
		public Vector4 LineColor;
		public float LineWeight;
		public Vector4 FillColor;
		public float FillAlpha;
		public ImPlotMarker Marker;
		public float MarkerSize;
		public Vector4 MarkerLineColor;
		public Vector4 MarkerFillColor;
		public float Size;
		public int Offset;
		public int Stride;
		public ImPlotItemFlags Flags;

		public void SetProp_Float(ImPlotProp prop, float v)
		{
			ImplotNative.ImPlotSpec_SetProp_Float(self, prop, v);
		}

		public void SetProp_double(ImPlotProp prop, double v)
		{
			ImplotNative.ImPlotSpec_SetProp_double(self, prop, v);
		}

		public void SetProp_S8(ImPlotProp prop, sbyte v)
		{
			ImplotNative.ImPlotSpec_SetProp_S8(self, prop, v);
		}

		public void SetProp_U8(ImPlotProp prop, byte v)
		{
			ImplotNative.ImPlotSpec_SetProp_U8(self, prop, v);
		}

		public void SetProp_S16(ImPlotProp prop, short v)
		{
			ImplotNative.ImPlotSpec_SetProp_S16(self, prop, v);
		}

		public void SetProp_U16(ImPlotProp prop, ushort v)
		{
			ImplotNative.ImPlotSpec_SetProp_U16(self, prop, v);
		}

		public void SetProp_S32(ImPlotProp prop, int v)
		{
			ImplotNative.ImPlotSpec_SetProp_S32(self, prop, v);
		}

		public void SetProp_U32(ImPlotProp prop, uint v)
		{
			ImplotNative.ImPlotSpec_SetProp_U32(self, prop, v);
		}

		public void SetProp_S64(ImPlotProp prop, long v)
		{
			ImplotNative.ImPlotSpec_SetProp_S64(self, prop, v);
		}

		public void SetProp_U64(ImPlotProp prop, ulong v)
		{
			ImplotNative.ImPlotSpec_SetProp_U64(self, prop, v);
		}

		public void SetProp_Vec4(ImPlotProp prop, Vector4 v)
		{
			ImplotNative.ImPlotSpec_SetProp_Vec4(self, prop, v);
		}

		public ImPlotSpec* self => (ImPlotSpec*)Unsafe.AsPointer(ref this);

	}

	public unsafe partial struct ImPlotStyle
	{
		public Vector2 PlotDefaultSize;
		public Vector2 PlotMinSize;
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
		public float DigitalPadding;
		public float DigitalSpacing;
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
		public ImPlotColormap Colormap;
		public byte UseLocalTime;
		public byte UseISO8601;
		public byte Use24HourClock;
	}

}

