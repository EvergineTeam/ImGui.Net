using Evergine.Mathematics;
using Evergine.Bindings.Imgui;
using System;
using System.Runtime.InteropServices;

namespace Evergine.Bindings.Implot
{
	public static unsafe partial class ImplotNative
	{
		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlotRange_Clamp(ImPlotRange* self, double value);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.Bool)]
		public static extern bool ImPlotRange_Contains(ImPlotRange* self, double value);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlotRange_Size(ImPlotRange* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotRect_Clamp_PlotPoInt(ImPlotPoint* pOut, ImPlotRect* self, ImPlotPoint p);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotRect_Clamp_double(ImPlotPoint* pOut, ImPlotRect* self, double x, double y);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.Bool)]
		public static extern bool ImPlotRect_Contains_PlotPoInt(ImPlotRect* self, ImPlotPoint p);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.Bool)]
		public static extern bool ImPlotRect_Contains_double(ImPlotRect* self, double x, double y);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotRect_Max(ImPlotPoint* pOut, ImPlotRect* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotRect_Min(ImPlotPoint* pOut, ImPlotRect* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotRect_Size(ImPlotPoint* pOut, ImPlotRect* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImPlotColormap ImPlot_AddColormap_Vec4Ptr([MarshalAs(UnmanagedType.LPStr)] string name, Vector4* cols, int size, [MarshalAs(UnmanagedType.Bool)] bool qual);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImPlotColormap ImPlot_AddColormap_U32Ptr([MarshalAs(UnmanagedType.LPStr)] string name, uint* cols, int size, [MarshalAs(UnmanagedType.Bool)] bool qual);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_Annotation_Bool(double x, double y, Vector4 color, Vector2 pix_offset, [MarshalAs(UnmanagedType.Bool)] bool clamp, [MarshalAs(UnmanagedType.Bool)] bool round);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_Annotation_Str(double x, double y, Vector4 color, Vector2 pix_offset, [MarshalAs(UnmanagedType.Bool)] bool clamp, [MarshalAs(UnmanagedType.LPStr)] string fmt);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.Bool)]
		public static extern bool ImPlot_BeginAlignedPlots([MarshalAs(UnmanagedType.LPStr)] string group_id, [MarshalAs(UnmanagedType.Bool)] bool vertical);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.Bool)]
		public static extern bool ImPlot_BeginDragDropSourceAxis(ImAxis axis, ImGuiDragDropFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.Bool)]
		public static extern bool ImPlot_BeginDragDropSourceItem([MarshalAs(UnmanagedType.LPStr)] string label_id, ImGuiDragDropFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.Bool)]
		public static extern bool ImPlot_BeginDragDropSourcePlot(ImGuiDragDropFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.Bool)]
		public static extern bool ImPlot_BeginDragDropTargetAxis(ImAxis axis);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.Bool)]
		public static extern bool ImPlot_BeginDragDropTargetLegend();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.Bool)]
		public static extern bool ImPlot_BeginDragDropTargetPlot();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.Bool)]
		public static extern bool ImPlot_BeginLegendPopup([MarshalAs(UnmanagedType.LPStr)] string label_id, ImGuiMouseButton mouse_button);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.Bool)]
		public static extern bool ImPlot_BeginPlot([MarshalAs(UnmanagedType.LPStr)] string title_id, Vector2 size, ImPlotFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.Bool)]
		public static extern bool ImPlot_BeginSubplots([MarshalAs(UnmanagedType.LPStr)] string title_id, int rows, int cols, Vector2 size, ImPlotSubplotFlags flags, float* row_ratios, float* col_ratios);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_BustColorCache([MarshalAs(UnmanagedType.LPStr)] string plot_title_id);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_CancelPlotSelection();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.Bool)]
		public static extern bool ImPlot_ColormapButton([MarshalAs(UnmanagedType.LPStr)] string label, Vector2 size, ImPlotColormap cmap);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_ColormapIcon(ImPlotColormap cmap);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_ColormapScale([MarshalAs(UnmanagedType.LPStr)] string label, double scale_min, double scale_max, Vector2 size, ImPlotColormap cmap, [MarshalAs(UnmanagedType.LPStr)] string format);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.Bool)]
		public static extern bool ImPlot_ColormapSlider([MarshalAs(UnmanagedType.LPStr)] string label, float* t, Vector4* @out, [MarshalAs(UnmanagedType.LPStr)] string format, ImPlotColormap cmap);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ImPlot_CreateContext();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_DestroyContext(IntPtr ctx);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.Bool)]
		public static extern bool ImPlot_DragLineX(int id, double* x, Vector4 col, float thickness, ImPlotDragToolFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.Bool)]
		public static extern bool ImPlot_DragLineY(int id, double* y, Vector4 col, float thickness, ImPlotDragToolFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.Bool)]
		public static extern bool ImPlot_DragPoint(int id, double* x, double* y, Vector4 col, float size, ImPlotDragToolFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.Bool)]
		public static extern bool ImPlot_DragRect(int id, double* x_min, double* y_min, double* x_max, double* y_max, Vector4 col, ImPlotDragToolFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_EndAlignedPlots();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_EndDragDropSource();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_EndDragDropTarget();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_EndLegendPopup();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_EndPlot();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_EndSubplots();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_GetColormapColor(Vector4* pOut, int idx, ImPlotColormap cmap);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImPlot_GetColormapCount();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImPlotColormap ImPlot_GetColormapIndex([MarshalAs(UnmanagedType.LPStr)] string name);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.LPStr)]
		public static extern string ImPlot_GetColormapName(ImPlotColormap cmap);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImPlot_GetColormapSize(ImPlotColormap cmap);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ImPlot_GetCurrentContext();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImPlotInputMap* ImPlot_GetInputMap();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_GetLastItemColor(Vector4* pOut);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.LPStr)]
		public static extern string ImPlot_GetMarkerName(ImPlotMarker idx);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImDrawList* ImPlot_GetPlotDrawList();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImPlotRect ImPlot_GetPlotLimits(ImAxis x_axis, ImAxis y_axis);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_GetPlotMousePos(ImPlotPoint* pOut, ImAxis x_axis, ImAxis y_axis);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_GetPlotPos(Vector2* pOut);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImPlotRect ImPlot_GetPlotSelection(ImAxis x_axis, ImAxis y_axis);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_GetPlotSize(Vector2* pOut);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImPlotStyle* ImPlot_GetStyle();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.LPStr)]
		public static extern string ImPlot_GetStyleColorName(ImPlotCol idx);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_HideNextItem([MarshalAs(UnmanagedType.Bool)] bool hidden, ImPlotCond cond);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.Bool)]
		public static extern bool ImPlot_IsAxisHovered(ImAxis axis);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.Bool)]
		public static extern bool ImPlot_IsLegendEntryHovered([MarshalAs(UnmanagedType.LPStr)] string label_id);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.Bool)]
		public static extern bool ImPlot_IsPlotHovered();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.Bool)]
		public static extern bool ImPlot_IsPlotSelected();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.Bool)]
		public static extern bool ImPlot_IsSubplotsHovered();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_ItemIcon_Vec4(Vector4 col);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_ItemIcon_U32(uint col);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_MapInputDefault(ImPlotInputMap* dst);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_MapInputReverse(ImPlotInputMap* dst);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_NextColormapColor(Vector4* pOut);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PixelsToPlot_Vec2(ImPlotPoint* pOut, Vector2 pix, ImAxis x_axis, ImAxis y_axis);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PixelsToPlot_Float(ImPlotPoint* pOut, float x, float y, ImAxis x_axis, ImAxis y_axis);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarGroups_FloatPtr(byte** label_ids, float* values, int item_count, int group_count, double group_width, double x0, ImPlotBarGroupsFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarGroups_doublePtr(byte** label_ids, double* values, int item_count, int group_count, double group_width, double x0, ImPlotBarGroupsFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarGroups_S8Ptr(byte** label_ids, sbyte* values, int item_count, int group_count, double group_width, double x0, ImPlotBarGroupsFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarGroups_U8Ptr(byte** label_ids, byte* values, int item_count, int group_count, double group_width, double x0, ImPlotBarGroupsFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarGroups_S16Ptr(byte** label_ids, short* values, int item_count, int group_count, double group_width, double x0, ImPlotBarGroupsFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarGroups_U16Ptr(byte** label_ids, ushort* values, int item_count, int group_count, double group_width, double x0, ImPlotBarGroupsFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarGroups_S32Ptr(byte** label_ids, int* values, int item_count, int group_count, double group_width, double x0, ImPlotBarGroupsFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarGroups_U32Ptr(byte** label_ids, uint* values, int item_count, int group_count, double group_width, double x0, ImPlotBarGroupsFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarGroups_S64Ptr(byte** label_ids, long* values, int item_count, int group_count, double group_width, double x0, ImPlotBarGroupsFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarGroups_U64Ptr(byte** label_ids, ulong* values, int item_count, int group_count, double group_width, double x0, ImPlotBarGroupsFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarGroupsH_FloatPtr(byte** label_ids, float* values, int item_count, int group_count, double group_height, double y0, ImPlotBarGroupsFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarGroupsH_doublePtr(byte** label_ids, double* values, int item_count, int group_count, double group_height, double y0, ImPlotBarGroupsFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarGroupsH_S8Ptr(byte** label_ids, sbyte* values, int item_count, int group_count, double group_height, double y0, ImPlotBarGroupsFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarGroupsH_U8Ptr(byte** label_ids, byte* values, int item_count, int group_count, double group_height, double y0, ImPlotBarGroupsFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarGroupsH_S16Ptr(byte** label_ids, short* values, int item_count, int group_count, double group_height, double y0, ImPlotBarGroupsFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarGroupsH_U16Ptr(byte** label_ids, ushort* values, int item_count, int group_count, double group_height, double y0, ImPlotBarGroupsFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarGroupsH_S32Ptr(byte** label_ids, int* values, int item_count, int group_count, double group_height, double y0, ImPlotBarGroupsFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarGroupsH_U32Ptr(byte** label_ids, uint* values, int item_count, int group_count, double group_height, double y0, ImPlotBarGroupsFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarGroupsH_S64Ptr(byte** label_ids, long* values, int item_count, int group_count, double group_height, double y0, ImPlotBarGroupsFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarGroupsH_U64Ptr(byte** label_ids, ulong* values, int item_count, int group_count, double group_height, double y0, ImPlotBarGroupsFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBars_FloatPtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, float* values, int count, double bar_width, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBars_doublePtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, double* values, int count, double bar_width, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBars_S8PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, sbyte* values, int count, double bar_width, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBars_U8PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, byte* values, int count, double bar_width, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBars_S16PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, short* values, int count, double bar_width, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBars_U16PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, ushort* values, int count, double bar_width, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBars_S32PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, int* values, int count, double bar_width, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBars_U32PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, uint* values, int count, double bar_width, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBars_S64PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, long* values, int count, double bar_width, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBars_U64PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, ulong* values, int count, double bar_width, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBars_FloatPtrFloatPtr([MarshalAs(UnmanagedType.LPStr)] string label_id, float* xs, float* ys, int count, double bar_width, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBars_doublePtrdoublePtr([MarshalAs(UnmanagedType.LPStr)] string label_id, double* xs, double* ys, int count, double bar_width, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBars_S8PtrS8Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, sbyte* xs, sbyte* ys, int count, double bar_width, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBars_U8PtrU8Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, byte* xs, byte* ys, int count, double bar_width, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBars_S16PtrS16Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, short* xs, short* ys, int count, double bar_width, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBars_U16PtrU16Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, ushort* xs, ushort* ys, int count, double bar_width, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBars_S32PtrS32Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, int* xs, int* ys, int count, double bar_width, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBars_U32PtrU32Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, uint* xs, uint* ys, int count, double bar_width, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBars_S64PtrS64Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, long* xs, long* ys, int count, double bar_width, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBars_U64PtrU64Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, ulong* xs, ulong* ys, int count, double bar_width, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsG([MarshalAs(UnmanagedType.LPStr)] string label_id, ImPlotPoint* getter, void* data, int count, double bar_width);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsH_FloatPtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, float* values, int count, double bar_height, double y0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsH_doublePtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, double* values, int count, double bar_height, double y0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsH_S8PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, sbyte* values, int count, double bar_height, double y0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsH_U8PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, byte* values, int count, double bar_height, double y0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsH_S16PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, short* values, int count, double bar_height, double y0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsH_U16PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, ushort* values, int count, double bar_height, double y0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsH_S32PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, int* values, int count, double bar_height, double y0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsH_U32PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, uint* values, int count, double bar_height, double y0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsH_S64PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, long* values, int count, double bar_height, double y0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsH_U64PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, ulong* values, int count, double bar_height, double y0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsH_FloatPtrFloatPtr([MarshalAs(UnmanagedType.LPStr)] string label_id, float* xs, float* ys, int count, double bar_height, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsH_doublePtrdoublePtr([MarshalAs(UnmanagedType.LPStr)] string label_id, double* xs, double* ys, int count, double bar_height, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsH_S8PtrS8Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, sbyte* xs, sbyte* ys, int count, double bar_height, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsH_U8PtrU8Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, byte* xs, byte* ys, int count, double bar_height, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsH_S16PtrS16Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, short* xs, short* ys, int count, double bar_height, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsH_U16PtrU16Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, ushort* xs, ushort* ys, int count, double bar_height, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsH_S32PtrS32Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, int* xs, int* ys, int count, double bar_height, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsH_U32PtrU32Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, uint* xs, uint* ys, int count, double bar_height, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsH_S64PtrS64Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, long* xs, long* ys, int count, double bar_height, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsH_U64PtrU64Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, ulong* xs, ulong* ys, int count, double bar_height, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsHG([MarshalAs(UnmanagedType.LPStr)] string label_id, ImPlotPoint* getter, void* data, int count, double bar_height);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotDigital_FloatPtr([MarshalAs(UnmanagedType.LPStr)] string label_id, float* xs, float* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotDigital_doublePtr([MarshalAs(UnmanagedType.LPStr)] string label_id, double* xs, double* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotDigital_S8Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, sbyte* xs, sbyte* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotDigital_U8Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, byte* xs, byte* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotDigital_S16Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, short* xs, short* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotDigital_U16Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, ushort* xs, ushort* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotDigital_S32Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, int* xs, int* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotDigital_U32Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, uint* xs, uint* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotDigital_S64Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, long* xs, long* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotDigital_U64Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, ulong* xs, ulong* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotDigitalG([MarshalAs(UnmanagedType.LPStr)] string label_id, ImPlotPoint* getter, void* data, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotDummy([MarshalAs(UnmanagedType.LPStr)] string label_id);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBars_FloatPtrFloatPtrFloatPtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, float* xs, float* ys, float* err, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBars_doublePtrdoublePtrdoublePtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, double* xs, double* ys, double* err, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBars_S8PtrS8PtrS8PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, sbyte* xs, sbyte* ys, sbyte* err, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBars_U8PtrU8PtrU8PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, byte* xs, byte* ys, byte* err, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBars_S16PtrS16PtrS16PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, short* xs, short* ys, short* err, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBars_U16PtrU16PtrU16PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, ushort* xs, ushort* ys, ushort* err, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBars_S32PtrS32PtrS32PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, int* xs, int* ys, int* err, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBars_U32PtrU32PtrU32PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, uint* xs, uint* ys, uint* err, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBars_S64PtrS64PtrS64PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, long* xs, long* ys, long* err, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBars_U64PtrU64PtrU64PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, ulong* xs, ulong* ys, ulong* err, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBars_FloatPtrFloatPtrFloatPtrFloatPtr([MarshalAs(UnmanagedType.LPStr)] string label_id, float* xs, float* ys, float* neg, float* pos, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBars_doublePtrdoublePtrdoublePtrdoublePtr([MarshalAs(UnmanagedType.LPStr)] string label_id, double* xs, double* ys, double* neg, double* pos, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBars_S8PtrS8PtrS8PtrS8Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, sbyte* xs, sbyte* ys, sbyte* neg, sbyte* pos, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBars_U8PtrU8PtrU8PtrU8Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, byte* xs, byte* ys, byte* neg, byte* pos, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBars_S16PtrS16PtrS16PtrS16Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, short* xs, short* ys, short* neg, short* pos, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBars_U16PtrU16PtrU16PtrU16Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, ushort* xs, ushort* ys, ushort* neg, ushort* pos, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBars_S32PtrS32PtrS32PtrS32Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, int* xs, int* ys, int* neg, int* pos, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBars_U32PtrU32PtrU32PtrU32Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, uint* xs, uint* ys, uint* neg, uint* pos, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBars_S64PtrS64PtrS64PtrS64Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, long* xs, long* ys, long* neg, long* pos, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBars_U64PtrU64PtrU64PtrU64Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, ulong* xs, ulong* ys, ulong* neg, ulong* pos, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBarsH_FloatPtrFloatPtrFloatPtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, float* xs, float* ys, float* err, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBarsH_doublePtrdoublePtrdoublePtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, double* xs, double* ys, double* err, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBarsH_S8PtrS8PtrS8PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, sbyte* xs, sbyte* ys, sbyte* err, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBarsH_U8PtrU8PtrU8PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, byte* xs, byte* ys, byte* err, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBarsH_S16PtrS16PtrS16PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, short* xs, short* ys, short* err, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBarsH_U16PtrU16PtrU16PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, ushort* xs, ushort* ys, ushort* err, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBarsH_S32PtrS32PtrS32PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, int* xs, int* ys, int* err, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBarsH_U32PtrU32PtrU32PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, uint* xs, uint* ys, uint* err, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBarsH_S64PtrS64PtrS64PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, long* xs, long* ys, long* err, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBarsH_U64PtrU64PtrU64PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, ulong* xs, ulong* ys, ulong* err, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBarsH_FloatPtrFloatPtrFloatPtrFloatPtr([MarshalAs(UnmanagedType.LPStr)] string label_id, float* xs, float* ys, float* neg, float* pos, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBarsH_doublePtrdoublePtrdoublePtrdoublePtr([MarshalAs(UnmanagedType.LPStr)] string label_id, double* xs, double* ys, double* neg, double* pos, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBarsH_S8PtrS8PtrS8PtrS8Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, sbyte* xs, sbyte* ys, sbyte* neg, sbyte* pos, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBarsH_U8PtrU8PtrU8PtrU8Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, byte* xs, byte* ys, byte* neg, byte* pos, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBarsH_S16PtrS16PtrS16PtrS16Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, short* xs, short* ys, short* neg, short* pos, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBarsH_U16PtrU16PtrU16PtrU16Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, ushort* xs, ushort* ys, ushort* neg, ushort* pos, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBarsH_S32PtrS32PtrS32PtrS32Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, int* xs, int* ys, int* neg, int* pos, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBarsH_U32PtrU32PtrU32PtrU32Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, uint* xs, uint* ys, uint* neg, uint* pos, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBarsH_S64PtrS64PtrS64PtrS64Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, long* xs, long* ys, long* neg, long* pos, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBarsH_U64PtrU64PtrU64PtrU64Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, ulong* xs, ulong* ys, ulong* neg, ulong* pos, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotHLines_FloatPtr([MarshalAs(UnmanagedType.LPStr)] string label_id, float* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotHLines_doublePtr([MarshalAs(UnmanagedType.LPStr)] string label_id, double* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotHLines_S8Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, sbyte* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotHLines_U8Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, byte* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotHLines_S16Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, short* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotHLines_U16Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, ushort* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotHLines_S32Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, int* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotHLines_U32Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, uint* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotHLines_S64Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, long* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotHLines_U64Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, ulong* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotHeatmap_FloatPtr([MarshalAs(UnmanagedType.LPStr)] string label_id, float* values, int rows, int cols, double scale_min, double scale_max, [MarshalAs(UnmanagedType.LPStr)] string label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotHeatmap_doublePtr([MarshalAs(UnmanagedType.LPStr)] string label_id, double* values, int rows, int cols, double scale_min, double scale_max, [MarshalAs(UnmanagedType.LPStr)] string label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotHeatmap_S8Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, sbyte* values, int rows, int cols, double scale_min, double scale_max, [MarshalAs(UnmanagedType.LPStr)] string label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotHeatmap_U8Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, byte* values, int rows, int cols, double scale_min, double scale_max, [MarshalAs(UnmanagedType.LPStr)] string label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotHeatmap_S16Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, short* values, int rows, int cols, double scale_min, double scale_max, [MarshalAs(UnmanagedType.LPStr)] string label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotHeatmap_U16Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, ushort* values, int rows, int cols, double scale_min, double scale_max, [MarshalAs(UnmanagedType.LPStr)] string label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotHeatmap_S32Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, int* values, int rows, int cols, double scale_min, double scale_max, [MarshalAs(UnmanagedType.LPStr)] string label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotHeatmap_U32Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, uint* values, int rows, int cols, double scale_min, double scale_max, [MarshalAs(UnmanagedType.LPStr)] string label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotHeatmap_S64Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, long* values, int rows, int cols, double scale_min, double scale_max, [MarshalAs(UnmanagedType.LPStr)] string label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotHeatmap_U64Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, ulong* values, int rows, int cols, double scale_min, double scale_max, [MarshalAs(UnmanagedType.LPStr)] string label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_PlotHistogram_FloatPtr([MarshalAs(UnmanagedType.LPStr)] string label_id, float* values, int count, int bins, [MarshalAs(UnmanagedType.Bool)] bool cumulative, [MarshalAs(UnmanagedType.Bool)] bool density, ImPlotRange range, [MarshalAs(UnmanagedType.Bool)] bool outliers, double bar_scale);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_PlotHistogram_doublePtr([MarshalAs(UnmanagedType.LPStr)] string label_id, double* values, int count, int bins, [MarshalAs(UnmanagedType.Bool)] bool cumulative, [MarshalAs(UnmanagedType.Bool)] bool density, ImPlotRange range, [MarshalAs(UnmanagedType.Bool)] bool outliers, double bar_scale);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_PlotHistogram_S8Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, sbyte* values, int count, int bins, [MarshalAs(UnmanagedType.Bool)] bool cumulative, [MarshalAs(UnmanagedType.Bool)] bool density, ImPlotRange range, [MarshalAs(UnmanagedType.Bool)] bool outliers, double bar_scale);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_PlotHistogram_U8Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, byte* values, int count, int bins, [MarshalAs(UnmanagedType.Bool)] bool cumulative, [MarshalAs(UnmanagedType.Bool)] bool density, ImPlotRange range, [MarshalAs(UnmanagedType.Bool)] bool outliers, double bar_scale);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_PlotHistogram_S16Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, short* values, int count, int bins, [MarshalAs(UnmanagedType.Bool)] bool cumulative, [MarshalAs(UnmanagedType.Bool)] bool density, ImPlotRange range, [MarshalAs(UnmanagedType.Bool)] bool outliers, double bar_scale);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_PlotHistogram_U16Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, ushort* values, int count, int bins, [MarshalAs(UnmanagedType.Bool)] bool cumulative, [MarshalAs(UnmanagedType.Bool)] bool density, ImPlotRange range, [MarshalAs(UnmanagedType.Bool)] bool outliers, double bar_scale);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_PlotHistogram_S32Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, int* values, int count, int bins, [MarshalAs(UnmanagedType.Bool)] bool cumulative, [MarshalAs(UnmanagedType.Bool)] bool density, ImPlotRange range, [MarshalAs(UnmanagedType.Bool)] bool outliers, double bar_scale);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_PlotHistogram_U32Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, uint* values, int count, int bins, [MarshalAs(UnmanagedType.Bool)] bool cumulative, [MarshalAs(UnmanagedType.Bool)] bool density, ImPlotRange range, [MarshalAs(UnmanagedType.Bool)] bool outliers, double bar_scale);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_PlotHistogram_S64Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, long* values, int count, int bins, [MarshalAs(UnmanagedType.Bool)] bool cumulative, [MarshalAs(UnmanagedType.Bool)] bool density, ImPlotRange range, [MarshalAs(UnmanagedType.Bool)] bool outliers, double bar_scale);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_PlotHistogram_U64Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, ulong* values, int count, int bins, [MarshalAs(UnmanagedType.Bool)] bool cumulative, [MarshalAs(UnmanagedType.Bool)] bool density, ImPlotRange range, [MarshalAs(UnmanagedType.Bool)] bool outliers, double bar_scale);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_PlotHistogram2D_FloatPtr([MarshalAs(UnmanagedType.LPStr)] string label_id, float* xs, float* ys, int count, int x_bins, int y_bins, [MarshalAs(UnmanagedType.Bool)] bool density, ImPlotRect range, [MarshalAs(UnmanagedType.Bool)] bool outliers);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_PlotHistogram2D_doublePtr([MarshalAs(UnmanagedType.LPStr)] string label_id, double* xs, double* ys, int count, int x_bins, int y_bins, [MarshalAs(UnmanagedType.Bool)] bool density, ImPlotRect range, [MarshalAs(UnmanagedType.Bool)] bool outliers);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_PlotHistogram2D_S8Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, sbyte* xs, sbyte* ys, int count, int x_bins, int y_bins, [MarshalAs(UnmanagedType.Bool)] bool density, ImPlotRect range, [MarshalAs(UnmanagedType.Bool)] bool outliers);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_PlotHistogram2D_U8Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, byte* xs, byte* ys, int count, int x_bins, int y_bins, [MarshalAs(UnmanagedType.Bool)] bool density, ImPlotRect range, [MarshalAs(UnmanagedType.Bool)] bool outliers);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_PlotHistogram2D_S16Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, short* xs, short* ys, int count, int x_bins, int y_bins, [MarshalAs(UnmanagedType.Bool)] bool density, ImPlotRect range, [MarshalAs(UnmanagedType.Bool)] bool outliers);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_PlotHistogram2D_U16Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, ushort* xs, ushort* ys, int count, int x_bins, int y_bins, [MarshalAs(UnmanagedType.Bool)] bool density, ImPlotRect range, [MarshalAs(UnmanagedType.Bool)] bool outliers);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_PlotHistogram2D_S32Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, int* xs, int* ys, int count, int x_bins, int y_bins, [MarshalAs(UnmanagedType.Bool)] bool density, ImPlotRect range, [MarshalAs(UnmanagedType.Bool)] bool outliers);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_PlotHistogram2D_U32Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, uint* xs, uint* ys, int count, int x_bins, int y_bins, [MarshalAs(UnmanagedType.Bool)] bool density, ImPlotRect range, [MarshalAs(UnmanagedType.Bool)] bool outliers);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_PlotHistogram2D_S64Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, long* xs, long* ys, int count, int x_bins, int y_bins, [MarshalAs(UnmanagedType.Bool)] bool density, ImPlotRect range, [MarshalAs(UnmanagedType.Bool)] bool outliers);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_PlotHistogram2D_U64Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, ulong* xs, ulong* ys, int count, int x_bins, int y_bins, [MarshalAs(UnmanagedType.Bool)] bool density, ImPlotRect range, [MarshalAs(UnmanagedType.Bool)] bool outliers);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotImage([MarshalAs(UnmanagedType.LPStr)] string label_id, IntPtr user_texture_id, ImPlotPoint bounds_min, ImPlotPoint bounds_max, Vector2 uv0, Vector2 uv1, Vector4 tint_col);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotLine_FloatPtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, float* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotLine_doublePtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, double* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotLine_S8PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, sbyte* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotLine_U8PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, byte* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotLine_S16PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, short* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotLine_U16PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, ushort* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotLine_S32PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, int* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotLine_U32PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, uint* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotLine_S64PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, long* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotLine_U64PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, ulong* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotLine_FloatPtrFloatPtr([MarshalAs(UnmanagedType.LPStr)] string label_id, float* xs, float* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotLine_doublePtrdoublePtr([MarshalAs(UnmanagedType.LPStr)] string label_id, double* xs, double* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotLine_S8PtrS8Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, sbyte* xs, sbyte* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotLine_U8PtrU8Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, byte* xs, byte* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotLine_S16PtrS16Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, short* xs, short* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotLine_U16PtrU16Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, ushort* xs, ushort* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotLine_S32PtrS32Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, int* xs, int* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotLine_U32PtrU32Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, uint* xs, uint* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotLine_S64PtrS64Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, long* xs, long* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotLine_U64PtrU64Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, ulong* xs, ulong* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotLineG([MarshalAs(UnmanagedType.LPStr)] string label_id, ImPlotPoint* getter, void* data, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotPieChart_FloatPtr(byte** label_ids, float* values, int count, double x, double y, double radius, [MarshalAs(UnmanagedType.Bool)] bool normalize, [MarshalAs(UnmanagedType.LPStr)] string label_fmt, double angle0);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotPieChart_doublePtr(byte** label_ids, double* values, int count, double x, double y, double radius, [MarshalAs(UnmanagedType.Bool)] bool normalize, [MarshalAs(UnmanagedType.LPStr)] string label_fmt, double angle0);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotPieChart_S8Ptr(byte** label_ids, sbyte* values, int count, double x, double y, double radius, [MarshalAs(UnmanagedType.Bool)] bool normalize, [MarshalAs(UnmanagedType.LPStr)] string label_fmt, double angle0);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotPieChart_U8Ptr(byte** label_ids, byte* values, int count, double x, double y, double radius, [MarshalAs(UnmanagedType.Bool)] bool normalize, [MarshalAs(UnmanagedType.LPStr)] string label_fmt, double angle0);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotPieChart_S16Ptr(byte** label_ids, short* values, int count, double x, double y, double radius, [MarshalAs(UnmanagedType.Bool)] bool normalize, [MarshalAs(UnmanagedType.LPStr)] string label_fmt, double angle0);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotPieChart_U16Ptr(byte** label_ids, ushort* values, int count, double x, double y, double radius, [MarshalAs(UnmanagedType.Bool)] bool normalize, [MarshalAs(UnmanagedType.LPStr)] string label_fmt, double angle0);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotPieChart_S32Ptr(byte** label_ids, int* values, int count, double x, double y, double radius, [MarshalAs(UnmanagedType.Bool)] bool normalize, [MarshalAs(UnmanagedType.LPStr)] string label_fmt, double angle0);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotPieChart_U32Ptr(byte** label_ids, uint* values, int count, double x, double y, double radius, [MarshalAs(UnmanagedType.Bool)] bool normalize, [MarshalAs(UnmanagedType.LPStr)] string label_fmt, double angle0);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotPieChart_S64Ptr(byte** label_ids, long* values, int count, double x, double y, double radius, [MarshalAs(UnmanagedType.Bool)] bool normalize, [MarshalAs(UnmanagedType.LPStr)] string label_fmt, double angle0);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotPieChart_U64Ptr(byte** label_ids, ulong* values, int count, double x, double y, double radius, [MarshalAs(UnmanagedType.Bool)] bool normalize, [MarshalAs(UnmanagedType.LPStr)] string label_fmt, double angle0);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotScatter_FloatPtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, float* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotScatter_doublePtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, double* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotScatter_S8PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, sbyte* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotScatter_U8PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, byte* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotScatter_S16PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, short* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotScatter_U16PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, ushort* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotScatter_S32PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, int* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotScatter_U32PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, uint* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotScatter_S64PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, long* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotScatter_U64PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, ulong* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotScatter_FloatPtrFloatPtr([MarshalAs(UnmanagedType.LPStr)] string label_id, float* xs, float* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotScatter_doublePtrdoublePtr([MarshalAs(UnmanagedType.LPStr)] string label_id, double* xs, double* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotScatter_S8PtrS8Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, sbyte* xs, sbyte* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotScatter_U8PtrU8Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, byte* xs, byte* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotScatter_S16PtrS16Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, short* xs, short* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotScatter_U16PtrU16Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, ushort* xs, ushort* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotScatter_S32PtrS32Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, int* xs, int* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotScatter_U32PtrU32Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, uint* xs, uint* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotScatter_S64PtrS64Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, long* xs, long* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotScatter_U64PtrU64Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, ulong* xs, ulong* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotScatterG([MarshalAs(UnmanagedType.LPStr)] string label_id, ImPlotPoint* getter, void* data, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_FloatPtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, float* values, int count, double yref, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_doublePtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, double* values, int count, double yref, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_S8PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, sbyte* values, int count, double yref, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_U8PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, byte* values, int count, double yref, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_S16PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, short* values, int count, double yref, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_U16PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, ushort* values, int count, double yref, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_S32PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, int* values, int count, double yref, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_U32PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, uint* values, int count, double yref, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_S64PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, long* values, int count, double yref, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_U64PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, ulong* values, int count, double yref, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_FloatPtrFloatPtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, float* xs, float* ys, int count, double yref, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_doublePtrdoublePtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, double* xs, double* ys, int count, double yref, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_S8PtrS8PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, sbyte* xs, sbyte* ys, int count, double yref, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_U8PtrU8PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, byte* xs, byte* ys, int count, double yref, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_S16PtrS16PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, short* xs, short* ys, int count, double yref, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_U16PtrU16PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, ushort* xs, ushort* ys, int count, double yref, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_S32PtrS32PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, int* xs, int* ys, int count, double yref, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_U32PtrU32PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, uint* xs, uint* ys, int count, double yref, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_S64PtrS64PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, long* xs, long* ys, int count, double yref, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_U64PtrU64PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, ulong* xs, ulong* ys, int count, double yref, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_FloatPtrFloatPtrFloatPtr([MarshalAs(UnmanagedType.LPStr)] string label_id, float* xs, float* ys1, float* ys2, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_doublePtrdoublePtrdoublePtr([MarshalAs(UnmanagedType.LPStr)] string label_id, double* xs, double* ys1, double* ys2, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_S8PtrS8PtrS8Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, sbyte* xs, sbyte* ys1, sbyte* ys2, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_U8PtrU8PtrU8Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, byte* xs, byte* ys1, byte* ys2, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_S16PtrS16PtrS16Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, short* xs, short* ys1, short* ys2, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_U16PtrU16PtrU16Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, ushort* xs, ushort* ys1, ushort* ys2, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_S32PtrS32PtrS32Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, int* xs, int* ys1, int* ys2, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_U32PtrU32PtrU32Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, uint* xs, uint* ys1, uint* ys2, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_S64PtrS64PtrS64Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, long* xs, long* ys1, long* ys2, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_U64PtrU64PtrU64Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, ulong* xs, ulong* ys1, ulong* ys2, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShadedG([MarshalAs(UnmanagedType.LPStr)] string label_id, ImPlotPoint* getter1, void* data1, ImPlotPoint* getter2, void* data2, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStairs_FloatPtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, float* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStairs_doublePtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, double* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStairs_S8PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, sbyte* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStairs_U8PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, byte* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStairs_S16PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, short* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStairs_U16PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, ushort* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStairs_S32PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, int* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStairs_U32PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, uint* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStairs_S64PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, long* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStairs_U64PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, ulong* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStairs_FloatPtrFloatPtr([MarshalAs(UnmanagedType.LPStr)] string label_id, float* xs, float* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStairs_doublePtrdoublePtr([MarshalAs(UnmanagedType.LPStr)] string label_id, double* xs, double* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStairs_S8PtrS8Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, sbyte* xs, sbyte* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStairs_U8PtrU8Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, byte* xs, byte* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStairs_S16PtrS16Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, short* xs, short* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStairs_U16PtrU16Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, ushort* xs, ushort* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStairs_S32PtrS32Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, int* xs, int* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStairs_U32PtrU32Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, uint* xs, uint* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStairs_S64PtrS64Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, long* xs, long* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStairs_U64PtrU64Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, ulong* xs, ulong* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStairsG([MarshalAs(UnmanagedType.LPStr)] string label_id, ImPlotPoint* getter, void* data, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStems_FloatPtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, float* values, int count, double yref, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStems_doublePtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, double* values, int count, double yref, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStems_S8PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, sbyte* values, int count, double yref, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStems_U8PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, byte* values, int count, double yref, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStems_S16PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, short* values, int count, double yref, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStems_U16PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, ushort* values, int count, double yref, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStems_S32PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, int* values, int count, double yref, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStems_U32PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, uint* values, int count, double yref, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStems_S64PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, long* values, int count, double yref, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStems_U64PtrInt([MarshalAs(UnmanagedType.LPStr)] string label_id, ulong* values, int count, double yref, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStems_FloatPtrFloatPtr([MarshalAs(UnmanagedType.LPStr)] string label_id, float* xs, float* ys, int count, double yref, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStems_doublePtrdoublePtr([MarshalAs(UnmanagedType.LPStr)] string label_id, double* xs, double* ys, int count, double yref, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStems_S8PtrS8Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, sbyte* xs, sbyte* ys, int count, double yref, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStems_U8PtrU8Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, byte* xs, byte* ys, int count, double yref, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStems_S16PtrS16Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, short* xs, short* ys, int count, double yref, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStems_U16PtrU16Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, ushort* xs, ushort* ys, int count, double yref, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStems_S32PtrS32Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, int* xs, int* ys, int count, double yref, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStems_U32PtrU32Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, uint* xs, uint* ys, int count, double yref, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStems_S64PtrS64Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, long* xs, long* ys, int count, double yref, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStems_U64PtrU64Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, ulong* xs, ulong* ys, int count, double yref, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotText([MarshalAs(UnmanagedType.LPStr)] string text, double x, double y, [MarshalAs(UnmanagedType.Bool)] bool vertical, Vector2 pix_offset);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotToPixels_PlotPoInt(Vector2* pOut, ImPlotPoint plt, ImAxis x_axis, ImAxis y_axis);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotToPixels_double(Vector2* pOut, double x, double y, ImAxis x_axis, ImAxis y_axis);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotVLines_FloatPtr([MarshalAs(UnmanagedType.LPStr)] string label_id, float* xs, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotVLines_doublePtr([MarshalAs(UnmanagedType.LPStr)] string label_id, double* xs, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotVLines_S8Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, sbyte* xs, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotVLines_U8Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, byte* xs, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotVLines_S16Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, short* xs, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotVLines_U16Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, ushort* xs, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotVLines_S32Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, int* xs, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotVLines_U32Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, uint* xs, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotVLines_S64Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, long* xs, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotVLines_U64Ptr([MarshalAs(UnmanagedType.LPStr)] string label_id, ulong* xs, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PopColormap(int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PopPlotClipRect();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PopStyleColor(int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PopStyleVar(int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PushColormap_PlotColormap(ImPlotColormap cmap);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PushColormap_Str([MarshalAs(UnmanagedType.LPStr)] string name);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PushPlotClipRect(float expand);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PushStyleColor_U32(ImPlotCol idx, uint col);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PushStyleColor_Vec4(ImPlotCol idx, Vector4 col);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PushStyleVar_Float(ImPlotStyleVar idx, float val);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PushStyleVar_Int(ImPlotStyleVar idx, int val);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PushStyleVar_Vec2(ImPlotStyleVar idx, Vector2 val);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_SampleColormap(Vector4* pOut, float t, ImPlotColormap cmap);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_SetAxes(ImAxis x_axis, ImAxis y_axis);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_SetAxis(ImAxis axis);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_SetCurrentContext(IntPtr ctx);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_SetImGuiContext(IntPtr ctx);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_SetNextAxesLimits(double x_min, double x_max, double y_min, double y_max, ImPlotCond cond);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_SetNextAxesToFit();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_SetNextAxisLimits(ImAxis axis, double v_min, double v_max, ImPlotCond cond);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_SetNextAxisLinks(ImAxis axis, double* link_min, double* link_max);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_SetNextAxisToFit(ImAxis axis);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_SetNextErrorBarStyle(Vector4 col, float size, float weight);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_SetNextFillStyle(Vector4 col, float alpha_mod);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_SetNextLineStyle(Vector4 col, float weight);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_SetNextMarkerStyle(ImPlotMarker marker, float size, Vector4 fill, float weight, Vector4 outline);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_SetupAxes([MarshalAs(UnmanagedType.LPStr)] string x_label, [MarshalAs(UnmanagedType.LPStr)] string y_label, ImPlotAxisFlags x_flags, ImPlotAxisFlags y_flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_SetupAxesLimits(double x_min, double x_max, double y_min, double y_max, ImPlotCond cond);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_SetupAxis(ImAxis axis, [MarshalAs(UnmanagedType.LPStr)] string label, ImPlotAxisFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_SetupAxisFormat_Str(ImAxis axis, [MarshalAs(UnmanagedType.LPStr)] string fmt);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_SetupAxisFormat_PlotFormatter(ImAxis axis, void* formatter, void* data);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_SetupAxisLimits(ImAxis axis, double v_min, double v_max, ImPlotCond cond);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_SetupAxisLinks(ImAxis axis, double* link_min, double* link_max);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_SetupAxisTicks_doublePtr(ImAxis axis, double* values, int n_ticks, byte** labels, [MarshalAs(UnmanagedType.Bool)] bool keep_default);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_SetupAxisTicks_double(ImAxis axis, double v_min, double v_max, int n_ticks, byte** labels, [MarshalAs(UnmanagedType.Bool)] bool keep_default);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_SetupFinish();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_SetupLegend(ImPlotLocation location, ImPlotLegendFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_SetupMouseText(ImPlotLocation location, ImPlotMouseTextFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.Bool)]
		public static extern bool ImPlot_ShowColormapSelector([MarshalAs(UnmanagedType.LPStr)] string label);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_ShowDemoWindow([MarshalAs(UnmanagedType.Bool)] bool p_open);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.Bool)]
		public static extern bool ImPlot_ShowInputMapSelector([MarshalAs(UnmanagedType.LPStr)] string label);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_ShowMetricsWindow([MarshalAs(UnmanagedType.Bool)] bool p_popen);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_ShowStyleEditor(ImPlotStyle* @ref);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.Bool)]
		public static extern bool ImPlot_ShowStyleSelector([MarshalAs(UnmanagedType.LPStr)] string label);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_ShowUserGuide();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_StyleColorsAuto(ImPlotStyle* dst);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_StyleColorsClassic(ImPlotStyle* dst);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_StyleColorsDark(ImPlotStyle* dst);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_StyleColorsLight(ImPlotStyle* dst);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_TagX_Bool(double x, Vector4 color, [MarshalAs(UnmanagedType.Bool)] bool round);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_TagX_Str(double x, Vector4 color, [MarshalAs(UnmanagedType.LPStr)] string fmt);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_TagY_Bool(double y, Vector4 color, [MarshalAs(UnmanagedType.Bool)] bool round);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_TagY_Str(double y, Vector4 color, [MarshalAs(UnmanagedType.LPStr)] string fmt);

	}
}
