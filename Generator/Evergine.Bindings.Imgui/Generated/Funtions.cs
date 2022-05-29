using Evergine.Mathematics;
using System;
using System.Runtime.InteropServices;

namespace Evergine.Bindings.Imgui
{
	public static unsafe partial class ImguiNative
	{
		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImBitArray_ClearAllBits(ImBitArray* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImBitArray_ClearBit(ImBitArray* self, int n);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImBitArray_ImBitArray();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImBitArray_SetAllBits(ImBitArray* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImBitArray_SetBit(ImBitArray* self, int n);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImBitArray_SetBitRange(ImBitArray* self, int n, int n2);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImBitArray_TestBit(ImBitArray* self, int n);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImBitArray_destroy(ImBitArray* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImBitVector_Clear(ImBitVector* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImBitVector_ClearBit(ImBitVector* self, int n);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImBitVector_Create(ImBitVector* self, int sz);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImBitVector_SetBit(ImBitVector* self, int n);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImBitVector_TestBit(ImBitVector* self, int n);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern T* ImChunkStream_alloc_chunk(ImChunkStream* self, uint sz);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern T* ImChunkStream_begin(ImChunkStream* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImChunkStream_chunk_size(ImChunkStream* self, T* p);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImChunkStream_clear(ImChunkStream* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImChunkStream_empty(ImChunkStream* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern T* ImChunkStream_end(ImChunkStream* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern T* ImChunkStream_next_chunk(ImChunkStream* self, T* p);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImChunkStream_offset_from_ptr(ImChunkStream* self, T* p);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern T* ImChunkStream_ptr_from_offset(ImChunkStream* self, int off);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImChunkStream_size(ImChunkStream* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImChunkStream_swap(ImChunkStream* self, ImChunkStream_T * rhs);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImColor_HSV(ImColor* pOut, float h, float s, float v, float a);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImColor_ImColor_Nil();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImColor_ImColor_Int(int r, int g, int b, int a);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImColor_ImColor_U32(uint rgba);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImColor_ImColor_Float(float r, float g, float b, float a);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImColor_ImColor_Vec4(Vector4 col);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImColor_SetHSV(ImColor* self, float h, float s, float v, float a);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImColor_destroy(ImColor* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImTextureID ImDrawCmd_GetTexID(ImDrawCmd* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawCmd_ImDrawCmd();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawCmd_destroy(ImDrawCmd* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawDataBuilder_Clear(ImDrawDataBuilder* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawDataBuilder_ClearFreeMemory(ImDrawDataBuilder* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawDataBuilder_FlattenIntoSingleLayer(ImDrawDataBuilder* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImDrawDataBuilder_GetDrawListCount(ImDrawDataBuilder* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawData_Clear(ImDrawData* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawData_DeIndexAllBuffers(ImDrawData* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawData_ImDrawData();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawData_ScaleClipRects(ImDrawData* self, Vector2 fb_scale);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawData_destroy(ImDrawData* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListSharedData_ImDrawListSharedData();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListSharedData_SetCircleTessellationMaxError(ImDrawListSharedData* self, float max_error);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListSharedData_destroy(ImDrawListSharedData* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListSplitter_Clear(ImDrawListSplitter* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListSplitter_ClearFreeMemory(ImDrawListSplitter* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListSplitter_ImDrawListSplitter();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListSplitter_Merge(ImDrawListSplitter* self, ImDrawList* draw_list);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListSplitter_SetCurrentChannel(ImDrawListSplitter* self, ImDrawList* draw_list, int channel_idx);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListSplitter_Split(ImDrawListSplitter* self, ImDrawList* draw_list, int count);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListSplitter_destroy(ImDrawListSplitter* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_AddBezierCubic(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness, int num_segments);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_AddBezierQuadratic(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col, float thickness, int num_segments);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_AddCallback(ImDrawList* self, ImDrawCallback callback, void* callback_data);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_AddCircle(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments, float thickness);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_AddCircleFilled(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_AddConvexPolyFilled(ImDrawList* self, Vector2* points, int num_points, uint col);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_AddDrawCmd(ImDrawList* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_AddImage(ImDrawList* self, ImTextureID user_texture_id, Vector2 p_min, Vector2 p_max, Vector2 uv_min, Vector2 uv_max, uint col);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_AddImageQuad(ImDrawList* self, ImTextureID user_texture_id, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 uv1, Vector2 uv2, Vector2 uv3, Vector2 uv4, uint col);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_AddImageRounded(ImDrawList* self, ImTextureID user_texture_id, Vector2 p_min, Vector2 p_max, Vector2 uv_min, Vector2 uv_max, uint col, float rounding, ImDrawFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_AddLine(ImDrawList* self, Vector2 p1, Vector2 p2, uint col, float thickness);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_AddNgon(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments, float thickness);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_AddNgonFilled(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_AddPolyline(ImDrawList* self, Vector2* points, int num_points, uint col, ImDrawFlags flags, float thickness);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_AddQuad(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_AddQuadFilled(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_AddRect(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col, float rounding, ImDrawFlags flags, float thickness);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_AddRectFilled(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col, float rounding, ImDrawFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_AddRectFilledMultiColor(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col_upr_left, uint col_upr_right, uint col_bot_right, uint col_bot_left);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_AddText_Vec2(ImDrawList* self, Vector2 pos, uint col, byte* text_begin, byte* text_end);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_AddText_FontPtr(ImDrawList* self, ImFont* font, float font_size, Vector2 pos, uint col, byte* text_begin, byte* text_end, float wrap_width, Vector4* cpu_fine_clip_rect);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_AddTriangle(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col, float thickness);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_AddTriangleFilled(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_ChannelsMerge(ImDrawList* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_ChannelsSetCurrent(ImDrawList* self, int n);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_ChannelsSplit(ImDrawList* self, int count);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImDrawList* ImDrawList_CloneOutput(ImDrawList* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_GetClipRectMax(Vector2* pOut, ImDrawList* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_GetClipRectMin(Vector2* pOut, ImDrawList* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_ImDrawList(ImDrawListSharedData* shared_data);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_PathArcTo(ImDrawList* self, Vector2 center, float radius, float a_min, float a_max, int num_segments);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_PathArcToFast(ImDrawList* self, Vector2 center, float radius, int a_min_of_12, int a_max_of_12);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_PathBezierCubicCurveTo(ImDrawList* self, Vector2 p2, Vector2 p3, Vector2 p4, int num_segments);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_PathBezierQuadraticCurveTo(ImDrawList* self, Vector2 p2, Vector2 p3, int num_segments);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_PathClear(ImDrawList* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_PathFillConvex(ImDrawList* self, uint col);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_PathLineTo(ImDrawList* self, Vector2 pos);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_PathLineToMergeDuplicate(ImDrawList* self, Vector2 pos);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_PathRect(ImDrawList* self, Vector2 rect_min, Vector2 rect_max, float rounding, ImDrawFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_PathStroke(ImDrawList* self, uint col, ImDrawFlags flags, float thickness);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_PopClipRect(ImDrawList* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_PopTextureID(ImDrawList* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_PrimQuadUV(ImDrawList* self, Vector2 a, Vector2 b, Vector2 c, Vector2 d, Vector2 uv_a, Vector2 uv_b, Vector2 uv_c, Vector2 uv_d, uint col);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_PrimRect(ImDrawList* self, Vector2 a, Vector2 b, uint col);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_PrimRectUV(ImDrawList* self, Vector2 a, Vector2 b, Vector2 uv_a, Vector2 uv_b, uint col);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_PrimReserve(ImDrawList* self, int idx_count, int vtx_count);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_PrimUnreserve(ImDrawList* self, int idx_count, int vtx_count);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_PrimVtx(ImDrawList* self, Vector2 pos, Vector2 uv, uint col);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_PrimWriteIdx(ImDrawList* self, ImDrawIdx idx);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_PrimWriteVtx(ImDrawList* self, Vector2 pos, Vector2 uv, uint col);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_PushClipRect(ImDrawList* self, Vector2 clip_rect_min, Vector2 clip_rect_max, byte intersect_with_current_clip_rect);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_PushClipRectFullScreen(ImDrawList* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_PushTextureID(ImDrawList* self, ImTextureID texture_id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImDrawList__CalcCircleAutoSegmentCount(ImDrawList* self, float radius);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList__ClearFreeMemory(ImDrawList* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList__OnChangedClipRect(ImDrawList* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList__OnChangedTextureID(ImDrawList* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList__OnChangedVtxOffset(ImDrawList* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList__PathArcToFastEx(ImDrawList* self, Vector2 center, float radius, int a_min_sample, int a_max_sample, int a_step);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList__PathArcToN(ImDrawList* self, Vector2 center, float radius, float a_min, float a_max, int num_segments);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList__PopUnusedDrawCmd(ImDrawList* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList__ResetForNewFrame(ImDrawList* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList__TryMergeDrawCmds(ImDrawList* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_destroy(ImDrawList* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontAtlasCustomRect_ImFontAtlasCustomRect();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImFontAtlasCustomRect_IsPacked(ImFontAtlasCustomRect* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontAtlasCustomRect_destroy(ImFontAtlasCustomRect* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImFontAtlas_AddCustomRectFontGlyph(ImFontAtlas* self, ImFont* font, ImWchar id, int width, int height, float advance_x, Vector2 offset);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImFontAtlas_AddCustomRectRegular(ImFontAtlas* self, int width, int height);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImFont* ImFontAtlas_AddFont(ImFontAtlas* self, ImFontConfig* font_cfg);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImFont* ImFontAtlas_AddFontDefault(ImFontAtlas* self, ImFontConfig* font_cfg);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImFont* ImFontAtlas_AddFontFromFileTTF(ImFontAtlas* self, byte* filename, float size_pixels, ImFontConfig* font_cfg, ImWchar* glyph_ranges);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImFont* ImFontAtlas_AddFontFromMemoryCompressedBase85TTF(ImFontAtlas* self, byte* compressed_font_data_base85, float size_pixels, ImFontConfig* font_cfg, ImWchar* glyph_ranges);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImFont* ImFontAtlas_AddFontFromMemoryCompressedTTF(ImFontAtlas* self, void* compressed_font_data, int compressed_font_size, float size_pixels, ImFontConfig* font_cfg, ImWchar* glyph_ranges);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImFont* ImFontAtlas_AddFontFromMemoryTTF(ImFontAtlas* self, void* font_data, int font_size, float size_pixels, ImFontConfig* font_cfg, ImWchar* glyph_ranges);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImFontAtlas_Build(ImFontAtlas* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontAtlas_CalcCustomRectUV(ImFontAtlas* self, ImFontAtlasCustomRect* rect, Vector2* out_uv_min, Vector2* out_uv_max);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontAtlas_Clear(ImFontAtlas* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontAtlas_ClearFonts(ImFontAtlas* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontAtlas_ClearInputData(ImFontAtlas* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontAtlas_ClearTexData(ImFontAtlas* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImFontAtlasCustomRect* ImFontAtlas_GetCustomRectByIndex(ImFontAtlas* self, int index);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImWchar* ImFontAtlas_GetGlyphRangesChineseFull(ImFontAtlas* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImWchar* ImFontAtlas_GetGlyphRangesChineseSimplifiedCommon(ImFontAtlas* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImWchar* ImFontAtlas_GetGlyphRangesCyrillic(ImFontAtlas* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImWchar* ImFontAtlas_GetGlyphRangesDefault(ImFontAtlas* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImWchar* ImFontAtlas_GetGlyphRangesJapanese(ImFontAtlas* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImWchar* ImFontAtlas_GetGlyphRangesKorean(ImFontAtlas* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImWchar* ImFontAtlas_GetGlyphRangesThai(ImFontAtlas* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImWchar* ImFontAtlas_GetGlyphRangesVietnamese(ImFontAtlas* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImFontAtlas_GetMouseCursorTexData(ImFontAtlas* self, ImGuiMouseCursor cursor, Vector2* out_offset, Vector2* out_size, ImVec2[2] out_uv_border, ImVec2[2] out_uv_fill);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontAtlas_GetTexDataAsAlpha8(ImFontAtlas* self, unsigned char** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontAtlas_GetTexDataAsRGBA32(ImFontAtlas* self, unsigned char** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontAtlas_ImFontAtlas();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImFontAtlas_IsBuilt(ImFontAtlas* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontAtlas_SetTexID(ImFontAtlas* self, ImTextureID id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontAtlas_destroy(ImFontAtlas* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontConfig_ImFontConfig();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontConfig_destroy(ImFontConfig* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontGlyphRangesBuilder_AddChar(ImFontGlyphRangesBuilder* self, ImWchar c);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontGlyphRangesBuilder_AddRanges(ImFontGlyphRangesBuilder* self, ImWchar* ranges);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontGlyphRangesBuilder_AddText(ImFontGlyphRangesBuilder* self, byte* text, byte* text_end);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontGlyphRangesBuilder_BuildRanges(ImFontGlyphRangesBuilder* self, ImVector_ImWchar* out_ranges);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontGlyphRangesBuilder_Clear(ImFontGlyphRangesBuilder* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImFontGlyphRangesBuilder_GetBit(ImFontGlyphRangesBuilder* self, uint n);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontGlyphRangesBuilder_ImFontGlyphRangesBuilder();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontGlyphRangesBuilder_SetBit(ImFontGlyphRangesBuilder* self, uint n);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontGlyphRangesBuilder_destroy(ImFontGlyphRangesBuilder* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFont_AddGlyph(ImFont* self, ImFontConfig* src_cfg, ImWchar c, float x0, float y0, float x1, float y1, float u0, float v0, float u1, float v1, float advance_x);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFont_AddRemapChar(ImFont* self, ImWchar dst, ImWchar src, byte overwrite_dst);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFont_BuildLookupTable(ImFont* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFont_CalcTextSizeA(Vector2* pOut, ImFont* self, float size, float max_width, float wrap_width, byte* text_begin, byte* text_end, char** remaining);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ImFont_CalcWordWrapPositionA(ImFont* self, float scale, byte* text, byte* text_end, float wrap_width);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFont_ClearOutputData(ImFont* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImFontGlyph* ImFont_FindGlyph(ImFont* self, ImWchar c);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImFontGlyph* ImFont_FindGlyphNoFallback(ImFont* self, ImWchar c);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float ImFont_GetCharAdvance(ImFont* self, ImWchar c);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ImFont_GetDebugName(ImFont* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFont_GrowIndex(ImFont* self, int new_size);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFont_ImFont();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImFont_IsGlyphRangeUnused(ImFont* self, uint c_begin, uint c_last);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImFont_IsLoaded(ImFont* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFont_RenderChar(ImFont* self, ImDrawList* draw_list, float size, Vector2 pos, uint col, ImWchar c);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFont_RenderText(ImFont* self, ImDrawList* draw_list, float size, Vector2 pos, uint col, Vector4 clip_rect, byte* text_begin, byte* text_end, float wrap_width, byte cpu_fine_clip);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFont_SetGlyphVisible(ImFont* self, ImWchar c, byte visible);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFont_destroy(ImFont* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiComboPreviewData_ImGuiComboPreviewData();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiComboPreviewData_destroy(ImGuiComboPreviewData* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiContextHook_ImGuiContextHook();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiContextHook_destroy(ImGuiContextHook* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiContext_ImGuiContext(ImFontAtlas* shared_font_atlas);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiContext_destroy(IntPtr self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiIO_AddFocusEvent(ImGuiIO* self, byte focused);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiIO_AddInputCharacter(ImGuiIO* self, uint c);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiIO_AddInputCharacterUTF16(ImGuiIO* self, ushort c);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiIO_AddInputCharactersUTF8(ImGuiIO* self, byte* str);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiIO_AddKeyAnalogEvent(ImGuiIO* self, ImGuiKey key, byte down, float v);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiIO_AddKeyEvent(ImGuiIO* self, ImGuiKey key, byte down);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiIO_AddMouseButtonEvent(ImGuiIO* self, int button, byte down);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiIO_AddMousePosEvent(ImGuiIO* self, float x, float y);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiIO_AddMouseWheelEvent(ImGuiIO* self, float wh_x, float wh_y);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiIO_ClearInputCharacters(ImGuiIO* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiIO_ClearInputKeys(ImGuiIO* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiIO_ImGuiIO();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiIO_SetKeyEventNativeData(ImGuiIO* self, ImGuiKey key, int native_keycode, int native_scancode, int native_legacy_index);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiIO_destroy(ImGuiIO* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiInputEvent_ImGuiInputEvent();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiInputEvent_destroy(ImGuiInputEvent* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiInputTextCallbackData_ClearSelection(ImGuiInputTextCallbackData* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiInputTextCallbackData_DeleteChars(ImGuiInputTextCallbackData* self, int pos, int bytes_count);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImGuiInputTextCallbackData_HasSelection(ImGuiInputTextCallbackData* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiInputTextCallbackData_ImGuiInputTextCallbackData();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiInputTextCallbackData_InsertChars(ImGuiInputTextCallbackData* self, int pos, byte* text, byte* text_end);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiInputTextCallbackData_SelectAll(ImGuiInputTextCallbackData* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiInputTextCallbackData_destroy(ImGuiInputTextCallbackData* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiInputTextState_ClearFreeMemory(ImGuiInputTextState* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiInputTextState_ClearSelection(ImGuiInputTextState* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiInputTextState_ClearText(ImGuiInputTextState* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiInputTextState_CursorAnimReset(ImGuiInputTextState* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiInputTextState_CursorClamp(ImGuiInputTextState* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImGuiInputTextState_GetCursorPos(ImGuiInputTextState* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImGuiInputTextState_GetRedoAvailCount(ImGuiInputTextState* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImGuiInputTextState_GetSelectionEnd(ImGuiInputTextState* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImGuiInputTextState_GetSelectionStart(ImGuiInputTextState* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImGuiInputTextState_GetUndoAvailCount(ImGuiInputTextState* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImGuiInputTextState_HasSelection(ImGuiInputTextState* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiInputTextState_ImGuiInputTextState();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiInputTextState_OnKeyPressed(ImGuiInputTextState* self, int key);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiInputTextState_SelectAll(ImGuiInputTextState* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiInputTextState_destroy(ImGuiInputTextState* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiLastItemData_ImGuiLastItemData();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiLastItemData_destroy(ImGuiLastItemData* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiListClipperData_ImGuiListClipperData();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiListClipperData_Reset(ImGuiListClipperData* self, ImGuiListClipper* clipper);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiListClipperData_destroy(ImGuiListClipperData* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiListClipperRange ImGuiListClipperRange_FromIndices(int min, int max);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiListClipperRange ImGuiListClipperRange_FromPositions(float y1, float y2, int off_min, int off_max);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiListClipper_Begin(ImGuiListClipper* self, int items_count, float items_height);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiListClipper_End(ImGuiListClipper* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiListClipper_ForceDisplayRangeByIndices(ImGuiListClipper* self, int item_min, int item_max);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiListClipper_ImGuiListClipper();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImGuiListClipper_Step(ImGuiListClipper* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiListClipper_destroy(ImGuiListClipper* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiMenuColumns_CalcNextTotalWidth(ImGuiMenuColumns* self, byte update_offsets);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float ImGuiMenuColumns_DeclColumns(ImGuiMenuColumns* self, float w_icon, float w_label, float w_shortcut, float w_mark);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiMenuColumns_ImGuiMenuColumns();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiMenuColumns_Update(ImGuiMenuColumns* self, float spacing, byte window_reappearing);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiMenuColumns_destroy(ImGuiMenuColumns* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiMetricsConfig_ImGuiMetricsConfig();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiMetricsConfig_destroy(ImGuiMetricsConfig* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiNavItemData_Clear(ImGuiNavItemData* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiNavItemData_ImGuiNavItemData();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiNavItemData_destroy(ImGuiNavItemData* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiNextItemData_ClearFlags(ImGuiNextItemData* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiNextItemData_ImGuiNextItemData();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiNextItemData_destroy(ImGuiNextItemData* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiNextWindowData_ClearFlags(ImGuiNextWindowData* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiNextWindowData_ImGuiNextWindowData();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiNextWindowData_destroy(ImGuiNextWindowData* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiOldColumnData_ImGuiOldColumnData();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiOldColumnData_destroy(ImGuiOldColumnData* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiOldColumns_ImGuiOldColumns();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiOldColumns_destroy(ImGuiOldColumns* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiOnceUponAFrame_ImGuiOnceUponAFrame();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiOnceUponAFrame_destroy(ImGuiOnceUponAFrame* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiPayload_Clear(ImGuiPayload* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiPayload_ImGuiPayload();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImGuiPayload_IsDataType(ImGuiPayload* self, byte* type);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImGuiPayload_IsDelivery(ImGuiPayload* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImGuiPayload_IsPreview(ImGuiPayload* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiPayload_destroy(ImGuiPayload* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiPlatformImeData_ImGuiPlatformImeData();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiPlatformImeData_destroy(ImGuiPlatformImeData* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiPopupData_ImGuiPopupData();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiPopupData_destroy(ImGuiPopupData* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiPtrOrIndex_ImGuiPtrOrIndex_Ptr(void* ptr);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiPtrOrIndex_ImGuiPtrOrIndex_Int(int index);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiPtrOrIndex_destroy(ImGuiPtrOrIndex* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiSettingsHandler_ImGuiSettingsHandler();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiSettingsHandler_destroy(ImGuiSettingsHandler* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStackLevelInfo_ImGuiStackLevelInfo();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStackLevelInfo_destroy(ImGuiStackLevelInfo* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStackSizes_CompareWithCurrentState(ImGuiStackSizes* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStackSizes_ImGuiStackSizes();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStackSizes_SetToCurrentState(ImGuiStackSizes* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStackSizes_destroy(ImGuiStackSizes* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStackTool_ImGuiStackTool();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStackTool_destroy(ImGuiStackTool* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStoragePair_ImGuiStoragePair_Int(ImGuiID _key, int _val_i);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStoragePair_ImGuiStoragePair_Float(ImGuiID _key, float _val_f);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStoragePair_ImGuiStoragePair_Ptr(ImGuiID _key, void* _val_p);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStoragePair_destroy(ImGuiStoragePair* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStorage_BuildSortByKey(ImGuiStorage* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStorage_Clear(ImGuiStorage* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImGuiStorage_GetBool(ImGuiStorage* self, ImGuiID key, byte default_val);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ImGuiStorage_GetBoolRef(ImGuiStorage* self, ImGuiID key, byte default_val);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float ImGuiStorage_GetFloat(ImGuiStorage* self, ImGuiID key, float default_val);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float* ImGuiStorage_GetFloatRef(ImGuiStorage* self, ImGuiID key, float default_val);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImGuiStorage_GetInt(ImGuiStorage* self, ImGuiID key, int default_val);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int* ImGuiStorage_GetIntRef(ImGuiStorage* self, ImGuiID key, int default_val);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void* ImGuiStorage_GetVoidPtr(ImGuiStorage* self, ImGuiID key);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void** ImGuiStorage_GetVoidPtrRef(ImGuiStorage* self, ImGuiID key, void* default_val);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStorage_SetAllInt(ImGuiStorage* self, int val);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStorage_SetBool(ImGuiStorage* self, ImGuiID key, byte val);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStorage_SetFloat(ImGuiStorage* self, ImGuiID key, float val);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStorage_SetInt(ImGuiStorage* self, ImGuiID key, int val);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStorage_SetVoidPtr(ImGuiStorage* self, ImGuiID key, void* val);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStyleMod_ImGuiStyleMod_Int(ImGuiStyleVar idx, int v);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStyleMod_ImGuiStyleMod_Float(ImGuiStyleVar idx, float v);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStyleMod_ImGuiStyleMod_Vec2(ImGuiStyleVar idx, Vector2 v);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStyleMod_destroy(ImGuiStyleMod* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStyle_ImGuiStyle();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStyle_ScaleAllSizes(ImGuiStyle* self, float scale_factor);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStyle_destroy(ImGuiStyle* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ImGuiTabBar_GetTabName(ImGuiTabBar* self, ImGuiTabItem* tab);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImGuiTabBar_GetTabOrder(ImGuiTabBar* self, ImGuiTabItem* tab);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTabBar_ImGuiTabBar();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTabBar_destroy(ImGuiTabBar* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTabItem_ImGuiTabItem();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTabItem_destroy(ImGuiTabItem* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTableColumnSettings_ImGuiTableColumnSettings();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTableColumnSettings_destroy(ImGuiTableColumnSettings* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTableColumnSortSpecs_ImGuiTableColumnSortSpecs();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTableColumnSortSpecs_destroy(ImGuiTableColumnSortSpecs* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTableColumn_ImGuiTableColumn();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTableColumn_destroy(ImGuiTableColumn* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiTableColumnSettings* ImGuiTableSettings_GetColumnSettings(ImGuiTableSettings* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTableSettings_ImGuiTableSettings();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTableSettings_destroy(ImGuiTableSettings* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTableSortSpecs_ImGuiTableSortSpecs();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTableSortSpecs_destroy(ImGuiTableSortSpecs* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTableTempData_ImGuiTableTempData();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTableTempData_destroy(ImGuiTableTempData* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTable_ImGuiTable();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTable_destroy(ImGuiTable* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTextBuffer_ImGuiTextBuffer();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTextBuffer_append(ImGuiTextBuffer* self, byte* str, byte* str_end);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTextBuffer_appendf(ImGuiTextBuffer* self, byte* fmt, ... ...);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTextBuffer_appendfv(ImGuiTextBuffer* self, byte* fmt, va_list args);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ImGuiTextBuffer_begin(ImGuiTextBuffer* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ImGuiTextBuffer_c_str(ImGuiTextBuffer* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTextBuffer_clear(ImGuiTextBuffer* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTextBuffer_destroy(ImGuiTextBuffer* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImGuiTextBuffer_empty(ImGuiTextBuffer* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ImGuiTextBuffer_end(ImGuiTextBuffer* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTextBuffer_reserve(ImGuiTextBuffer* self, int capacity);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImGuiTextBuffer_size(ImGuiTextBuffer* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTextFilter_Build(ImGuiTextFilter* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTextFilter_Clear(ImGuiTextFilter* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImGuiTextFilter_Draw(ImGuiTextFilter* self, byte* label, float width);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTextFilter_ImGuiTextFilter(byte* default_filter);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImGuiTextFilter_IsActive(ImGuiTextFilter* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImGuiTextFilter_PassFilter(ImGuiTextFilter* self, byte* text, byte* text_end);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTextFilter_destroy(ImGuiTextFilter* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTextRange_ImGuiTextRange_Nil();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTextRange_ImGuiTextRange_Str(byte* _b, byte* _e);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTextRange_destroy(ImGuiTextRange* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImGuiTextRange_empty(ImGuiTextRange* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTextRange_split(ImGuiTextRange* self, byte separator, ImVector_ImGuiTextRange* out);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiViewportP_CalcWorkRectPos(Vector2* pOut, ImGuiViewportP* self, Vector2 off_min);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiViewportP_CalcWorkRectSize(Vector2* pOut, ImGuiViewportP* self, Vector2 off_min, Vector2 off_max);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiViewportP_GetBuildWorkRect(ImRect* pOut, ImGuiViewportP* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiViewportP_GetMainRect(ImRect* pOut, ImGuiViewportP* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiViewportP_GetWorkRect(ImRect* pOut, ImGuiViewportP* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiViewportP_ImGuiViewportP();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiViewportP_UpdateWorkRect(ImGuiViewportP* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiViewportP_destroy(ImGuiViewportP* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiViewport_GetCenter(Vector2* pOut, ImGuiViewport* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiViewport_GetWorkCenter(Vector2* pOut, ImGuiViewport* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiViewport_ImGuiViewport();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiViewport_destroy(ImGuiViewport* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ImGuiWindowSettings_GetName(ImGuiWindowSettings* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiWindowSettings_ImGuiWindowSettings();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiWindowSettings_destroy(ImGuiWindowSettings* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float ImGuiWindow_CalcFontSize(ImGuiWindow* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiID ImGuiWindow_GetID_Str(ImGuiWindow* self, byte* str, byte* str_end);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiID ImGuiWindow_GetID_Ptr(ImGuiWindow* self, void* ptr);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiID ImGuiWindow_GetID_Int(ImGuiWindow* self, int n);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiID ImGuiWindow_GetIDFromRectangle(ImGuiWindow* self, ImRect r_abs);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiID ImGuiWindow_GetIDNoKeepAlive_Str(ImGuiWindow* self, byte* str, byte* str_end);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiID ImGuiWindow_GetIDNoKeepAlive_Ptr(ImGuiWindow* self, void* ptr);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiID ImGuiWindow_GetIDNoKeepAlive_Int(ImGuiWindow* self, int n);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiWindow_ImGuiWindow(IntPtr context, byte* name);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float ImGuiWindow_MenuBarHeight(ImGuiWindow* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiWindow_MenuBarRect(ImRect* pOut, ImGuiWindow* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiWindow_Rect(ImRect* pOut, ImGuiWindow* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float ImGuiWindow_TitleBarHeight(ImGuiWindow* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiWindow_TitleBarRect(ImRect* pOut, ImGuiWindow* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiWindow_destroy(ImGuiWindow* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern T* ImPool_Add(ImPool* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPool_Clear(ImPool* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImPool_Contains(ImPool* self, T* p);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImPool_GetAliveCount(ImPool* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImPool_GetBufSize(ImPool* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern T* ImPool_GetByIndex(ImPool* self, ImPoolIdx n);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern T* ImPool_GetByKey(ImPool* self, ImGuiID key);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImPoolIdx ImPool_GetIndex(ImPool* self, T* p);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImPool_GetMapSize(ImPool* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern T* ImPool_GetOrAddByKey(ImPool* self, ImGuiID key);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPool_ImPool();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPool_Remove_TPtr(ImPool* self, ImGuiID key, T* p);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPool_Remove_PoolIdx(ImPool* self, ImGuiID key, ImPoolIdx idx);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPool_Reserve(ImPool* self, int capacity);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern T* ImPool_TryGetMapData(ImPool* self, ImPoolIdx n);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImPool_destroy(ImPool* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRect_Add_Vec2(ImRect* self, Vector2 p);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRect_Add_Rect(ImRect* self, ImRect r);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRect_ClipWith(ImRect* self, ImRect r);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRect_ClipWithFull(ImRect* self, ImRect r);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImRect_Contains_Vec2(ImRect* self, Vector2 p);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImRect_Contains_Rect(ImRect* self, ImRect r);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRect_Expand_Float(ImRect* self, float amount);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRect_Expand_Vec2(ImRect* self, Vector2 amount);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRect_Floor(ImRect* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float ImRect_GetArea(ImRect* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRect_GetBL(Vector2* pOut, ImRect* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRect_GetBR(Vector2* pOut, ImRect* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRect_GetCenter(Vector2* pOut, ImRect* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float ImRect_GetHeight(ImRect* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRect_GetSize(Vector2* pOut, ImRect* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRect_GetTL(Vector2* pOut, ImRect* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRect_GetTR(Vector2* pOut, ImRect* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float ImRect_GetWidth(ImRect* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRect_ImRect_Nil();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRect_ImRect_Vec2(Vector2 min, Vector2 max);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRect_ImRect_Vec4(Vector4 v);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRect_ImRect_Float(float x1, float y1, float x2, float y2);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImRect_IsInverted(ImRect* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImRect_Overlaps(ImRect* self, ImRect r);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRect_ToVec4(Vector4* pOut, ImRect* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRect_Translate(ImRect* self, Vector2 d);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRect_TranslateX(ImRect* self, float dx);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRect_TranslateY(ImRect* self, float dy);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRect_destroy(ImRect* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImSpanAllocator_GetArenaSizeInBytes(ImSpanAllocator* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void* ImSpanAllocator_GetSpanPtrBegin(ImSpanAllocator* self, int n);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void* ImSpanAllocator_GetSpanPtrEnd(ImSpanAllocator* self, int n);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImSpanAllocator_ImSpanAllocator();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImSpanAllocator_Reserve(ImSpanAllocator* self, int n, uint sz, int a);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImSpanAllocator_SetArenaBasePtr(ImSpanAllocator* self, void* base_ptr);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImSpanAllocator_destroy(ImSpanAllocator* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImSpan_ImSpan_Nil();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImSpan_ImSpan_TPtrInt(T* data, int size);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImSpan_ImSpan_TPtrTPtr(T* data, T* data_end);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern T* ImSpan_begin_Nil(ImSpan* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern T* ImSpan_begin__const(ImSpan* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImSpan_destroy(ImSpan* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern T* ImSpan_end_Nil(ImSpan* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern T* ImSpan_end__const(ImSpan* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImSpan_index_from_ptr(ImSpan* self, T* it);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImSpan_set_Int(ImSpan* self, T* data, int size);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImSpan_set_TPtr(ImSpan* self, T* data, T* data_end);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImSpan_size(ImSpan* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImSpan_size_in_bytes(ImSpan* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImVec1_ImVec1_Nil();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImVec1_ImVec1_Float(float _x);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImVec1_destroy(ImVec1* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImVec2_ImVec2_Nil();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImVec2_ImVec2_Float(float _x, float _y);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImVec2_destroy(Vector2* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImVec2ih_ImVec2ih_Nil();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImVec2ih_ImVec2ih_short(short _x, short _y);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImVec2ih_ImVec2ih_Vec2(Vector2 rhs);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImVec2ih_destroy(ImVec2ih* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImVec4_ImVec4_Nil();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImVec4_ImVec4_Float(float _x, float _y, float _z, float _w);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImVec4_destroy(Vector4* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImVector_ImVector_Nil();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImVector_ImVector_Vector_T_(ImVector_T  src);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImVector__grow_capacity(ImVector* self, int sz);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern T* ImVector_back_Nil(ImVector* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern T* ImVector_back__const(ImVector* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern T* ImVector_begin_Nil(ImVector* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern T* ImVector_begin__const(ImVector* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImVector_capacity(ImVector* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImVector_clear(ImVector* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImVector_clear_delete(ImVector* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImVector_clear_destruct(ImVector* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImVector_contains(ImVector* self, T v);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImVector_destroy(ImVector* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImVector_empty(ImVector* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern T* ImVector_end_Nil(ImVector* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern T* ImVector_end__const(ImVector* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern T* ImVector_erase_Nil(ImVector* self, T* it);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern T* ImVector_erase_TPtr(ImVector* self, T* it, T* it_last);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern T* ImVector_erase_unsorted(ImVector* self, T* it);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern T* ImVector_find_Nil(ImVector* self, T v);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern T* ImVector_find__const(ImVector* self, T v);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImVector_find_erase(ImVector* self, T v);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImVector_find_erase_unsorted(ImVector* self, T v);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern T* ImVector_front_Nil(ImVector* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern T* ImVector_front__const(ImVector* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImVector_index_from_ptr(ImVector* self, T* it);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern T* ImVector_insert(ImVector* self, T* it, T v);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImVector_max_size(ImVector* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImVector_pop_back(ImVector* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImVector_push_back(ImVector* self, T v);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImVector_push_front(ImVector* self, T v);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImVector_reserve(ImVector* self, int new_capacity);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImVector_resize_Nil(ImVector* self, int new_size);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImVector_resize_T(ImVector* self, int new_size, T v);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImVector_shrink(ImVector* self, int new_size);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImVector_size(ImVector* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImVector_size_in_bytes(ImVector* self);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImVector_swap(ImVector* self, ImVector_T * rhs);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiPayload* igAcceptDragDropPayload(byte* type, ImGuiDragDropFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igActivateItem(ImGuiID id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiID igAddContextHook(IntPtr context, ImGuiContextHook* hook);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igAlignTextToFramePadding();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igArrowButton(byte* str_id, ImGuiDir dir);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igArrowButtonEx(byte* str_id, ImGuiDir dir, Vector2 size_arg, ImGuiButtonFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igBegin(byte* name, byte* p_open, ImGuiWindowFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igBeginChild_Str(byte* str_id, Vector2 size, byte border, ImGuiWindowFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igBeginChild_ID(ImGuiID id, Vector2 size, byte border, ImGuiWindowFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igBeginChildEx(byte* name, ImGuiID id, Vector2 size_arg, byte border, ImGuiWindowFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igBeginChildFrame(ImGuiID id, Vector2 size, ImGuiWindowFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igBeginColumns(byte* str_id, int count, ImGuiOldColumnFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igBeginCombo(byte* label, byte* preview_value, ImGuiComboFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igBeginComboPopup(ImGuiID popup_id, ImRect bb, ImGuiComboFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igBeginComboPreview();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igBeginDisabled(byte disabled);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igBeginDragDropSource(ImGuiDragDropFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igBeginDragDropTarget();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igBeginDragDropTargetCustom(ImRect bb, ImGuiID id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igBeginGroup();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igBeginListBox(byte* label, Vector2 size);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igBeginMainMenuBar();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igBeginMenu(byte* label, byte enabled);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igBeginMenuBar();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igBeginMenuEx(byte* label, byte* icon, byte enabled);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igBeginPopup(byte* str_id, ImGuiWindowFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igBeginPopupContextItem(byte* str_id, ImGuiPopupFlags popup_flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igBeginPopupContextVoid(byte* str_id, ImGuiPopupFlags popup_flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igBeginPopupContextWindow(byte* str_id, ImGuiPopupFlags popup_flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igBeginPopupEx(ImGuiID id, ImGuiWindowFlags extra_flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igBeginPopupModal(byte* name, byte* p_open, ImGuiWindowFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igBeginTabBar(byte* str_id, ImGuiTabBarFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igBeginTabBarEx(ImGuiTabBar* tab_bar, ImRect bb, ImGuiTabBarFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igBeginTabItem(byte* label, byte* p_open, ImGuiTabItemFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igBeginTable(byte* str_id, int column, ImGuiTableFlags flags, Vector2 outer_size, float inner_width);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igBeginTableEx(byte* name, ImGuiID id, int columns_count, ImGuiTableFlags flags, Vector2 outer_size, float inner_width);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igBeginTooltip();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igBeginTooltipEx(ImGuiTooltipFlags tooltip_flags, ImGuiWindowFlags extra_window_flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igBeginViewportSideBar(byte* name, ImGuiViewport* viewport, ImGuiDir dir, float size, ImGuiWindowFlags window_flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igBringWindowToDisplayBack(ImGuiWindow* window);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igBringWindowToDisplayBehind(ImGuiWindow* window, ImGuiWindow* above_window);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igBringWindowToDisplayFront(ImGuiWindow* window);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igBringWindowToFocusFront(ImGuiWindow* window);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igBullet();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igBulletText(byte* fmt, ... ...);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igBulletTextV(byte* fmt, va_list args);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igButton(byte* label, Vector2 size);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igButtonBehavior(ImRect bb, ImGuiID id, byte* out_hovered, byte* out_held, ImGuiButtonFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igButtonEx(byte* label, Vector2 size_arg, ImGuiButtonFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igCalcItemSize(Vector2* pOut, Vector2 size, float default_w, float default_h);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float igCalcItemWidth();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igCalcTextSize(Vector2* pOut, byte* text, byte* text_end, byte hide_text_after_double_hash, float wrap_width);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int igCalcTypematicRepeatAmount(float t0, float t1, float repeat_delay, float repeat_rate);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igCalcWindowNextAutoFitSize(Vector2* pOut, ImGuiWindow* window);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float igCalcWrapWidthForPos(Vector2 pos, float wrap_pos_x);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igCallContextHooks(IntPtr context, ImGuiContextHookType type);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igCaptureKeyboardFromApp(byte want_capture_keyboard_value);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igCaptureMouseFromApp(byte want_capture_mouse_value);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igCheckbox(byte* label, byte* v);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igCheckboxFlags_IntPtr(byte* label, int* flags, int flags_value);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igCheckboxFlags_UintPtr(byte* label, uint* flags, uint flags_value);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igCheckboxFlags_S64Ptr(byte* label, long* flags, long flags_value);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igCheckboxFlags_U64Ptr(byte* label, ulong* flags, ulong flags_value);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igClearActiveID();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igClearDragDrop();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igClearIniSettings();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igCloseButton(ImGuiID id, Vector2 pos);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igCloseCurrentPopup();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igClosePopupToLevel(int remaining, byte restore_focus_to_window_under_popup);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igClosePopupsExceptModals();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igClosePopupsOverWindow(ImGuiWindow* ref_window, byte restore_focus_to_window_under_popup);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igCollapseButton(ImGuiID id, Vector2 pos);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igCollapsingHeader_TreeNodeFlags(byte* label, ImGuiTreeNodeFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igCollapsingHeader_BoolPtr(byte* label, byte* p_visible, ImGuiTreeNodeFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igColorButton(byte* desc_id, Vector4 col, ImGuiColorEditFlags flags, Vector2 size);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint igColorConvertFloat4ToU32(Vector4 in);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igColorConvertHSVtoRGB(float h, float s, float v, float* out_r, float* out_g, float* out_b);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igColorConvertRGBtoHSV(float r, float g, float b, float* out_h, float* out_s, float* out_v);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igColorConvertU32ToFloat4(Vector4* pOut, uint in);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igColorEdit3(byte* label, float[3] col, ImGuiColorEditFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igColorEdit4(byte* label, float[4] col, ImGuiColorEditFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igColorEditOptionsPopup(float* col, ImGuiColorEditFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igColorPicker3(byte* label, float[3] col, ImGuiColorEditFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igColorPicker4(byte* label, float[4] col, ImGuiColorEditFlags flags, float* ref_col);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igColorPickerOptionsPopup(float* ref_col, ImGuiColorEditFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igColorTooltip(byte* text, float* col, ImGuiColorEditFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igColumns(int count, byte* id, byte border);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igCombo_Str_arr(byte* label, int* current_item, char* const[] items, int items_count, int popup_max_height_in_items);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igCombo_Str(byte* label, int* current_item, byte* items_separated_by_zeros, int popup_max_height_in_items);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igCombo_FnBoolPtr(byte* label, int* current_item, bool(*)(void* data,int idx,char** out_text) items_getter, void* data, int items_count, int popup_max_height_in_items);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr igCreateContext(ImFontAtlas* shared_font_atlas);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiWindowSettings* igCreateNewWindowSettings(byte* name);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igDataTypeApplyFromText(byte* buf, ImGuiDataType data_type, void* p_data, byte* format);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igDataTypeApplyOp(ImGuiDataType data_type, int op, void* output, void* arg_1, void* arg_2);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igDataTypeClamp(ImGuiDataType data_type, void* p_data, void* p_min, void* p_max);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int igDataTypeCompare(ImGuiDataType data_type, void* arg_1, void* arg_2);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int igDataTypeFormatString(byte* buf, int buf_size, ImGuiDataType data_type, void* p_data, byte* format);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiDataTypeInfo* igDataTypeGetInfo(ImGuiDataType data_type);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igDebugCheckVersionAndDataLayout(byte* version_str, uint sz_io, uint sz_style, uint sz_vec2, uint sz_vec4, uint sz_drawvert, uint sz_drawidx);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igDebugDrawItemRect(uint col);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igDebugHookIdInfo(ImGuiID id, ImGuiDataType data_type, void* data_id, void* data_id_end);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igDebugNodeColumns(ImGuiOldColumns* columns);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igDebugNodeDrawCmdShowMeshAndBoundingBox(ImDrawList* out_draw_list, ImDrawList* draw_list, ImDrawCmd* draw_cmd, byte show_mesh, byte show_aabb);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igDebugNodeDrawList(ImGuiWindow* window, ImDrawList* draw_list, byte* label);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igDebugNodeFont(ImFont* font);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igDebugNodeStorage(ImGuiStorage* storage, byte* label);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igDebugNodeTabBar(ImGuiTabBar* tab_bar, byte* label);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igDebugNodeTable(ImGuiTable* table);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igDebugNodeTableSettings(ImGuiTableSettings* settings);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igDebugNodeViewport(ImGuiViewportP* viewport);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igDebugNodeWindow(ImGuiWindow* window, byte* label);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igDebugNodeWindowSettings(ImGuiWindowSettings* settings);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igDebugNodeWindowsList(ImVector_ImGuiWindowPtr* windows, byte* label);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igDebugNodeWindowsListByBeginStackParent(ImGuiWindow** windows, int windows_size, ImGuiWindow* parent_in_begin_stack);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igDebugRenderViewportThumbnail(ImDrawList* draw_list, ImGuiViewportP* viewport, ImRect bb);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igDebugStartItemPicker();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igDestroyContext(IntPtr ctx);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igDragBehavior(ImGuiID id, ImGuiDataType data_type, void* p_v, float v_speed, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igDragFloat(byte* label, float* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igDragFloat2(byte* label, float[2] v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igDragFloat3(byte* label, float[3] v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igDragFloat4(byte* label, float[4] v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igDragFloatRange2(byte* label, float* v_current_min, float* v_current_max, float v_speed, float v_min, float v_max, byte* format, byte* format_max, ImGuiSliderFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igDragInt(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igDragInt2(byte* label, int[2] v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igDragInt3(byte* label, int[3] v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igDragInt4(byte* label, int[4] v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igDragIntRange2(byte* label, int* v_current_min, int* v_current_max, float v_speed, int v_min, int v_max, byte* format, byte* format_max, ImGuiSliderFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igDragScalar(byte* label, ImGuiDataType data_type, void* p_data, float v_speed, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igDragScalarN(byte* label, ImGuiDataType data_type, void* p_data, int components, float v_speed, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igDummy(Vector2 size);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igEnd();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igEndChild();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igEndChildFrame();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igEndColumns();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igEndCombo();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igEndComboPreview();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igEndDisabled();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igEndDragDropSource();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igEndDragDropTarget();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igEndFrame();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igEndGroup();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igEndListBox();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igEndMainMenuBar();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igEndMenu();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igEndMenuBar();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igEndPopup();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igEndTabBar();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igEndTabItem();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igEndTable();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igEndTooltip();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igErrorCheckEndFrameRecover(ImGuiErrorLogCallback log_callback, void* user_data);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igErrorCheckEndWindowRecover(ImGuiErrorLogCallback log_callback, void* user_data);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igFindBestWindowPosForPopup(Vector2* pOut, ImGuiWindow* window);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igFindBestWindowPosForPopupEx(Vector2* pOut, Vector2 ref_pos, Vector2 size, ImGuiDir* last_dir, ImRect r_outer, ImRect r_avoid, ImGuiPopupPositionPolicy policy);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiWindow* igFindBottomMostVisibleWindowWithinBeginStack(ImGuiWindow* window);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiOldColumns* igFindOrCreateColumns(ImGuiWindow* window, ImGuiID id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiWindowSettings* igFindOrCreateWindowSettings(byte* name);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* igFindRenderedTextEnd(byte* text, byte* text_end);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiSettingsHandler* igFindSettingsHandler(byte* type_name);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiWindow* igFindWindowByID(ImGuiID id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiWindow* igFindWindowByName(byte* name);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int igFindWindowDisplayIndex(ImGuiWindow* window);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiWindowSettings* igFindWindowSettings(ImGuiID id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igFocusTopMostWindowUnderOne(ImGuiWindow* under_this_window, ImGuiWindow* ignore_window);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igFocusWindow(ImGuiWindow* window);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igGcAwakeTransientWindowBuffers(ImGuiWindow* window);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igGcCompactTransientMiscBuffers();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igGcCompactTransientWindowBuffers(ImGuiWindow* window);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiID igGetActiveID();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igGetAllocatorFunctions(ImGuiMemAllocFunc* p_alloc_func, ImGuiMemFreeFunc* p_free_func, void** p_user_data);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImDrawList* igGetBackgroundDrawList_Nil();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImDrawList* igGetBackgroundDrawList_ViewportPtr(ImGuiViewport* viewport);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* igGetClipboardText();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint igGetColorU32_Col(ImGuiCol idx, float alpha_mul);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint igGetColorU32_Vec4(Vector4 col);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint igGetColorU32_U32(uint col);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int igGetColumnIndex();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float igGetColumnNormFromOffset(ImGuiOldColumns* columns, float offset);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float igGetColumnOffset(int column_index);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float igGetColumnOffsetFromNorm(ImGuiOldColumns* columns, float offset_norm);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float igGetColumnWidth(int column_index);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int igGetColumnsCount();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiID igGetColumnsID(byte* str_id, int count);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igGetContentRegionAvail(Vector2* pOut);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igGetContentRegionMax(Vector2* pOut);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igGetContentRegionMaxAbs(Vector2* pOut);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr igGetCurrentContext();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiTable* igGetCurrentTable();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiWindow* igGetCurrentWindow();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiWindow* igGetCurrentWindowRead();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igGetCursorPos(Vector2* pOut);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float igGetCursorPosX();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float igGetCursorPosY();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igGetCursorScreenPos(Vector2* pOut);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igGetCursorStartPos(Vector2* pOut);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImFont* igGetDefaultFont();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiPayload* igGetDragDropPayload();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImDrawData* igGetDrawData();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImDrawListSharedData* igGetDrawListSharedData();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiID igGetFocusID();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiID igGetFocusScope();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiID igGetFocusedFocusScope();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImFont* igGetFont();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float igGetFontSize();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igGetFontTexUvWhitePixel(Vector2* pOut);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImDrawList* igGetForegroundDrawList_Nil();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImDrawList* igGetForegroundDrawList_WindowPtr(ImGuiWindow* window);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImDrawList* igGetForegroundDrawList_ViewportPtr(ImGuiViewport* viewport);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int igGetFrameCount();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float igGetFrameHeight();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float igGetFrameHeightWithSpacing();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiID igGetHoveredID();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiID igGetID_Str(byte* str_id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiID igGetID_StrStr(byte* str_id_begin, byte* str_id_end);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiID igGetID_Ptr(void* ptr_id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiID igGetIDWithSeed(byte* str_id_begin, byte* str_id_end, ImGuiID seed);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiIO* igGetIO();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiInputTextState* igGetInputTextState(ImGuiID id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiItemFlags igGetItemFlags();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiID igGetItemID();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igGetItemRectMax(Vector2* pOut);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igGetItemRectMin(Vector2* pOut);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igGetItemRectSize(Vector2* pOut);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiItemStatusFlags igGetItemStatusFlags();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiKeyData* igGetKeyData(ImGuiKey key);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int igGetKeyIndex(ImGuiKey key);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* igGetKeyName(ImGuiKey key);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int igGetKeyPressedAmount(ImGuiKey key, float repeat_delay, float rate);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiViewport* igGetMainViewport();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiKeyModFlags igGetMergedKeyModFlags();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int igGetMouseClickedCount(ImGuiMouseButton button);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiMouseCursor igGetMouseCursor();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igGetMouseDragDelta(Vector2* pOut, ImGuiMouseButton button, float lock_threshold);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igGetMousePos(Vector2* pOut);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igGetMousePosOnOpeningCurrentPopup(Vector2* pOut);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float igGetNavInputAmount(ImGuiNavInput n, ImGuiInputReadMode mode);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igGetNavInputAmount2d(Vector2* pOut, ImGuiNavDirSourceFlags dir_sources, ImGuiInputReadMode mode, float slow_factor, float fast_factor);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* igGetNavInputName(ImGuiNavInput n);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igGetPopupAllowedExtentRect(ImRect* pOut, ImGuiWindow* window);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float igGetScrollMaxX();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float igGetScrollMaxY();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float igGetScrollX();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float igGetScrollY();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiStorage* igGetStateStorage();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiStyle* igGetStyle();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* igGetStyleColorName(ImGuiCol idx);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern Vector4* igGetStyleColorVec4(ImGuiCol idx);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float igGetTextLineHeight();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float igGetTextLineHeightWithSpacing();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern double igGetTime();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiWindow* igGetTopMostAndVisiblePopupModal();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiWindow* igGetTopMostPopupModal();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float igGetTreeNodeToLabelSpacing();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* igGetVersion();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igGetWindowContentRegionMax(Vector2* pOut);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igGetWindowContentRegionMin(Vector2* pOut);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImDrawList* igGetWindowDrawList();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float igGetWindowHeight();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igGetWindowPos(Vector2* pOut);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiID igGetWindowResizeBorderID(ImGuiWindow* window, ImGuiDir dir);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiID igGetWindowResizeCornerID(ImGuiWindow* window, int n);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiID igGetWindowScrollbarID(ImGuiWindow* window, ImGuiAxis axis);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igGetWindowScrollbarRect(ImRect* pOut, ImGuiWindow* window, ImGuiAxis axis);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igGetWindowSize(Vector2* pOut);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float igGetWindowWidth();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int igImAbs_Int(int x);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float igImAbs_Float(float x);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern double igImAbs_double(double x);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint igImAlphaBlendColors(uint col_a, uint col_b);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igImBezierCubicCalc(Vector2* pOut, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float t);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igImBezierCubicClosestPoint(Vector2* pOut, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 p, int num_segments);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igImBezierCubicClosestPointCasteljau(Vector2* pOut, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 p, float tess_tol);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igImBezierQuadraticCalc(Vector2* pOut, Vector2 p1, Vector2 p2, Vector2 p3, float t);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igImBitArrayClearBit(uint* arr, int n);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igImBitArraySetBit(uint* arr, int n);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igImBitArraySetBitRange(uint* arr, int n, int n2);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igImBitArrayTestBit(uint* arr, int n);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igImCharIsBlankA(byte c);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igImCharIsBlankW(uint c);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igImClamp(Vector2* pOut, Vector2 v, Vector2 mn, Vector2 mx);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float igImDot(Vector2 a, Vector2 b);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igImFileClose(ImFileHandle file);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong igImFileGetSize(ImFileHandle file);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void* igImFileLoadToMemory(byte* filename, byte* mode, UIntPtr out_file_size, int padding_bytes);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImFileHandle igImFileOpen(byte* filename, byte* mode);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong igImFileRead(void* data, ulong size, ulong count, ImFileHandle file);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong igImFileWrite(void* data, ulong size, ulong count, ImFileHandle file);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float igImFloor_Float(float f);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igImFloor_Vec2(Vector2* pOut, Vector2 v);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float igImFloorSigned_Float(float f);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igImFloorSigned_Vec2(Vector2* pOut, Vector2 v);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igImFontAtlasBuildFinish(ImFontAtlas* atlas);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igImFontAtlasBuildInit(ImFontAtlas* atlas);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igImFontAtlasBuildMultiplyCalcLookupTable(unsigned char[256] out_table, float in_multiply_factor);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igImFontAtlasBuildMultiplyRectAlpha8(unsigned char[256] table, unsigned char* pixels, int x, int y, int w, int h, int stride);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igImFontAtlasBuildPackCustomRects(ImFontAtlas* atlas, void* stbrp_context_opaque);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igImFontAtlasBuildRender32bppRectFromString(ImFontAtlas* atlas, int x, int y, int w, int h, byte* in_str, byte in_marker_char, uint in_marker_pixel_value);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igImFontAtlasBuildRender8bppRectFromString(ImFontAtlas* atlas, int x, int y, int w, int h, byte* in_str, byte in_marker_char, unsigned char in_marker_pixel_value);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igImFontAtlasBuildSetupFont(ImFontAtlas* atlas, ImFont* font, ImFontConfig* font_config, float ascent, float descent);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImFontBuilderIO* igImFontAtlasGetBuilderForStbTruetype();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int igImFormatString(byte* buf, uint buf_size, byte* fmt, ... ...);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int igImFormatStringV(byte* buf, uint buf_size, byte* fmt, va_list args);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiDir igImGetDirQuadrantFromDelta(float dx, float dy);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiID igImHashData(void* data, uint data_size, uint seed);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiID igImHashStr(byte* data, uint data_size, uint seed);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float igImInvLength(Vector2 lhs, float fail_value);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igImIsFloatAboveGuaranteedIntegerPrecision(float f);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igImIsPowerOfTwo_Int(int v);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igImIsPowerOfTwo_U64(ulong v);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float igImLengthSqr_Vec2(Vector2 lhs);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float igImLengthSqr_Vec4(Vector4 lhs);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igImLerp_Vec2Float(Vector2* pOut, Vector2 a, Vector2 b, float t);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igImLerp_Vec2Vec2(Vector2* pOut, Vector2 a, Vector2 b, Vector2 t);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igImLerp_Vec4(Vector4* pOut, Vector4 a, Vector4 b, float t);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igImLineClosestPoint(Vector2* pOut, Vector2 a, Vector2 b, Vector2 p);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float igImLinearSweep(float current, float target, float speed);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float igImLog_Float(float x);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern double igImLog_double(double x);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igImMax(Vector2* pOut, Vector2 lhs, Vector2 rhs);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igImMin(Vector2* pOut, Vector2 lhs, Vector2 rhs);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int igImModPositive(int a, int b);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igImMul(Vector2* pOut, Vector2 lhs, Vector2 rhs);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* igImParseFormatFindEnd(byte* format);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* igImParseFormatFindStart(byte* format);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int igImParseFormatPrecision(byte* format, int default_value);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* igImParseFormatTrimDecorations(byte* format, byte* buf, uint buf_size);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float igImPow_Float(float x, float y);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern double igImPow_double(double x, double y);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igImQsort(void* base, uint count, uint size_of_element, int(*)(void const*,void const*) compare_func);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igImRotate(Vector2* pOut, Vector2 v, float cos_a, float sin_a);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float igImRsqrt_Float(float x);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern double igImRsqrt_double(double x);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float igImSaturate(float f);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float igImSign_Float(float x);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern double igImSign_double(double x);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* igImStrSkipBlank(byte* str);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igImStrTrimBlanks(byte* str);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImWchar* igImStrbolW(ImWchar* buf_mid_line, ImWchar* buf_begin);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* igImStrchrRange(byte* str_begin, byte* str_end, byte c);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* igImStrdup(byte* str);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* igImStrdupcpy(byte* dst, UIntPtr p_dst_size, byte* str);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* igImStreolRange(byte* str, byte* str_end);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int igImStricmp(byte* str1, byte* str2);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* igImStristr(byte* haystack, byte* haystack_end, byte* needle, byte* needle_end);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int igImStrlenW(ImWchar* str);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igImStrncpy(byte* dst, byte* src, uint count);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int igImStrnicmp(byte* str1, byte* str2, uint count);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int igImTextCharFromUtf8(uint* out_char, byte* in_text, byte* in_text_end);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* igImTextCharToUtf8(char[5] out_buf, uint c);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int igImTextCountCharsFromUtf8(byte* in_text, byte* in_text_end);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int igImTextCountUtf8BytesFromChar(byte* in_text, byte* in_text_end);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int igImTextCountUtf8BytesFromStr(ImWchar* in_text, ImWchar* in_text_end);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int igImTextStrFromUtf8(ImWchar* out_buf, int out_buf_size, byte* in_text, byte* in_text_end, char** in_remaining);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int igImTextStrToUtf8(byte* out_buf, int out_buf_size, ImWchar* in_text, ImWchar* in_text_end);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float igImTriangleArea(Vector2 a, Vector2 b, Vector2 c);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igImTriangleBarycentricCoords(Vector2 a, Vector2 b, Vector2 c, Vector2 p, float* out_u, float* out_v, float* out_w);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igImTriangleClosestPoint(Vector2* pOut, Vector2 a, Vector2 b, Vector2 c, Vector2 p);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igImTriangleContainsPoint(Vector2 a, Vector2 b, Vector2 c, Vector2 p);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int igImUpperPowerOfTwo(int v);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igImage(ImTextureID user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, Vector4 tint_col, Vector4 border_col);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igImageButton(ImTextureID user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, int frame_padding, Vector4 bg_col, Vector4 tint_col);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igImageButtonEx(ImGuiID id, ImTextureID texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, Vector2 padding, Vector4 bg_col, Vector4 tint_col);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igIndent(float indent_w);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igInitialize(IntPtr context);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igInputDouble(byte* label, double* v, double step, double step_fast, byte* format, ImGuiInputTextFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igInputFloat(byte* label, float* v, float step, float step_fast, byte* format, ImGuiInputTextFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igInputFloat2(byte* label, float[2] v, byte* format, ImGuiInputTextFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igInputFloat3(byte* label, float[3] v, byte* format, ImGuiInputTextFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igInputFloat4(byte* label, float[4] v, byte* format, ImGuiInputTextFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igInputInt(byte* label, int* v, int step, int step_fast, ImGuiInputTextFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igInputInt2(byte* label, int[2] v, ImGuiInputTextFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igInputInt3(byte* label, int[3] v, ImGuiInputTextFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igInputInt4(byte* label, int[4] v, ImGuiInputTextFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igInputScalar(byte* label, ImGuiDataType data_type, void* p_data, void* p_step, void* p_step_fast, byte* format, ImGuiInputTextFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igInputScalarN(byte* label, ImGuiDataType data_type, void* p_data, int components, void* p_step, void* p_step_fast, byte* format, ImGuiInputTextFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igInputText(byte* label, byte* buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igInputTextEx(byte* label, byte* hint, byte* buf, int buf_size, Vector2 size_arg, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igInputTextMultiline(byte* label, byte* buf, uint buf_size, Vector2 size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igInputTextWithHint(byte* label, byte* hint, byte* buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igInvisibleButton(byte* str_id, Vector2 size, ImGuiButtonFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsActiveIdUsingKey(ImGuiKey key);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsActiveIdUsingNavDir(ImGuiDir dir);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsActiveIdUsingNavInput(ImGuiNavInput input);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsAnyItemActive();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsAnyItemFocused();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsAnyItemHovered();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsAnyMouseDown();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsClippedEx(ImRect bb, ImGuiID id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsDragDropPayloadBeingAccepted();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsGamepadKey(ImGuiKey key);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsItemActivated();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsItemActive();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsItemClicked(ImGuiMouseButton mouse_button);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsItemDeactivated();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsItemDeactivatedAfterEdit();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsItemEdited();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsItemFocused();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsItemHovered(ImGuiHoveredFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsItemToggledOpen();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsItemToggledSelection();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsItemVisible();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsKeyDown(ImGuiKey key);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsKeyPressed(ImGuiKey key, byte repeat);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsKeyPressedMap(ImGuiKey key, byte repeat);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsKeyReleased(ImGuiKey key);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsLegacyKey(ImGuiKey key);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsMouseClicked(ImGuiMouseButton button, byte repeat);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsMouseDoubleClicked(ImGuiMouseButton button);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsMouseDown(ImGuiMouseButton button);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsMouseDragPastThreshold(ImGuiMouseButton button, float lock_threshold);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsMouseDragging(ImGuiMouseButton button, float lock_threshold);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsMouseHoveringRect(Vector2 r_min, Vector2 r_max, byte clip);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsMousePosValid(Vector2* mouse_pos);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsMouseReleased(ImGuiMouseButton button);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsNamedKey(ImGuiKey key);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsNavInputDown(ImGuiNavInput n);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsNavInputTest(ImGuiNavInput n, ImGuiInputReadMode rm);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsPopupOpen_Str(byte* str_id, ImGuiPopupFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsPopupOpen_ID(ImGuiID id, ImGuiPopupFlags popup_flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsRectVisible_Nil(Vector2 size);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsRectVisible_Vec2(Vector2 rect_min, Vector2 rect_max);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsWindowAbove(ImGuiWindow* potential_above, ImGuiWindow* potential_below);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsWindowAppearing();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsWindowChildOf(ImGuiWindow* window, ImGuiWindow* potential_parent, byte popup_hierarchy);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsWindowCollapsed();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsWindowFocused(ImGuiFocusedFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsWindowHovered(ImGuiHoveredFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsWindowNavFocusable(ImGuiWindow* window);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igIsWindowWithinBeginStackOf(ImGuiWindow* window, ImGuiWindow* potential_parent);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igItemAdd(ImRect bb, ImGuiID id, ImRect* nav_bb, ImGuiItemFlags extra_flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igItemHoverable(ImRect bb, ImGuiID id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igItemSize_Vec2(Vector2 size, float text_baseline_y);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igItemSize_Rect(ImRect bb, float text_baseline_y);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igKeepAliveID(ImGuiID id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igLabelText(byte* label, byte* fmt, ... ...);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igLabelTextV(byte* label, byte* fmt, va_list args);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igListBox_Str_arr(byte* label, int* current_item, char* const[] items, int items_count, int height_in_items);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igListBox_FnBoolPtr(byte* label, int* current_item, bool(*)(void* data,int idx,char** out_text) items_getter, void* data, int items_count, int height_in_items);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igLoadIniSettingsFromDisk(byte* ini_filename);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igLoadIniSettingsFromMemory(byte* ini_data, uint ini_size);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igLogBegin(ImGuiLogType type, int auto_open_depth);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igLogButtons();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igLogFinish();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igLogRenderedText(Vector2* ref_pos, byte* text, byte* text_end);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igLogSetNextTextDecoration(byte* prefix, byte* suffix);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igLogText(byte* fmt, ... ...);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igLogTextV(byte* fmt, va_list args);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igLogToBuffer(int auto_open_depth);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igLogToClipboard(int auto_open_depth);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igLogToFile(int auto_open_depth, byte* filename);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igLogToTTY(int auto_open_depth);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igMarkIniSettingsDirty_Nil();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igMarkIniSettingsDirty_WindowPtr(ImGuiWindow* window);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igMarkItemEdited(ImGuiID id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void* igMemAlloc(uint size);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igMemFree(void* ptr);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igMenuItem_Bool(byte* label, byte* shortcut, byte selected, byte enabled);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igMenuItem_BoolPtr(byte* label, byte* shortcut, byte* p_selected, byte enabled);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igMenuItemEx(byte* label, byte* icon, byte* shortcut, byte selected, byte enabled);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igNavInitRequestApplyResult();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igNavInitWindow(ImGuiWindow* window, byte force_reinit);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igNavMoveRequestApplyResult();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igNavMoveRequestButNoResultYet();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igNavMoveRequestCancel();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igNavMoveRequestForward(ImGuiDir move_dir, ImGuiDir clip_dir, ImGuiNavMoveFlags move_flags, ImGuiScrollFlags scroll_flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igNavMoveRequestResolveWithLastItem(ImGuiNavItemData* result);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igNavMoveRequestSubmit(ImGuiDir move_dir, ImGuiDir clip_dir, ImGuiNavMoveFlags move_flags, ImGuiScrollFlags scroll_flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igNavMoveRequestTryWrapping(ImGuiWindow* window, ImGuiNavMoveFlags move_flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igNewFrame();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igNewLine();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igNextColumn();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igOpenPopup_Str(byte* str_id, ImGuiPopupFlags popup_flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igOpenPopup_ID(ImGuiID id, ImGuiPopupFlags popup_flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igOpenPopupEx(ImGuiID id, ImGuiPopupFlags popup_flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igOpenPopupOnItemClick(byte* str_id, ImGuiPopupFlags popup_flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int igPlotEx(ImGuiPlotType plot_type, byte* label, float(*)(void* data,int idx) values_getter, void* data, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 frame_size);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igPlotHistogram_FloatPtr(byte* label, float* values, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igPlotHistogram_FnFloatPtr(byte* label, float(*)(void* data,int idx) values_getter, void* data, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 graph_size);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igPlotLines_FloatPtr(byte* label, float* values, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igPlotLines_FnFloatPtr(byte* label, float(*)(void* data,int idx) values_getter, void* data, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 graph_size);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igPopAllowKeyboardFocus();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igPopButtonRepeat();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igPopClipRect();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igPopColumnsBackground();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igPopFocusScope();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igPopFont();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igPopID();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igPopItemFlag();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igPopItemWidth();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igPopStyleColor(int count);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igPopStyleVar(int count);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igPopTextWrapPos();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igProgressBar(float fraction, Vector2 size_arg, byte* overlay);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igPushAllowKeyboardFocus(byte allow_keyboard_focus);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igPushButtonRepeat(byte repeat);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igPushClipRect(Vector2 clip_rect_min, Vector2 clip_rect_max, byte intersect_with_current_clip_rect);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igPushColumnClipRect(int column_index);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igPushColumnsBackground();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igPushFocusScope(ImGuiID id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igPushFont(ImFont* font);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igPushID_Str(byte* str_id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igPushID_StrStr(byte* str_id_begin, byte* str_id_end);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igPushID_Ptr(void* ptr_id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igPushID_Int(int int_id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igPushItemFlag(ImGuiItemFlags option, byte enabled);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igPushItemWidth(float item_width);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igPushMultiItemsWidths(int components, float width_full);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igPushOverrideID(ImGuiID id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igPushStyleColor_U32(ImGuiCol idx, uint col);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igPushStyleColor_Vec4(ImGuiCol idx, Vector4 col);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igPushStyleVar_Float(ImGuiStyleVar idx, float val);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igPushStyleVar_Vec2(ImGuiStyleVar idx, Vector2 val);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igPushTextWrapPos(float wrap_local_pos_x);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igRadioButton_Bool(byte* label, byte active);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igRadioButton_IntPtr(byte* label, int* v, int v_button);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igRemoveContextHook(IntPtr context, ImGuiID hook_to_remove);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igRender();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igRenderArrow(ImDrawList* draw_list, Vector2 pos, uint col, ImGuiDir dir, float scale);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igRenderArrowPointingAt(ImDrawList* draw_list, Vector2 pos, Vector2 half_sz, ImGuiDir direction, uint col);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igRenderBullet(ImDrawList* draw_list, Vector2 pos, uint col);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igRenderCheckMark(ImDrawList* draw_list, Vector2 pos, uint col, float sz);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igRenderColorRectWithAlphaCheckerboard(ImDrawList* draw_list, Vector2 p_min, Vector2 p_max, uint fill_col, float grid_step, Vector2 grid_off, float rounding, ImDrawFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igRenderFrame(Vector2 p_min, Vector2 p_max, uint fill_col, byte border, float rounding);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igRenderFrameBorder(Vector2 p_min, Vector2 p_max, float rounding);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igRenderMouseCursor(ImDrawList* draw_list, Vector2 pos, float scale, ImGuiMouseCursor mouse_cursor, uint col_fill, uint col_border, uint col_shadow);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igRenderNavHighlight(ImRect bb, ImGuiID id, ImGuiNavHighlightFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igRenderRectFilledRangeH(ImDrawList* draw_list, ImRect rect, uint col, float x_start_norm, float x_end_norm, float rounding);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igRenderRectFilledWithHole(ImDrawList* draw_list, ImRect outer, ImRect inner, uint col, float rounding);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igRenderText(Vector2 pos, byte* text, byte* text_end, byte hide_text_after_hash);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igRenderTextClipped(Vector2 pos_min, Vector2 pos_max, byte* text, byte* text_end, Vector2* text_size_if_known, Vector2 align, ImRect* clip_rect);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igRenderTextClippedEx(ImDrawList* draw_list, Vector2 pos_min, Vector2 pos_max, byte* text, byte* text_end, Vector2* text_size_if_known, Vector2 align, ImRect* clip_rect);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igRenderTextEllipsis(ImDrawList* draw_list, Vector2 pos_min, Vector2 pos_max, float clip_max_x, float ellipsis_max_x, byte* text, byte* text_end, Vector2* text_size_if_known);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igRenderTextWrapped(Vector2 pos, byte* text, byte* text_end, float wrap_width);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igResetMouseDragDelta(ImGuiMouseButton button);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSameLine(float offset_from_start_x, float spacing);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSaveIniSettingsToDisk(byte* ini_filename);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* igSaveIniSettingsToMemory(UIntPtr out_ini_size);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igScrollToBringRectIntoView(ImGuiWindow* window, ImRect rect);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igScrollToItem(ImGuiScrollFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igScrollToRect(ImGuiWindow* window, ImRect rect, ImGuiScrollFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igScrollToRectEx(Vector2* pOut, ImGuiWindow* window, ImRect rect, ImGuiScrollFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igScrollbar(ImGuiAxis axis);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igScrollbarEx(ImRect bb, ImGuiID id, ImGuiAxis axis, long* p_scroll_v, long avail_v, long contents_v, ImDrawFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igSelectable_Bool(byte* label, byte selected, ImGuiSelectableFlags flags, Vector2 size);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igSelectable_BoolPtr(byte* label, byte* p_selected, ImGuiSelectableFlags flags, Vector2 size);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSeparator();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSeparatorEx(ImGuiSeparatorFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetActiveID(ImGuiID id, ImGuiWindow* window);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetActiveIdUsingKey(ImGuiKey key);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetActiveIdUsingNavAndKeys();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetAllocatorFunctions(ImGuiMemAllocFunc alloc_func, ImGuiMemFreeFunc free_func, void* user_data);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetClipboardText(byte* text);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetColorEditOptions(ImGuiColorEditFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetColumnOffset(int column_index, float offset_x);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetColumnWidth(int column_index, float width);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetCurrentContext(IntPtr ctx);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetCurrentFont(ImFont* font);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetCursorPos(Vector2 local_pos);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetCursorPosX(float local_x);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetCursorPosY(float local_y);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetCursorScreenPos(Vector2 pos);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igSetDragDropPayload(byte* type, void* data, uint sz, ImGuiCond cond);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetFocusID(ImGuiID id, ImGuiWindow* window);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetHoveredID(ImGuiID id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetItemAllowOverlap();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetItemDefaultFocus();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetItemUsingMouseWheel();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetKeyboardFocusHere(int offset);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetLastItemData(ImGuiID item_id, ImGuiItemFlags in_flags, ImGuiItemStatusFlags status_flags, ImRect item_rect);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetMouseCursor(ImGuiMouseCursor cursor_type);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetNavID(ImGuiID id, ImGuiNavLayer nav_layer, ImGuiID focus_scope_id, ImRect rect_rel);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetNextItemOpen(byte is_open, ImGuiCond cond);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetNextItemWidth(float item_width);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetNextWindowBgAlpha(float alpha);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetNextWindowCollapsed(byte collapsed, ImGuiCond cond);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetNextWindowContentSize(Vector2 size);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetNextWindowFocus();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetNextWindowPos(Vector2 pos, ImGuiCond cond, Vector2 pivot);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetNextWindowScroll(Vector2 scroll);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetNextWindowSize(Vector2 size, ImGuiCond cond);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetNextWindowSizeConstraints(Vector2 size_min, Vector2 size_max, ImGuiSizeCallback custom_callback, void* custom_callback_data);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetScrollFromPosX_Float(float local_x, float center_x_ratio);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetScrollFromPosX_WindowPtr(ImGuiWindow* window, float local_x, float center_x_ratio);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetScrollFromPosY_Float(float local_y, float center_y_ratio);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetScrollFromPosY_WindowPtr(ImGuiWindow* window, float local_y, float center_y_ratio);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetScrollHereX(float center_x_ratio);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetScrollHereY(float center_y_ratio);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetScrollX_Float(float scroll_x);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetScrollX_WindowPtr(ImGuiWindow* window, float scroll_x);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetScrollY_Float(float scroll_y);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetScrollY_WindowPtr(ImGuiWindow* window, float scroll_y);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetStateStorage(ImGuiStorage* storage);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetTabItemClosed(byte* tab_or_docked_window_label);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetTooltip(byte* fmt, ... ...);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetTooltipV(byte* fmt, va_list args);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetWindowClipRectBeforeSetChannel(ImGuiWindow* window, ImRect clip_rect);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetWindowCollapsed_Bool(byte collapsed, ImGuiCond cond);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetWindowCollapsed_Str(byte* name, byte collapsed, ImGuiCond cond);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetWindowCollapsed_WindowPtr(ImGuiWindow* window, byte collapsed, ImGuiCond cond);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetWindowFocus_Nil();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetWindowFocus_Str(byte* name);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetWindowFontScale(float scale);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetWindowHitTestHole(ImGuiWindow* window, Vector2 pos, Vector2 size);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetWindowPos_Vec2(Vector2 pos, ImGuiCond cond);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetWindowPos_Str(byte* name, Vector2 pos, ImGuiCond cond);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetWindowPos_WindowPtr(ImGuiWindow* window, Vector2 pos, ImGuiCond cond);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetWindowSize_Vec2(Vector2 size, ImGuiCond cond);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetWindowSize_Str(byte* name, Vector2 size, ImGuiCond cond);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetWindowSize_WindowPtr(ImGuiWindow* window, Vector2 size, ImGuiCond cond);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igShadeVertsLinearColorGradientKeepAlpha(ImDrawList* draw_list, int vert_start_idx, int vert_end_idx, Vector2 gradient_p0, Vector2 gradient_p1, uint col0, uint col1);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igShadeVertsLinearUV(ImDrawList* draw_list, int vert_start_idx, int vert_end_idx, Vector2 a, Vector2 b, Vector2 uv_a, Vector2 uv_b, byte clamp);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igShowAboutWindow(byte* p_open);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igShowDemoWindow(byte* p_open);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igShowFontAtlas(ImFontAtlas* atlas);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igShowFontSelector(byte* label);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igShowMetricsWindow(byte* p_open);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igShowStackToolWindow(byte* p_open);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igShowStyleEditor(ImGuiStyle* ref);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igShowStyleSelector(byte* label);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igShowUserGuide();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igShrinkWidths(ImGuiShrinkWidthItem* items, int count, float width_excess);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igShutdown(IntPtr context);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igSliderAngle(byte* label, float* v_rad, float v_degrees_min, float v_degrees_max, byte* format, ImGuiSliderFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igSliderBehavior(ImRect bb, ImGuiID id, ImGuiDataType data_type, void* p_v, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags, ImRect* out_grab_bb);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igSliderFloat(byte* label, float* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igSliderFloat2(byte* label, float[2] v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igSliderFloat3(byte* label, float[3] v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igSliderFloat4(byte* label, float[4] v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igSliderInt(byte* label, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igSliderInt2(byte* label, int[2] v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igSliderInt3(byte* label, int[3] v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igSliderInt4(byte* label, int[4] v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igSliderScalar(byte* label, ImGuiDataType data_type, void* p_data, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igSliderScalarN(byte* label, ImGuiDataType data_type, void* p_data, int components, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igSmallButton(byte* label);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSpacing();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igSplitterBehavior(ImRect bb, ImGuiID id, ImGuiAxis axis, float* size1, float* size2, float min_size1, float min_size2, float hover_extend, float hover_visibility_delay);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igStartMouseMovingWindow(ImGuiWindow* window);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igStyleColorsClassic(ImGuiStyle* dst);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igStyleColorsDark(ImGuiStyle* dst);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igStyleColorsLight(ImGuiStyle* dst);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTabBarCloseTab(ImGuiTabBar* tab_bar, ImGuiTabItem* tab);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiTabItem* igTabBarFindTabByID(ImGuiTabBar* tab_bar, ImGuiID tab_id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igTabBarProcessReorder(ImGuiTabBar* tab_bar);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTabBarQueueReorder(ImGuiTabBar* tab_bar, ImGuiTabItem* tab, int offset);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTabBarQueueReorderFromMousePos(ImGuiTabBar* tab_bar, ImGuiTabItem* tab, Vector2 mouse_pos);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTabBarRemoveTab(ImGuiTabBar* tab_bar, ImGuiID tab_id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTabItemBackground(ImDrawList* draw_list, ImRect bb, ImGuiTabItemFlags flags, uint col);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igTabItemButton(byte* label, ImGuiTabItemFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTabItemCalcSize(Vector2* pOut, byte* label, byte has_close_button);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igTabItemEx(ImGuiTabBar* tab_bar, byte* label, byte* p_open, ImGuiTabItemFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTabItemLabelAndCloseButton(ImDrawList* draw_list, ImRect bb, ImGuiTabItemFlags flags, Vector2 frame_padding, byte* label, ImGuiID tab_id, ImGuiID close_button_id, byte is_contents_visible, byte* out_just_closed, byte* out_text_clipped);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTableBeginApplyRequests(ImGuiTable* table);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTableBeginCell(ImGuiTable* table, int column_n);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTableBeginInitMemory(ImGuiTable* table, int columns_count);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTableBeginRow(ImGuiTable* table);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTableDrawBorders(ImGuiTable* table);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTableDrawContextMenu(ImGuiTable* table);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTableEndCell(ImGuiTable* table);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTableEndRow(ImGuiTable* table);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiTable* igTableFindByID(ImGuiID id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTableFixColumnSortDirection(ImGuiTable* table, ImGuiTableColumn* column);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTableGcCompactSettings();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTableGcCompactTransientBuffers_TablePtr(ImGuiTable* table);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTableGcCompactTransientBuffers_TableTempDataPtr(ImGuiTableTempData* table);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiTableSettings* igTableGetBoundSettings(ImGuiTable* table);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTableGetCellBgRect(ImRect* pOut, ImGuiTable* table, int column_n);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int igTableGetColumnCount();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiTableColumnFlags igTableGetColumnFlags(int column_n);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int igTableGetColumnIndex();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* igTableGetColumnName_Int(int column_n);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* igTableGetColumnName_TablePtr(ImGuiTable* table, int column_n);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiSortDirection igTableGetColumnNextSortDirection(ImGuiTableColumn* column);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiID igTableGetColumnResizeID(ImGuiTable* table, int column_n, int instance_no);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float igTableGetColumnWidthAuto(ImGuiTable* table, ImGuiTableColumn* column);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float igTableGetHeaderRowHeight();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int igTableGetHoveredColumn();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern float igTableGetMaxColumnWidth(ImGuiTable* table, int column_n);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int igTableGetRowIndex();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiTableSortSpecs* igTableGetSortSpecs();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTableHeader(byte* label);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTableHeadersRow();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTableLoadSettings(ImGuiTable* table);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTableMergeDrawChannels(ImGuiTable* table);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igTableNextColumn();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTableNextRow(ImGuiTableRowFlags row_flags, float min_row_height);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTableOpenContextMenu(int column_n);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTablePopBackgroundChannel();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTablePushBackgroundChannel();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTableRemove(ImGuiTable* table);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTableResetSettings(ImGuiTable* table);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTableSaveSettings(ImGuiTable* table);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTableSetBgColor(ImGuiTableBgTarget target, uint color, int column_n);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTableSetColumnEnabled(int column_n, byte v);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igTableSetColumnIndex(int column_n);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTableSetColumnSortDirection(int column_n, ImGuiSortDirection sort_direction, byte append_to_sort_specs);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTableSetColumnWidth(int column_n, float width);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTableSetColumnWidthAutoAll(ImGuiTable* table);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTableSetColumnWidthAutoSingle(ImGuiTable* table, int column_n);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiTableSettings* igTableSettingsCreate(ImGuiID id, int columns_count);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiTableSettings* igTableSettingsFindByID(ImGuiID id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTableSettingsInstallHandler(IntPtr context);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTableSetupColumn(byte* label, ImGuiTableColumnFlags flags, float init_width_or_weight, ImGuiID user_id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTableSetupDrawChannels(ImGuiTable* table);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTableSetupScrollFreeze(int cols, int rows);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTableSortSpecsBuild(ImGuiTable* table);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTableSortSpecsSanitize(ImGuiTable* table);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTableUpdateBorders(ImGuiTable* table);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTableUpdateColumnsWeightFromWidth(ImGuiTable* table);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTableUpdateLayout(ImGuiTable* table);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igTempInputIsActive(ImGuiID id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igTempInputScalar(ImRect bb, ImGuiID id, byte* label, ImGuiDataType data_type, void* p_data, byte* format, void* p_clamp_min, void* p_clamp_max);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igTempInputText(ImRect bb, ImGuiID id, byte* label, byte* buf, int buf_size, ImGuiInputTextFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igText(byte* fmt, ... ...);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTextColored(Vector4 col, byte* fmt, ... ...);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTextColoredV(Vector4 col, byte* fmt, va_list args);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTextDisabled(byte* fmt, ... ...);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTextDisabledV(byte* fmt, va_list args);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTextEx(byte* text, byte* text_end, ImGuiTextFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTextUnformatted(byte* text, byte* text_end);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTextV(byte* fmt, va_list args);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTextWrapped(byte* fmt, ... ...);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTextWrappedV(byte* fmt, va_list args);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igTreeNode_Str(byte* label);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igTreeNode_StrStr(byte* str_id, byte* fmt, ... ...);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igTreeNode_Ptr(void* ptr_id, byte* fmt, ... ...);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igTreeNodeBehavior(ImGuiID id, ImGuiTreeNodeFlags flags, byte* label, byte* label_end);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igTreeNodeBehaviorIsOpen(ImGuiID id, ImGuiTreeNodeFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igTreeNodeEx_Str(byte* label, ImGuiTreeNodeFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igTreeNodeEx_StrStr(byte* str_id, ImGuiTreeNodeFlags flags, byte* fmt, ... ...);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igTreeNodeEx_Ptr(void* ptr_id, ImGuiTreeNodeFlags flags, byte* fmt, ... ...);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igTreeNodeExV_Str(byte* str_id, ImGuiTreeNodeFlags flags, byte* fmt, va_list args);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igTreeNodeExV_Ptr(void* ptr_id, ImGuiTreeNodeFlags flags, byte* fmt, va_list args);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igTreeNodeV_Str(byte* str_id, byte* fmt, va_list args);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igTreeNodeV_Ptr(void* ptr_id, byte* fmt, va_list args);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTreePop();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTreePush_Str(byte* str_id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTreePush_Ptr(void* ptr_id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTreePushOverrideID(ImGuiID id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igUnindent(float indent_w);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igUpdateHoveredWindowAndCaptureFlags();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igUpdateInputEvents(byte trickle_fast_inputs);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igUpdateMouseMovingWindowEndFrame();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igUpdateMouseMovingWindowNewFrame();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igUpdateWindowParentAndRootLinks(ImGuiWindow* window, ImGuiWindowFlags flags, ImGuiWindow* parent_window);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igVSliderFloat(byte* label, Vector2 size, float* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igVSliderInt(byte* label, Vector2 size, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte igVSliderScalar(byte* label, Vector2 size, ImGuiDataType data_type, void* p_data, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igValue_Bool(byte* prefix, byte b);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igValue_Int(byte* prefix, int v);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igValue_Uint(byte* prefix, uint v);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igValue_Float(byte* prefix, float v, byte* float_format);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igWindowRectAbsToRel(ImRect* pOut, ImGuiWindow* window, ImRect r);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igWindowRectRelToAbs(ImRect* pOut, ImGuiWindow* window, ImRect r);

	}
}
