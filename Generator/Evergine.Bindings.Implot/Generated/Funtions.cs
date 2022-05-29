using Evergine.Mathematics;
using Evergine.Bindings.Imgui;
using System;
using System.Runtime.InteropServices;

namespace Evergine.Bindings.Implot
{
	public static unsafe partial class ImplotNative
	{
		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotAlignmentData_Begin(ImPlotAlignmentData* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotAlignmentData_End(ImPlotAlignmentData* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotAlignmentData_ImPlotAlignmentData();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotAlignmentData_Reset(ImPlotAlignmentData* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotAlignmentData_Update(ImPlotAlignmentData* self, float* pad_a, float* pad_b, float* delta_a, float* delta_b);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotAlignmentData_destroy(ImPlotAlignmentData* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotAnnotationCollection_Append(ImPlotAnnotationCollection* self, Vector2 pos, Vector2 off, uint bg, uint fg, byte clamp, byte* fmt, ... ...);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotAnnotationCollection_AppendV(ImPlotAnnotationCollection* self, Vector2 pos, Vector2 off, uint bg, uint fg, byte clamp, byte* fmt, va_list args);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ImPlotAnnotationCollection_GetText(ImPlotAnnotationCollection* self, int idx);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotAnnotationCollection_ImPlotAnnotationCollection();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotAnnotationCollection_Reset(ImPlotAnnotationCollection* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotAnnotationCollection_destroy(ImPlotAnnotationCollection* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotAxis_ApplyFit(ImPlotAxis* self, float padding);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlotAxis_CanInitFit(ImPlotAxis* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotAxis_Constrain(ImPlotAxis* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotAxis_ExtendFit(ImPlotAxis* self, double v);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotAxis_ExtendFitWith(ImPlotAxis* self, ImPlotAxis* alt, double v, double v_alt);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlotAxis_GetAspect(ImPlotAxis* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlotAxis_HasGridLines(ImPlotAxis* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlotAxis_HasLabel(ImPlotAxis* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlotAxis_HasMenus(ImPlotAxis* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlotAxis_HasTickLabels(ImPlotAxis* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlotAxis_HasTickMarks(ImPlotAxis* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotAxis_ImPlotAxis();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlotAxis_IsAutoFitting(ImPlotAxis* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlotAxis_IsForeground(ImPlotAxis* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlotAxis_IsInputLocked(ImPlotAxis* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlotAxis_IsInputLockedMax(ImPlotAxis* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlotAxis_IsInputLockedMin(ImPlotAxis* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlotAxis_IsInverted(ImPlotAxis* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlotAxis_IsLocked(ImPlotAxis* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlotAxis_IsLockedMax(ImPlotAxis* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlotAxis_IsLockedMin(ImPlotAxis* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlotAxis_IsLog(ImPlotAxis* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlotAxis_IsOpposite(ImPlotAxis* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlotAxis_IsRangeLocked(ImPlotAxis* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlotAxis_IsTime(ImPlotAxis* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern float ImPlotAxis_PixelSize(ImPlotAxis* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlotAxis_PixelsToPlot(ImPlotAxis* self, float pix);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern float ImPlotAxis_PlotToPixels(ImPlotAxis* self, double plt);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotAxis_PullLinks(ImPlotAxis* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotAxis_PushLinks(ImPlotAxis* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotAxis_Reset(ImPlotAxis* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotAxis_SetAspect(ImPlotAxis* self, double unit_per_pix);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlotAxis_SetMax(ImPlotAxis* self, double _max, byte force);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlotAxis_SetMin(ImPlotAxis* self, double _min, byte force);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotAxis_SetRange_double(ImPlotAxis* self, double v1, double v2);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotAxis_SetRange_PlotRange(ImPlotAxis* self, ImPlotRange range);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotAxis_UpdateTransformCache(ImPlotAxis* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlotAxis_WillRender(ImPlotAxis* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotAxis_destroy(ImPlotAxis* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImPlotColormapData_Append(ImPlotColormapData* self, byte* name, uint* keys, int count, byte qual);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImPlotColormap ImPlotColormapData_GetIndex(ImPlotColormapData* self, byte* name);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ImPlotColormapData_GetKeyColor(ImPlotColormapData* self, ImPlotColormap cmap, int idx);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImPlotColormapData_GetKeyCount(ImPlotColormapData* self, ImPlotColormap cmap);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint* ImPlotColormapData_GetKeys(ImPlotColormapData* self, ImPlotColormap cmap);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ImPlotColormapData_GetName(ImPlotColormapData* self, ImPlotColormap cmap);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint* ImPlotColormapData_GetTable(ImPlotColormapData* self, ImPlotColormap cmap);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ImPlotColormapData_GetTableColor(ImPlotColormapData* self, ImPlotColormap cmap, int idx);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImPlotColormapData_GetTableSize(ImPlotColormapData* self, ImPlotColormap cmap);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotColormapData_ImPlotColormapData();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlotColormapData_IsQual(ImPlotColormapData* self, ImPlotColormap cmap);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ImPlotColormapData_LerpTable(ImPlotColormapData* self, ImPlotColormap cmap, float t);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotColormapData_RebuildTables(ImPlotColormapData* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotColormapData_SetKeyColor(ImPlotColormapData* self, ImPlotColormap cmap, int idx, uint value);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotColormapData__AppendTable(ImPlotColormapData* self, ImPlotColormap cmap);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotColormapData_destroy(ImPlotColormapData* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotDateTimeFmt_ImPlotDateTimeFmt(ImPlotDateFmt date_fmt, ImPlotTimeFmt time_fmt, byte use_24_hr_clk, byte use_iso_8601);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotDateTimeFmt_destroy(ImPlotDateTimeFmt* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotInputMap_ImPlotInputMap();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotInputMap_destroy(ImPlotInputMap* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImPlotItem* ImPlotItemGroup_GetItem_ID(ImPlotItemGroup* self, ImGuiID id);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImPlotItem* ImPlotItemGroup_GetItem_Str(ImPlotItemGroup* self, byte* label_id);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImPlotItem* ImPlotItemGroup_GetItemByIndex(ImPlotItemGroup* self, int i);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImPlotItemGroup_GetItemCount(ImPlotItemGroup* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiID ImPlotItemGroup_GetItemID(ImPlotItemGroup* self, byte* label_id);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImPlotItemGroup_GetItemIndex(ImPlotItemGroup* self, ImPlotItem* item);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImPlotItemGroup_GetLegendCount(ImPlotItemGroup* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImPlotItem* ImPlotItemGroup_GetLegendItem(ImPlotItemGroup* self, int i);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ImPlotItemGroup_GetLegendLabel(ImPlotItemGroup* self, int i);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImPlotItem* ImPlotItemGroup_GetOrAddItem(ImPlotItemGroup* self, ImGuiID id);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotItemGroup_ImPlotItemGroup();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotItemGroup_Reset(ImPlotItemGroup* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotItemGroup_destroy(ImPlotItemGroup* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotItem_ImPlotItem();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotItem_destroy(ImPlotItem* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotLegend_ImPlotLegend();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotLegend_Reset(ImPlotLegend* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotLegend_destroy(ImPlotLegend* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotNextItemData_ImPlotNextItemData();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotNextItemData_Reset(ImPlotNextItemData* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotNextItemData_destroy(ImPlotNextItemData* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotNextPlotData_ImPlotNextPlotData();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotNextPlotData_Reset(ImPlotNextPlotData* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotNextPlotData_destroy(ImPlotNextPlotData* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotPlot_ClearTextBuffer(ImPlotPlot* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImPlotPlot_EnabledAxesX(ImPlotPlot* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImPlotPlot_EnabledAxesY(ImPlotPlot* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ImPlotPlot_GetAxisLabel(ImPlotPlot* self, ImPlotAxis axis);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ImPlotPlot_GetTitle(ImPlotPlot* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlotPlot_HasTitle(ImPlotPlot* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotPlot_ImPlotPlot();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlotPlot_IsInputLocked(ImPlotPlot* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotPlot_SetAxisLabel(ImPlotPlot* self, ImPlotAxis* axis, byte* label);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotPlot_SetTitle(ImPlotPlot* self, byte* title);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImPlotAxis* ImPlotPlot_XAxis_Nil(ImPlotPlot* self, int i);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImPlotAxis* ImPlotPlot_XAxis__const(ImPlotPlot* self, int i);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImPlotAxis* ImPlotPlot_YAxis_Nil(ImPlotPlot* self, int i);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImPlotAxis* ImPlotPlot_YAxis__const(ImPlotPlot* self, int i);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotPlot_destroy(ImPlotPlot* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotPointError_ImPlotPointError(double x, double y, double neg, double pos);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotPointError_destroy(ImPlotPointError* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotPoint_ImPlotPoint_Nil();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotPoint_ImPlotPoint_double(double _x, double _y);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotPoint_ImPlotPoint_Vec2(Vector2 p);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotPoint_destroy(ImPlotPoint* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlotRange_Clamp(ImPlotRange* self, double value);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlotRange_Contains(ImPlotRange* self, double value);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotRange_ImPlotRange_Nil();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotRange_ImPlotRange_double(double _min, double _max);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlotRange_Size(ImPlotRange* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotRange_destroy(ImPlotRange* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotRect_Clamp_PlotPoInt(ImPlotPoint* pOut, ImPlotRect* self, ImPlotPoint p);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotRect_Clamp_double(ImPlotPoint* pOut, ImPlotRect* self, double x, double y);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlotRect_Contains_PlotPoInt(ImPlotRect* self, ImPlotPoint p);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlotRect_Contains_double(ImPlotRect* self, double x, double y);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotRect_ImPlotRect_Nil();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotRect_ImPlotRect_double(double x_min, double x_max, double y_min, double y_max);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotRect_Max(ImPlotPoint* pOut, ImPlotRect* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotRect_Min(ImPlotPoint* pOut, ImPlotRect* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotRect_Size(ImPlotPoint* pOut, ImPlotRect* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotRect_destroy(ImPlotRect* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotStyle_ImPlotStyle();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotStyle_destroy(ImPlotStyle* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotSubplot_ImPlotSubplot();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotSubplot_destroy(ImPlotSubplot* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotTagCollection_Append(ImPlotTagCollection* self, ImAxis axis, double value, uint bg, uint fg, byte* fmt, ... ...);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotTagCollection_AppendV(ImPlotTagCollection* self, ImAxis axis, double value, uint bg, uint fg, byte* fmt, va_list args);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ImPlotTagCollection_GetText(ImPlotTagCollection* self, int idx);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotTagCollection_ImPlotTagCollection();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotTagCollection_Reset(ImPlotTagCollection* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotTagCollection_destroy(ImPlotTagCollection* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImPlotTick* ImPlotTickCollection_Append_PlotTick(ImPlotTickCollection* self, ImPlotTick tick);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImPlotTick* ImPlotTickCollection_Append_double(ImPlotTickCollection* self, double value, byte major, byte show_label, ImPlotFormatter formatter, void* data);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ImPlotTickCollection_GetText(ImPlotTickCollection* self, int idx);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotTickCollection_ImPlotTickCollection();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotTickCollection_OverrideSize(ImPlotTickCollection* self, Vector2 size);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotTickCollection_OverrideSizeLate(ImPlotTickCollection* self, Vector2 size);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotTickCollection_Reset(ImPlotTickCollection* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotTickCollection_destroy(ImPlotTickCollection* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotTick_ImPlotTick(double value, byte major, byte show_label);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotTick_destroy(ImPlotTick* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotTime_FromDouble(ImPlotTime* pOut, double t);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotTime_ImPlotTime_Nil();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotTime_ImPlotTime_time_t(time_t s, int us);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotTime_RollOver(ImPlotTime* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlotTime_ToDouble(ImPlotTime* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlotTime_destroy(ImPlotTime* self);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImPlotColormap ImPlot_AddColormap_Vec4Ptr(byte* name, Vector4* cols, int size, byte qual);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImPlotColormap ImPlot_AddColormap_U32Ptr(byte* name, uint* cols, int size, byte qual);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_AddTextCentered(ImDrawList* DrawList, Vector2 top_center, uint col, byte* text_begin, byte* text_end);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_AddTextVertical(ImDrawList* DrawList, Vector2 pos, uint col, byte* text_begin, byte* text_end);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_AddTicksCustom(double* values, char* const[] labels, int n, ImPlotTickCollection* ticks, ImPlotFormatter formatter, void* data);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_AddTicksDefault(ImPlotRange range, float pix, byte vertical, ImPlotTickCollection* ticks, ImPlotFormatter formatter, void* data);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_AddTicksLogarithmic(ImPlotRange range, float pix, byte vertical, ImPlotTickCollection* ticks, ImPlotFormatter formatter, void* data);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_AddTicksTime(ImPlotRange range, float plot_width, ImPlotTickCollection* ticks);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_AddTime(ImPlotTime* pOut, ImPlotTime t, ImPlotTimeUnit unit, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_AllAxesInputLocked(ImPlotAxis* axes, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_Annotation_Bool(double x, double y, Vector4 color, Vector2 pix_offset, byte clamp, byte round);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_Annotation_Str(double x, double y, Vector4 color, Vector2 pix_offset, byte clamp, byte* fmt, ... ...);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_AnnotationV(double x, double y, Vector4 color, Vector2 pix_offset, byte clamp, byte* fmt, va_list args);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_AnyAxesHeld(ImPlotAxis* axes, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_AnyAxesHovered(ImPlotAxis* axes, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_AnyAxesInputLocked(ImPlotAxis* axes, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_BeginAlignedPlots(byte* group_id, byte vertical);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_BeginDragDropSourceAxis(ImAxis axis, ImGuiDragDropFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_BeginDragDropSourceItem(byte* label_id, ImGuiDragDropFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_BeginDragDropSourcePlot(ImGuiDragDropFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_BeginDragDropTargetAxis(ImAxis axis);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_BeginDragDropTargetLegend();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_BeginDragDropTargetPlot();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_BeginItem(byte* label_id, ImPlotCol recolor_from);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_BeginLegendPopup(byte* label_id, ImGuiMouseButton mouse_button);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_BeginPlot(byte* title_id, Vector2 size, ImPlotFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_BeginSubplots(byte* title_id, int rows, int cols, Vector2 size, ImPlotSubplotFlags flags, float* row_ratios, float* col_ratios);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_BustColorCache(byte* plot_title_id);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_BustItemCache();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_BustPlotCache();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ImPlot_CalcHoverColor(uint col);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_CalcLegendSize(Vector2* pOut, ImPlotItemGroup* items, Vector2 pad, Vector2 spacing, byte vertical);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ImPlot_CalcTextColor_Vec4(Vector4 bg);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ImPlot_CalcTextColor_U32(uint bg);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_CalcTextSizeVertical(Vector2* pOut, byte* text);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_CalculateBins_FloatPtr(float* values, int count, ImPlotBin meth, ImPlotRange range, int* bins_out, double* width_out);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_CalculateBins_doublePtr(double* values, int count, ImPlotBin meth, ImPlotRange range, int* bins_out, double* width_out);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_CalculateBins_S8Ptr(sbyte* values, int count, ImPlotBin meth, ImPlotRange range, int* bins_out, double* width_out);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_CalculateBins_U8Ptr(byte* values, int count, ImPlotBin meth, ImPlotRange range, int* bins_out, double* width_out);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_CalculateBins_S16Ptr(short* values, int count, ImPlotBin meth, ImPlotRange range, int* bins_out, double* width_out);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_CalculateBins_U16Ptr(ushort* values, int count, ImPlotBin meth, ImPlotRange range, int* bins_out, double* width_out);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_CalculateBins_S32Ptr(int* values, int count, ImPlotBin meth, ImPlotRange range, int* bins_out, double* width_out);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_CalculateBins_U32Ptr(uint* values, int count, ImPlotBin meth, ImPlotRange range, int* bins_out, double* width_out);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_CalculateBins_S64Ptr(long* values, int count, ImPlotBin meth, ImPlotRange range, int* bins_out, double* width_out);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_CalculateBins_U64Ptr(ulong* values, int count, ImPlotBin meth, ImPlotRange range, int* bins_out, double* width_out);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_CancelPlotSelection();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_CeilTime(ImPlotTime* pOut, ImPlotTime t, ImPlotTimeUnit unit);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_ClampLabelPos(Vector2* pOut, Vector2 pos, Vector2 size, Vector2 Min, Vector2 Max);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_ColormapButton(byte* label, Vector2 size, ImPlotColormap cmap);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_ColormapIcon(ImPlotColormap cmap);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_ColormapScale(byte* label, double scale_min, double scale_max, Vector2 size, ImPlotColormap cmap, byte* format);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_ColormapSlider(byte* label, float* t, Vector4* out, byte* format, ImPlotColormap cmap);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_CombineDateTime(ImPlotTime* pOut, ImPlotTime date_part, ImPlotTime time_part);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ImPlot_CreateContext();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_DestroyContext(IntPtr ctx);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_DragLineX(int id, double* x, Vector4 col, float thickness, ImPlotDragToolFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_DragLineY(int id, double* y, Vector4 col, float thickness, ImPlotDragToolFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_DragPoint(int id, double* x, double* y, Vector4 col, float size, ImPlotDragToolFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_DragRect(int id, double* x_min, double* y_min, double* x_max, double* y_max, Vector4 col, ImPlotDragToolFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_EndAlignedPlots();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_EndDragDropSource();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_EndDragDropTarget();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_EndItem();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_EndLegendPopup();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_EndPlot();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_EndSubplots();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_FillRange_Vector_Float_Ptr(ImVector_float * buffer, int n, float vmin, float vmax);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_FillRange_Vector_double_Ptr(ImVector_double * buffer, int n, double vmin, double vmax);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_FillRange_Vector_S8_Ptr(ImVector_ImS8 * buffer, int n, sbyte vmin, sbyte vmax);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_FillRange_Vector_U8_Ptr(ImVector_ImU8 * buffer, int n, byte vmin, byte vmax);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_FillRange_Vector_S16_Ptr(ImVector_ImS16 * buffer, int n, short vmin, short vmax);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_FillRange_Vector_U16_Ptr(ImVector_ImU16 * buffer, int n, ushort vmin, ushort vmax);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_FillRange_Vector_S32_Ptr(ImVector_ImS32 * buffer, int n, int vmin, int vmax);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_FillRange_Vector_U32_Ptr(ImVector_ImU32 * buffer, int n, uint vmin, uint vmax);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_FillRange_Vector_S64_Ptr(ImVector_ImS64 * buffer, int n, long vmin, long vmax);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_FillRange_Vector_U64_Ptr(ImVector_ImU64 * buffer, int n, ulong vmin, ulong vmax);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_FitPoint(ImPlotPoint p);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_FitPointX(double x);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_FitPointY(double y);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_FitThisFrame();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_FloorTime(ImPlotTime* pOut, ImPlotTime t, ImPlotTimeUnit unit);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImPlot_FormatDate(ImPlotTime t, byte* buffer, int size, ImPlotDateFmt fmt, byte use_iso_8601);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImPlot_FormatDateTime(ImPlotTime t, byte* buffer, int size, ImPlotDateTimeFmt fmt);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImPlot_FormatTime(ImPlotTime t, byte* buffer, int size, ImPlotTimeFmt fmt, byte use_24_hr_clk);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_GetAutoColor(Vector4* pOut, ImPlotCol idx);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_GetColormapColor(Vector4* pOut, int idx, ImPlotColormap cmap);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ImPlot_GetColormapColorU32(int idx, ImPlotColormap cmap);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImPlot_GetColormapCount();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImPlotColormap ImPlot_GetColormapIndex(byte* name);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ImPlot_GetColormapName(ImPlotColormap cmap);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImPlot_GetColormapSize(ImPlotColormap cmap);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ImPlot_GetCurrentContext();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImPlotItem* ImPlot_GetCurrentItem();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImPlotPlot* ImPlot_GetCurrentPlot();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImPlotScale ImPlot_GetCurrentScale();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImPlot_GetDaysInMonth(int year, int month);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern tm* ImPlot_GetGmtTime(ImPlotTime t, tm* ptm);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImPlotInputMap* ImPlot_GetInputMap();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImPlotItem* ImPlot_GetItem(byte* label_id);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImPlotNextItemData* ImPlot_GetItemData();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_GetLastItemColor(Vector4* pOut);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern tm* ImPlot_GetLocTime(ImPlotTime t, tm* ptm);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_GetLocationPos(Vector2* pOut, ImRect outer_rect, Vector2 inner_size, ImPlotLocation location, Vector2 pad);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ImPlot_GetMarkerName(ImPlotMarker idx);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImPlotPlot* ImPlot_GetPlot(byte* title);

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
		public static extern byte* ImPlot_GetStyleColorName(ImPlotCol idx);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ImPlot_GetStyleColorU32(ImPlotCol idx);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_GetStyleColorVec4(Vector4* pOut, ImPlotCol idx);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImPlot_GetYear(ImPlotTime t);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_HideNextItem(byte hidden, ImPlotCond cond);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_ImAlmostEqual(double v1, double v2, int ulp);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ImPlot_ImAlphaU32(uint col, float alpha);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_ImConstrainInf(double val);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_ImConstrainLog(double val);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_ImConstrainNan(double val);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_ImConstrainTime(double val);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ImPlot_ImLerpU32(uint* colors, int size, float t);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern float ImPlot_ImLog10_Float(float x);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_ImLog10_double(double x);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern float ImPlot_ImMaxArray_FloatPtr(float* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_ImMaxArray_doublePtr(double* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern sbyte ImPlot_ImMaxArray_S8Ptr(sbyte* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_ImMaxArray_U8Ptr(byte* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern short ImPlot_ImMaxArray_S16Ptr(short* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern ushort ImPlot_ImMaxArray_U16Ptr(ushort* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImPlot_ImMaxArray_S32Ptr(int* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ImPlot_ImMaxArray_U32Ptr(uint* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern long ImPlot_ImMaxArray_S64Ptr(long* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ImPlot_ImMaxArray_U64Ptr(ulong* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_ImMean_FloatPtr(float* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_ImMean_doublePtr(double* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_ImMean_S8Ptr(sbyte* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_ImMean_U8Ptr(byte* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_ImMean_S16Ptr(short* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_ImMean_U16Ptr(ushort* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_ImMean_S32Ptr(int* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_ImMean_U32Ptr(uint* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_ImMean_S64Ptr(long* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_ImMean_U64Ptr(ulong* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern float ImPlot_ImMinArray_FloatPtr(float* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_ImMinArray_doublePtr(double* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern sbyte ImPlot_ImMinArray_S8Ptr(sbyte* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_ImMinArray_U8Ptr(byte* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern short ImPlot_ImMinArray_S16Ptr(short* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern ushort ImPlot_ImMinArray_U16Ptr(ushort* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImPlot_ImMinArray_S32Ptr(int* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ImPlot_ImMinArray_U32Ptr(uint* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern long ImPlot_ImMinArray_S64Ptr(long* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ImPlot_ImMinArray_U64Ptr(ulong* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_ImMinMaxArray_FloatPtr(float* values, int count, float* min_out, float* max_out);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_ImMinMaxArray_doublePtr(double* values, int count, double* min_out, double* max_out);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_ImMinMaxArray_S8Ptr(sbyte* values, int count, sbyte* min_out, sbyte* max_out);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_ImMinMaxArray_U8Ptr(byte* values, int count, byte* min_out, byte* max_out);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_ImMinMaxArray_S16Ptr(short* values, int count, short* min_out, short* max_out);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_ImMinMaxArray_U16Ptr(ushort* values, int count, ushort* min_out, ushort* max_out);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_ImMinMaxArray_S32Ptr(int* values, int count, int* min_out, int* max_out);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_ImMinMaxArray_U32Ptr(uint* values, int count, uint* min_out, uint* max_out);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_ImMinMaxArray_S64Ptr(long* values, int count, long* min_out, long* max_out);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_ImMinMaxArray_U64Ptr(ulong* values, int count, ulong* min_out, ulong* max_out);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ImPlot_ImMixU32(uint a, uint b, uint s);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_ImNanOrInf(double val);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImPlot_ImPosMod(int l, int r);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern float ImPlot_ImRemap_Float(float x, float x0, float x1, float y0, float y1);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_ImRemap_double(double x, double x0, double x1, double y0, double y1);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern sbyte ImPlot_ImRemap_S8(sbyte x, sbyte x0, sbyte x1, sbyte y0, sbyte y1);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_ImRemap_U8(byte x, byte x0, byte x1, byte y0, byte y1);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern short ImPlot_ImRemap_S16(short x, short x0, short x1, short y0, short y1);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern ushort ImPlot_ImRemap_U16(ushort x, ushort x0, ushort x1, ushort y0, ushort y1);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImPlot_ImRemap_S32(int x, int x0, int x1, int y0, int y1);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ImPlot_ImRemap_U32(uint x, uint x0, uint x1, uint y0, uint y1);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern long ImPlot_ImRemap_S64(long x, long x0, long x1, long y0, long y1);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ImPlot_ImRemap_U64(ulong x, ulong x0, ulong x1, ulong y0, ulong y1);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern float ImPlot_ImRemap01_Float(float x, float x0, float x1);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_ImRemap01_double(double x, double x0, double x1);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern sbyte ImPlot_ImRemap01_S8(sbyte x, sbyte x0, sbyte x1);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_ImRemap01_U8(byte x, byte x0, byte x1);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern short ImPlot_ImRemap01_S16(short x, short x0, short x1);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern ushort ImPlot_ImRemap01_U16(ushort x, ushort x0, ushort x1);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImPlot_ImRemap01_S32(int x, int x0, int x1);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ImPlot_ImRemap01_U32(uint x, uint x0, uint x1);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern long ImPlot_ImRemap01_S64(long x, long x0, long x1);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ImPlot_ImRemap01_U64(ulong x, ulong x0, ulong x1);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_ImStdDev_FloatPtr(float* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_ImStdDev_doublePtr(double* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_ImStdDev_S8Ptr(sbyte* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_ImStdDev_U8Ptr(byte* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_ImStdDev_S16Ptr(short* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_ImStdDev_U16Ptr(ushort* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_ImStdDev_S32Ptr(int* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_ImStdDev_U32Ptr(uint* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_ImStdDev_S64Ptr(long* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_ImStdDev_U64Ptr(ulong* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern float ImPlot_ImSum_FloatPtr(float* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_ImSum_doublePtr(double* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern sbyte ImPlot_ImSum_S8Ptr(sbyte* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_ImSum_U8Ptr(byte* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern short ImPlot_ImSum_S16Ptr(short* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern ushort ImPlot_ImSum_U16Ptr(ushort* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImPlot_ImSum_S32Ptr(int* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ImPlot_ImSum_U32Ptr(uint* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern long ImPlot_ImSum_S64Ptr(long* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ImPlot_ImSum_U64Ptr(ulong* values, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_Initialize(IntPtr ctx);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_Intersection(Vector2* pOut, Vector2 a1, Vector2 a2, Vector2 b1, Vector2 b2);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_IsAxisHovered(ImAxis axis);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_IsColorAuto_Vec4(Vector4 col);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_IsColorAuto_PlotCol(ImPlotCol idx);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_IsLeapYear(int year);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_IsLegendEntryHovered(byte* label_id);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_IsPlotHovered();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_IsPlotSelected();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_IsSubplotsHovered();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_ItemIcon_Vec4(Vector4 col);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_ItemIcon_U32(uint col);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_LabelAxisValue(ImPlotAxis axis, double value, byte* buff, int size, byte round);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_LabelTickTime(ImPlotTick* tick, ImGuiTextBuffer* buffer, ImPlotTime t, ImPlotDateTimeFmt fmt);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_MakeTime(ImPlotTime* pOut, int year, int month, int day, int hour, int min, int sec, int us);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_MapInputDefault(ImPlotInputMap* dst);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_MapInputReverse(ImPlotInputMap* dst);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_MkGmtTime(ImPlotTime* pOut, struct tm* ptm);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_MkLocTime(ImPlotTime* pOut, struct tm* ptm);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_NextColormapColor(Vector4* pOut);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ImPlot_NextColormapColorU32();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_NiceNum(double x, byte round);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImPlot_OrderOfMagnitude(double val);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImPlot_OrderToPrecision(int order);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PixelsToPlot_Vec2(ImPlotPoint* pOut, Vector2 pix, ImAxis x_axis, ImAxis y_axis);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PixelsToPlot_Float(ImPlotPoint* pOut, float x, float y, ImAxis x_axis, ImAxis y_axis);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarGroups_FloatPtr(char* const[] label_ids, float* values, int item_count, int group_count, double group_width, double x0, ImPlotBarGroupsFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarGroups_doublePtr(char* const[] label_ids, double* values, int item_count, int group_count, double group_width, double x0, ImPlotBarGroupsFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarGroups_S8Ptr(char* const[] label_ids, sbyte* values, int item_count, int group_count, double group_width, double x0, ImPlotBarGroupsFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarGroups_U8Ptr(char* const[] label_ids, byte* values, int item_count, int group_count, double group_width, double x0, ImPlotBarGroupsFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarGroups_S16Ptr(char* const[] label_ids, short* values, int item_count, int group_count, double group_width, double x0, ImPlotBarGroupsFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarGroups_U16Ptr(char* const[] label_ids, ushort* values, int item_count, int group_count, double group_width, double x0, ImPlotBarGroupsFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarGroups_S32Ptr(char* const[] label_ids, int* values, int item_count, int group_count, double group_width, double x0, ImPlotBarGroupsFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarGroups_U32Ptr(char* const[] label_ids, uint* values, int item_count, int group_count, double group_width, double x0, ImPlotBarGroupsFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarGroups_S64Ptr(char* const[] label_ids, long* values, int item_count, int group_count, double group_width, double x0, ImPlotBarGroupsFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarGroups_U64Ptr(char* const[] label_ids, ulong* values, int item_count, int group_count, double group_width, double x0, ImPlotBarGroupsFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarGroupsH_FloatPtr(char* const[] label_ids, float* values, int item_count, int group_count, double group_height, double y0, ImPlotBarGroupsFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarGroupsH_doublePtr(char* const[] label_ids, double* values, int item_count, int group_count, double group_height, double y0, ImPlotBarGroupsFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarGroupsH_S8Ptr(char* const[] label_ids, sbyte* values, int item_count, int group_count, double group_height, double y0, ImPlotBarGroupsFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarGroupsH_U8Ptr(char* const[] label_ids, byte* values, int item_count, int group_count, double group_height, double y0, ImPlotBarGroupsFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarGroupsH_S16Ptr(char* const[] label_ids, short* values, int item_count, int group_count, double group_height, double y0, ImPlotBarGroupsFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarGroupsH_U16Ptr(char* const[] label_ids, ushort* values, int item_count, int group_count, double group_height, double y0, ImPlotBarGroupsFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarGroupsH_S32Ptr(char* const[] label_ids, int* values, int item_count, int group_count, double group_height, double y0, ImPlotBarGroupsFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarGroupsH_U32Ptr(char* const[] label_ids, uint* values, int item_count, int group_count, double group_height, double y0, ImPlotBarGroupsFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarGroupsH_S64Ptr(char* const[] label_ids, long* values, int item_count, int group_count, double group_height, double y0, ImPlotBarGroupsFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarGroupsH_U64Ptr(char* const[] label_ids, ulong* values, int item_count, int group_count, double group_height, double y0, ImPlotBarGroupsFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBars_FloatPtrInt(byte* label_id, float* values, int count, double bar_width, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBars_doublePtrInt(byte* label_id, double* values, int count, double bar_width, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBars_S8PtrInt(byte* label_id, sbyte* values, int count, double bar_width, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBars_U8PtrInt(byte* label_id, byte* values, int count, double bar_width, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBars_S16PtrInt(byte* label_id, short* values, int count, double bar_width, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBars_U16PtrInt(byte* label_id, ushort* values, int count, double bar_width, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBars_S32PtrInt(byte* label_id, int* values, int count, double bar_width, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBars_U32PtrInt(byte* label_id, uint* values, int count, double bar_width, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBars_S64PtrInt(byte* label_id, long* values, int count, double bar_width, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBars_U64PtrInt(byte* label_id, ulong* values, int count, double bar_width, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBars_FloatPtrFloatPtr(byte* label_id, float* xs, float* ys, int count, double bar_width, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBars_doublePtrdoublePtr(byte* label_id, double* xs, double* ys, int count, double bar_width, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBars_S8PtrS8Ptr(byte* label_id, sbyte* xs, sbyte* ys, int count, double bar_width, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBars_U8PtrU8Ptr(byte* label_id, byte* xs, byte* ys, int count, double bar_width, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBars_S16PtrS16Ptr(byte* label_id, short* xs, short* ys, int count, double bar_width, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBars_U16PtrU16Ptr(byte* label_id, ushort* xs, ushort* ys, int count, double bar_width, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBars_S32PtrS32Ptr(byte* label_id, int* xs, int* ys, int count, double bar_width, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBars_U32PtrU32Ptr(byte* label_id, uint* xs, uint* ys, int count, double bar_width, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBars_S64PtrS64Ptr(byte* label_id, long* xs, long* ys, int count, double bar_width, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBars_U64PtrU64Ptr(byte* label_id, ulong* xs, ulong* ys, int count, double bar_width, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsG(byte* label_id, ImPlotGetter getter, void* data, int count, double bar_width);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsH_FloatPtrInt(byte* label_id, float* values, int count, double bar_height, double y0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsH_doublePtrInt(byte* label_id, double* values, int count, double bar_height, double y0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsH_S8PtrInt(byte* label_id, sbyte* values, int count, double bar_height, double y0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsH_U8PtrInt(byte* label_id, byte* values, int count, double bar_height, double y0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsH_S16PtrInt(byte* label_id, short* values, int count, double bar_height, double y0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsH_U16PtrInt(byte* label_id, ushort* values, int count, double bar_height, double y0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsH_S32PtrInt(byte* label_id, int* values, int count, double bar_height, double y0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsH_U32PtrInt(byte* label_id, uint* values, int count, double bar_height, double y0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsH_S64PtrInt(byte* label_id, long* values, int count, double bar_height, double y0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsH_U64PtrInt(byte* label_id, ulong* values, int count, double bar_height, double y0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsH_FloatPtrFloatPtr(byte* label_id, float* xs, float* ys, int count, double bar_height, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsH_doublePtrdoublePtr(byte* label_id, double* xs, double* ys, int count, double bar_height, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsH_S8PtrS8Ptr(byte* label_id, sbyte* xs, sbyte* ys, int count, double bar_height, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsH_U8PtrU8Ptr(byte* label_id, byte* xs, byte* ys, int count, double bar_height, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsH_S16PtrS16Ptr(byte* label_id, short* xs, short* ys, int count, double bar_height, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsH_U16PtrU16Ptr(byte* label_id, ushort* xs, ushort* ys, int count, double bar_height, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsH_S32PtrS32Ptr(byte* label_id, int* xs, int* ys, int count, double bar_height, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsH_U32PtrU32Ptr(byte* label_id, uint* xs, uint* ys, int count, double bar_height, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsH_S64PtrS64Ptr(byte* label_id, long* xs, long* ys, int count, double bar_height, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsH_U64PtrU64Ptr(byte* label_id, ulong* xs, ulong* ys, int count, double bar_height, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotBarsHG(byte* label_id, ImPlotGetter getter, void* data, int count, double bar_height);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotDigital_FloatPtr(byte* label_id, float* xs, float* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotDigital_doublePtr(byte* label_id, double* xs, double* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotDigital_S8Ptr(byte* label_id, sbyte* xs, sbyte* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotDigital_U8Ptr(byte* label_id, byte* xs, byte* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotDigital_S16Ptr(byte* label_id, short* xs, short* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotDigital_U16Ptr(byte* label_id, ushort* xs, ushort* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotDigital_S32Ptr(byte* label_id, int* xs, int* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotDigital_U32Ptr(byte* label_id, uint* xs, uint* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotDigital_S64Ptr(byte* label_id, long* xs, long* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotDigital_U64Ptr(byte* label_id, ulong* xs, ulong* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotDigitalG(byte* label_id, ImPlotGetter getter, void* data, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotDummy(byte* label_id);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBars_FloatPtrFloatPtrFloatPtrInt(byte* label_id, float* xs, float* ys, float* err, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBars_doublePtrdoublePtrdoublePtrInt(byte* label_id, double* xs, double* ys, double* err, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBars_S8PtrS8PtrS8PtrInt(byte* label_id, sbyte* xs, sbyte* ys, sbyte* err, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBars_U8PtrU8PtrU8PtrInt(byte* label_id, byte* xs, byte* ys, byte* err, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBars_S16PtrS16PtrS16PtrInt(byte* label_id, short* xs, short* ys, short* err, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBars_U16PtrU16PtrU16PtrInt(byte* label_id, ushort* xs, ushort* ys, ushort* err, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBars_S32PtrS32PtrS32PtrInt(byte* label_id, int* xs, int* ys, int* err, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBars_U32PtrU32PtrU32PtrInt(byte* label_id, uint* xs, uint* ys, uint* err, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBars_S64PtrS64PtrS64PtrInt(byte* label_id, long* xs, long* ys, long* err, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBars_U64PtrU64PtrU64PtrInt(byte* label_id, ulong* xs, ulong* ys, ulong* err, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBars_FloatPtrFloatPtrFloatPtrFloatPtr(byte* label_id, float* xs, float* ys, float* neg, float* pos, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBars_doublePtrdoublePtrdoublePtrdoublePtr(byte* label_id, double* xs, double* ys, double* neg, double* pos, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBars_S8PtrS8PtrS8PtrS8Ptr(byte* label_id, sbyte* xs, sbyte* ys, sbyte* neg, sbyte* pos, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBars_U8PtrU8PtrU8PtrU8Ptr(byte* label_id, byte* xs, byte* ys, byte* neg, byte* pos, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBars_S16PtrS16PtrS16PtrS16Ptr(byte* label_id, short* xs, short* ys, short* neg, short* pos, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBars_U16PtrU16PtrU16PtrU16Ptr(byte* label_id, ushort* xs, ushort* ys, ushort* neg, ushort* pos, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBars_S32PtrS32PtrS32PtrS32Ptr(byte* label_id, int* xs, int* ys, int* neg, int* pos, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBars_U32PtrU32PtrU32PtrU32Ptr(byte* label_id, uint* xs, uint* ys, uint* neg, uint* pos, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBars_S64PtrS64PtrS64PtrS64Ptr(byte* label_id, long* xs, long* ys, long* neg, long* pos, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBars_U64PtrU64PtrU64PtrU64Ptr(byte* label_id, ulong* xs, ulong* ys, ulong* neg, ulong* pos, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBarsH_FloatPtrFloatPtrFloatPtrInt(byte* label_id, float* xs, float* ys, float* err, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBarsH_doublePtrdoublePtrdoublePtrInt(byte* label_id, double* xs, double* ys, double* err, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBarsH_S8PtrS8PtrS8PtrInt(byte* label_id, sbyte* xs, sbyte* ys, sbyte* err, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBarsH_U8PtrU8PtrU8PtrInt(byte* label_id, byte* xs, byte* ys, byte* err, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBarsH_S16PtrS16PtrS16PtrInt(byte* label_id, short* xs, short* ys, short* err, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBarsH_U16PtrU16PtrU16PtrInt(byte* label_id, ushort* xs, ushort* ys, ushort* err, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBarsH_S32PtrS32PtrS32PtrInt(byte* label_id, int* xs, int* ys, int* err, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBarsH_U32PtrU32PtrU32PtrInt(byte* label_id, uint* xs, uint* ys, uint* err, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBarsH_S64PtrS64PtrS64PtrInt(byte* label_id, long* xs, long* ys, long* err, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBarsH_U64PtrU64PtrU64PtrInt(byte* label_id, ulong* xs, ulong* ys, ulong* err, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBarsH_FloatPtrFloatPtrFloatPtrFloatPtr(byte* label_id, float* xs, float* ys, float* neg, float* pos, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBarsH_doublePtrdoublePtrdoublePtrdoublePtr(byte* label_id, double* xs, double* ys, double* neg, double* pos, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBarsH_S8PtrS8PtrS8PtrS8Ptr(byte* label_id, sbyte* xs, sbyte* ys, sbyte* neg, sbyte* pos, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBarsH_U8PtrU8PtrU8PtrU8Ptr(byte* label_id, byte* xs, byte* ys, byte* neg, byte* pos, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBarsH_S16PtrS16PtrS16PtrS16Ptr(byte* label_id, short* xs, short* ys, short* neg, short* pos, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBarsH_U16PtrU16PtrU16PtrU16Ptr(byte* label_id, ushort* xs, ushort* ys, ushort* neg, ushort* pos, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBarsH_S32PtrS32PtrS32PtrS32Ptr(byte* label_id, int* xs, int* ys, int* neg, int* pos, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBarsH_U32PtrU32PtrU32PtrU32Ptr(byte* label_id, uint* xs, uint* ys, uint* neg, uint* pos, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBarsH_S64PtrS64PtrS64PtrS64Ptr(byte* label_id, long* xs, long* ys, long* neg, long* pos, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotErrorBarsH_U64PtrU64PtrU64PtrU64Ptr(byte* label_id, ulong* xs, ulong* ys, ulong* neg, ulong* pos, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotHLines_FloatPtr(byte* label_id, float* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotHLines_doublePtr(byte* label_id, double* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotHLines_S8Ptr(byte* label_id, sbyte* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotHLines_U8Ptr(byte* label_id, byte* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotHLines_S16Ptr(byte* label_id, short* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotHLines_U16Ptr(byte* label_id, ushort* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotHLines_S32Ptr(byte* label_id, int* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotHLines_U32Ptr(byte* label_id, uint* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotHLines_S64Ptr(byte* label_id, long* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotHLines_U64Ptr(byte* label_id, ulong* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotHeatmap_FloatPtr(byte* label_id, float* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotHeatmap_doublePtr(byte* label_id, double* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotHeatmap_S8Ptr(byte* label_id, sbyte* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotHeatmap_U8Ptr(byte* label_id, byte* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotHeatmap_S16Ptr(byte* label_id, short* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotHeatmap_U16Ptr(byte* label_id, ushort* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotHeatmap_S32Ptr(byte* label_id, int* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotHeatmap_U32Ptr(byte* label_id, uint* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotHeatmap_S64Ptr(byte* label_id, long* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotHeatmap_U64Ptr(byte* label_id, ulong* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_PlotHistogram_FloatPtr(byte* label_id, float* values, int count, int bins, byte cumulative, byte density, ImPlotRange range, byte outliers, double bar_scale);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_PlotHistogram_doublePtr(byte* label_id, double* values, int count, int bins, byte cumulative, byte density, ImPlotRange range, byte outliers, double bar_scale);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_PlotHistogram_S8Ptr(byte* label_id, sbyte* values, int count, int bins, byte cumulative, byte density, ImPlotRange range, byte outliers, double bar_scale);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_PlotHistogram_U8Ptr(byte* label_id, byte* values, int count, int bins, byte cumulative, byte density, ImPlotRange range, byte outliers, double bar_scale);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_PlotHistogram_S16Ptr(byte* label_id, short* values, int count, int bins, byte cumulative, byte density, ImPlotRange range, byte outliers, double bar_scale);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_PlotHistogram_U16Ptr(byte* label_id, ushort* values, int count, int bins, byte cumulative, byte density, ImPlotRange range, byte outliers, double bar_scale);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_PlotHistogram_S32Ptr(byte* label_id, int* values, int count, int bins, byte cumulative, byte density, ImPlotRange range, byte outliers, double bar_scale);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_PlotHistogram_U32Ptr(byte* label_id, uint* values, int count, int bins, byte cumulative, byte density, ImPlotRange range, byte outliers, double bar_scale);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_PlotHistogram_S64Ptr(byte* label_id, long* values, int count, int bins, byte cumulative, byte density, ImPlotRange range, byte outliers, double bar_scale);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_PlotHistogram_U64Ptr(byte* label_id, ulong* values, int count, int bins, byte cumulative, byte density, ImPlotRange range, byte outliers, double bar_scale);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_PlotHistogram2D_FloatPtr(byte* label_id, float* xs, float* ys, int count, int x_bins, int y_bins, byte density, ImPlotRect range, byte outliers);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_PlotHistogram2D_doublePtr(byte* label_id, double* xs, double* ys, int count, int x_bins, int y_bins, byte density, ImPlotRect range, byte outliers);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_PlotHistogram2D_S8Ptr(byte* label_id, sbyte* xs, sbyte* ys, int count, int x_bins, int y_bins, byte density, ImPlotRect range, byte outliers);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_PlotHistogram2D_U8Ptr(byte* label_id, byte* xs, byte* ys, int count, int x_bins, int y_bins, byte density, ImPlotRect range, byte outliers);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_PlotHistogram2D_S16Ptr(byte* label_id, short* xs, short* ys, int count, int x_bins, int y_bins, byte density, ImPlotRect range, byte outliers);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_PlotHistogram2D_U16Ptr(byte* label_id, ushort* xs, ushort* ys, int count, int x_bins, int y_bins, byte density, ImPlotRect range, byte outliers);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_PlotHistogram2D_S32Ptr(byte* label_id, int* xs, int* ys, int count, int x_bins, int y_bins, byte density, ImPlotRect range, byte outliers);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_PlotHistogram2D_U32Ptr(byte* label_id, uint* xs, uint* ys, int count, int x_bins, int y_bins, byte density, ImPlotRect range, byte outliers);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_PlotHistogram2D_S64Ptr(byte* label_id, long* xs, long* ys, int count, int x_bins, int y_bins, byte density, ImPlotRect range, byte outliers);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_PlotHistogram2D_U64Ptr(byte* label_id, ulong* xs, ulong* ys, int count, int x_bins, int y_bins, byte density, ImPlotRect range, byte outliers);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotImage(byte* label_id, ImTextureID user_texture_id, ImPlotPoint bounds_min, ImPlotPoint bounds_max, Vector2 uv0, Vector2 uv1, Vector4 tint_col);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotLine_FloatPtrInt(byte* label_id, float* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotLine_doublePtrInt(byte* label_id, double* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotLine_S8PtrInt(byte* label_id, sbyte* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotLine_U8PtrInt(byte* label_id, byte* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotLine_S16PtrInt(byte* label_id, short* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotLine_U16PtrInt(byte* label_id, ushort* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotLine_S32PtrInt(byte* label_id, int* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotLine_U32PtrInt(byte* label_id, uint* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotLine_S64PtrInt(byte* label_id, long* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotLine_U64PtrInt(byte* label_id, ulong* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotLine_FloatPtrFloatPtr(byte* label_id, float* xs, float* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotLine_doublePtrdoublePtr(byte* label_id, double* xs, double* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotLine_S8PtrS8Ptr(byte* label_id, sbyte* xs, sbyte* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotLine_U8PtrU8Ptr(byte* label_id, byte* xs, byte* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotLine_S16PtrS16Ptr(byte* label_id, short* xs, short* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotLine_U16PtrU16Ptr(byte* label_id, ushort* xs, ushort* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotLine_S32PtrS32Ptr(byte* label_id, int* xs, int* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotLine_U32PtrU32Ptr(byte* label_id, uint* xs, uint* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotLine_S64PtrS64Ptr(byte* label_id, long* xs, long* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotLine_U64PtrU64Ptr(byte* label_id, ulong* xs, ulong* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotLineG(byte* label_id, ImPlotGetter getter, void* data, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotPieChart_FloatPtr(char* const[] label_ids, float* values, int count, double x, double y, double radius, byte normalize, byte* label_fmt, double angle0);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotPieChart_doublePtr(char* const[] label_ids, double* values, int count, double x, double y, double radius, byte normalize, byte* label_fmt, double angle0);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotPieChart_S8Ptr(char* const[] label_ids, sbyte* values, int count, double x, double y, double radius, byte normalize, byte* label_fmt, double angle0);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotPieChart_U8Ptr(char* const[] label_ids, byte* values, int count, double x, double y, double radius, byte normalize, byte* label_fmt, double angle0);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotPieChart_S16Ptr(char* const[] label_ids, short* values, int count, double x, double y, double radius, byte normalize, byte* label_fmt, double angle0);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotPieChart_U16Ptr(char* const[] label_ids, ushort* values, int count, double x, double y, double radius, byte normalize, byte* label_fmt, double angle0);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotPieChart_S32Ptr(char* const[] label_ids, int* values, int count, double x, double y, double radius, byte normalize, byte* label_fmt, double angle0);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotPieChart_U32Ptr(char* const[] label_ids, uint* values, int count, double x, double y, double radius, byte normalize, byte* label_fmt, double angle0);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotPieChart_S64Ptr(char* const[] label_ids, long* values, int count, double x, double y, double radius, byte normalize, byte* label_fmt, double angle0);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotPieChart_U64Ptr(char* const[] label_ids, ulong* values, int count, double x, double y, double radius, byte normalize, byte* label_fmt, double angle0);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotScatter_FloatPtrInt(byte* label_id, float* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotScatter_doublePtrInt(byte* label_id, double* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotScatter_S8PtrInt(byte* label_id, sbyte* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotScatter_U8PtrInt(byte* label_id, byte* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotScatter_S16PtrInt(byte* label_id, short* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotScatter_U16PtrInt(byte* label_id, ushort* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotScatter_S32PtrInt(byte* label_id, int* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotScatter_U32PtrInt(byte* label_id, uint* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotScatter_S64PtrInt(byte* label_id, long* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotScatter_U64PtrInt(byte* label_id, ulong* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotScatter_FloatPtrFloatPtr(byte* label_id, float* xs, float* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotScatter_doublePtrdoublePtr(byte* label_id, double* xs, double* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotScatter_S8PtrS8Ptr(byte* label_id, sbyte* xs, sbyte* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotScatter_U8PtrU8Ptr(byte* label_id, byte* xs, byte* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotScatter_S16PtrS16Ptr(byte* label_id, short* xs, short* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotScatter_U16PtrU16Ptr(byte* label_id, ushort* xs, ushort* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotScatter_S32PtrS32Ptr(byte* label_id, int* xs, int* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotScatter_U32PtrU32Ptr(byte* label_id, uint* xs, uint* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotScatter_S64PtrS64Ptr(byte* label_id, long* xs, long* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotScatter_U64PtrU64Ptr(byte* label_id, ulong* xs, ulong* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotScatterG(byte* label_id, ImPlotGetter getter, void* data, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_FloatPtrInt(byte* label_id, float* values, int count, double yref, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_doublePtrInt(byte* label_id, double* values, int count, double yref, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_S8PtrInt(byte* label_id, sbyte* values, int count, double yref, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_U8PtrInt(byte* label_id, byte* values, int count, double yref, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_S16PtrInt(byte* label_id, short* values, int count, double yref, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_U16PtrInt(byte* label_id, ushort* values, int count, double yref, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_S32PtrInt(byte* label_id, int* values, int count, double yref, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_U32PtrInt(byte* label_id, uint* values, int count, double yref, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_S64PtrInt(byte* label_id, long* values, int count, double yref, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_U64PtrInt(byte* label_id, ulong* values, int count, double yref, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_FloatPtrFloatPtrInt(byte* label_id, float* xs, float* ys, int count, double yref, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_doublePtrdoublePtrInt(byte* label_id, double* xs, double* ys, int count, double yref, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_S8PtrS8PtrInt(byte* label_id, sbyte* xs, sbyte* ys, int count, double yref, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_U8PtrU8PtrInt(byte* label_id, byte* xs, byte* ys, int count, double yref, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_S16PtrS16PtrInt(byte* label_id, short* xs, short* ys, int count, double yref, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_U16PtrU16PtrInt(byte* label_id, ushort* xs, ushort* ys, int count, double yref, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_S32PtrS32PtrInt(byte* label_id, int* xs, int* ys, int count, double yref, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_U32PtrU32PtrInt(byte* label_id, uint* xs, uint* ys, int count, double yref, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_S64PtrS64PtrInt(byte* label_id, long* xs, long* ys, int count, double yref, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_U64PtrU64PtrInt(byte* label_id, ulong* xs, ulong* ys, int count, double yref, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_FloatPtrFloatPtrFloatPtr(byte* label_id, float* xs, float* ys1, float* ys2, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_doublePtrdoublePtrdoublePtr(byte* label_id, double* xs, double* ys1, double* ys2, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_S8PtrS8PtrS8Ptr(byte* label_id, sbyte* xs, sbyte* ys1, sbyte* ys2, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_U8PtrU8PtrU8Ptr(byte* label_id, byte* xs, byte* ys1, byte* ys2, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_S16PtrS16PtrS16Ptr(byte* label_id, short* xs, short* ys1, short* ys2, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_U16PtrU16PtrU16Ptr(byte* label_id, ushort* xs, ushort* ys1, ushort* ys2, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_S32PtrS32PtrS32Ptr(byte* label_id, int* xs, int* ys1, int* ys2, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_U32PtrU32PtrU32Ptr(byte* label_id, uint* xs, uint* ys1, uint* ys2, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_S64PtrS64PtrS64Ptr(byte* label_id, long* xs, long* ys1, long* ys2, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShaded_U64PtrU64PtrU64Ptr(byte* label_id, ulong* xs, ulong* ys1, ulong* ys2, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotShadedG(byte* label_id, ImPlotGetter getter1, void* data1, ImPlotGetter getter2, void* data2, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStairs_FloatPtrInt(byte* label_id, float* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStairs_doublePtrInt(byte* label_id, double* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStairs_S8PtrInt(byte* label_id, sbyte* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStairs_U8PtrInt(byte* label_id, byte* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStairs_S16PtrInt(byte* label_id, short* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStairs_U16PtrInt(byte* label_id, ushort* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStairs_S32PtrInt(byte* label_id, int* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStairs_U32PtrInt(byte* label_id, uint* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStairs_S64PtrInt(byte* label_id, long* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStairs_U64PtrInt(byte* label_id, ulong* values, int count, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStairs_FloatPtrFloatPtr(byte* label_id, float* xs, float* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStairs_doublePtrdoublePtr(byte* label_id, double* xs, double* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStairs_S8PtrS8Ptr(byte* label_id, sbyte* xs, sbyte* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStairs_U8PtrU8Ptr(byte* label_id, byte* xs, byte* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStairs_S16PtrS16Ptr(byte* label_id, short* xs, short* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStairs_U16PtrU16Ptr(byte* label_id, ushort* xs, ushort* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStairs_S32PtrS32Ptr(byte* label_id, int* xs, int* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStairs_U32PtrU32Ptr(byte* label_id, uint* xs, uint* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStairs_S64PtrS64Ptr(byte* label_id, long* xs, long* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStairs_U64PtrU64Ptr(byte* label_id, ulong* xs, ulong* ys, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStairsG(byte* label_id, ImPlotGetter getter, void* data, int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStems_FloatPtrInt(byte* label_id, float* values, int count, double yref, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStems_doublePtrInt(byte* label_id, double* values, int count, double yref, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStems_S8PtrInt(byte* label_id, sbyte* values, int count, double yref, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStems_U8PtrInt(byte* label_id, byte* values, int count, double yref, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStems_S16PtrInt(byte* label_id, short* values, int count, double yref, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStems_U16PtrInt(byte* label_id, ushort* values, int count, double yref, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStems_S32PtrInt(byte* label_id, int* values, int count, double yref, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStems_U32PtrInt(byte* label_id, uint* values, int count, double yref, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStems_S64PtrInt(byte* label_id, long* values, int count, double yref, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStems_U64PtrInt(byte* label_id, ulong* values, int count, double yref, double xscale, double x0, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStems_FloatPtrFloatPtr(byte* label_id, float* xs, float* ys, int count, double yref, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStems_doublePtrdoublePtr(byte* label_id, double* xs, double* ys, int count, double yref, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStems_S8PtrS8Ptr(byte* label_id, sbyte* xs, sbyte* ys, int count, double yref, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStems_U8PtrU8Ptr(byte* label_id, byte* xs, byte* ys, int count, double yref, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStems_S16PtrS16Ptr(byte* label_id, short* xs, short* ys, int count, double yref, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStems_U16PtrU16Ptr(byte* label_id, ushort* xs, ushort* ys, int count, double yref, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStems_S32PtrS32Ptr(byte* label_id, int* xs, int* ys, int count, double yref, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStems_U32PtrU32Ptr(byte* label_id, uint* xs, uint* ys, int count, double yref, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStems_S64PtrS64Ptr(byte* label_id, long* xs, long* ys, int count, double yref, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotStems_U64PtrU64Ptr(byte* label_id, ulong* xs, ulong* ys, int count, double yref, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotText(byte* text, double x, double y, byte vertical, Vector2 pix_offset);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotToPixels_PlotPoInt(Vector2* pOut, ImPlotPoint plt, ImAxis x_axis, ImAxis y_axis);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotToPixels_double(Vector2* pOut, double x, double y, ImAxis x_axis, ImAxis y_axis);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotVLines_FloatPtr(byte* label_id, float* xs, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotVLines_doublePtr(byte* label_id, double* xs, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotVLines_S8Ptr(byte* label_id, sbyte* xs, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotVLines_U8Ptr(byte* label_id, byte* xs, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotVLines_S16Ptr(byte* label_id, short* xs, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotVLines_U16Ptr(byte* label_id, ushort* xs, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotVLines_S32Ptr(byte* label_id, int* xs, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotVLines_U32Ptr(byte* label_id, uint* xs, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotVLines_S64Ptr(byte* label_id, long* xs, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PlotVLines_U64Ptr(byte* label_id, ulong* xs, int count, int offset, int stride);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PopColormap(int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PopPlotClipRect();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PopStyleColor(int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PopStyleVar(int count);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImPlot_Precision(double val);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PushColormap_PlotColormap(ImPlotColormap cmap);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_PushColormap_Str(byte* name);

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
		public static extern byte ImPlot_RangesOverlap(ImPlotRange r1, ImPlotRange r2);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImPlotItem* ImPlot_RegisterOrGetItem(byte* label_id, byte* just_created);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_RenderColorBar(uint* colors, int size, ImDrawList* DrawList, ImRect bounds, byte vert, byte reversed, byte continuous);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_ResetCtxForNextAlignedPlots(IntPtr ctx);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_ResetCtxForNextPlot(IntPtr ctx);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_ResetCtxForNextSubplot(IntPtr ctx);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_RoundTime(ImPlotTime* pOut, ImPlotTime t, ImPlotTimeUnit unit);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPlot_RoundTo(double val, int prec);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_SampleColormap(Vector4* pOut, float t, ImPlotColormap cmap);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ImPlot_SampleColormapU32(float t, ImPlotColormap cmap);

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
		public static extern void ImPlot_SetupAxes(byte* x_label, byte* y_label, ImPlotAxisFlags x_flags, ImPlotAxisFlags y_flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_SetupAxesLimits(double x_min, double x_max, double y_min, double y_max, ImPlotCond cond);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_SetupAxis(ImAxis axis, byte* label, ImPlotAxisFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_SetupAxisFormat_Str(ImAxis axis, byte* fmt);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_SetupAxisFormat_PlotFormatter(ImAxis axis, ImPlotFormatter formatter, void* data);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_SetupAxisLimits(ImAxis axis, double v_min, double v_max, ImPlotCond cond);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_SetupAxisLinks(ImAxis axis, double* link_min, double* link_max);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_SetupAxisTicks_doublePtr(ImAxis axis, double* values, int n_ticks, char* const[] labels, byte keep_default);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_SetupAxisTicks_double(ImAxis axis, double v_min, double v_max, int n_ticks, char* const[] labels, byte keep_default);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_SetupFinish();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_SetupLegend(ImPlotLocation location, ImPlotLegendFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_SetupLock();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_SetupMouseText(ImPlotLocation location, ImPlotMouseTextFlags flags);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_ShowAltLegend(byte* title_id, byte vertical, Vector2 size, byte interactable);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_ShowAxisContextMenu(ImPlotAxis* axis, ImPlotAxis* equal_axis, byte time_allowed);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_ShowColormapSelector(byte* label);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_ShowDatePicker(byte* id, int* level, ImPlotTime* t, ImPlotTime* t1, ImPlotTime* t2);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_ShowDemoWindow(byte* p_open);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_ShowInputMapSelector(byte* label);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_ShowLegendContextMenu(ImPlotLegend* legend, byte visible);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_ShowLegendEntries(ImPlotItemGroup* items, ImRect legend_bb, byte interactable, Vector2 pad, Vector2 spacing, byte vertical, ImDrawList* DrawList);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_ShowMetricsWindow(byte* p_popen);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_ShowPlotContextMenu(ImPlotPlot* plot);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_ShowStyleEditor(ImPlotStyle* ref);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_ShowStyleSelector(byte* label);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_ShowSubplotsContextMenu(ImPlotSubplot* subplot);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPlot_ShowTimePicker(byte* id, ImPlotTime* t);

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
		public static extern void ImPlot_SubplotNextCell();

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_TagX_Bool(double x, Vector4 color, byte round);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_TagX_Str(double x, Vector4 color, byte* fmt, ... ...);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_TagXV(double x, Vector4 color, byte* fmt, va_list args);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_TagY_Bool(double y, Vector4 color, byte round);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_TagY_Str(double y, Vector4 color, byte* fmt, ... ...);

		[DllImport("cimplot", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPlot_TagYV(double y, Vector4 color, byte* fmt, va_list args);

	}
}
