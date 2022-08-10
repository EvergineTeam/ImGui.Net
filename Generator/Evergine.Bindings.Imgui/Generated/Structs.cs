using Evergine.Mathematics;
using Evergine.Bindings.Imgui;
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Evergine.Bindings.Imgui
{
	public unsafe partial struct ImColor
	{
		public Vector4 Value;

		public ImColor HSV(float h, float s, float v, float a = 1.0f)
		{
			ImColor pOut;
			ImguiNative.ImColor_HSV(&pOut, h, s, v, a);

			return pOut;
		}

		public void SetHSV(float h, float s, float v, float a = 1.0f)
		{
			ImguiNative.ImColor_SetHSV(self, h, s, v, a);
		}

		public ImColor* self => (ImColor*)Unsafe.AsPointer(ref this);

	}

	public unsafe partial struct ImDrawChannel
	{
		public ImVector _CmdBuffer;
		public ImVector _IdxBuffer;
	}

	public unsafe partial struct ImDrawCmd
	{
		public Vector4 ClipRect;
		public IntPtr TextureId;
		public uint VtxOffset;
		public uint IdxOffset;
		public uint ElemCount;
		public IntPtr UserCallback;
		public void* UserCallbackData;

		public IntPtr GetTexID()
		{
			return ImguiNative.ImDrawCmd_GetTexID(self);
		}

		public ImDrawCmd* self => (ImDrawCmd*)Unsafe.AsPointer(ref this);

	}

	public unsafe partial struct ImDrawCmdHeader
	{
		public Vector4 ClipRect;
		public IntPtr TextureId;
		public uint VtxOffset;
	}

	public unsafe partial struct ImDrawData
	{
		public byte Valid;
		public int CmdListsCount;
		public int TotalIdxCount;
		public int TotalVtxCount;
		public ImDrawList** CmdLists;
		public Vector2 DisplayPos;
		public Vector2 DisplaySize;
		public Vector2 FramebufferScale;
		public ImGuiViewport* OwnerViewport;

		public void Clear()
		{
			ImguiNative.ImDrawData_Clear(self);
		}

		public void DeIndexAllBuffers()
		{
			ImguiNative.ImDrawData_DeIndexAllBuffers(self);
		}

		public void ScaleClipRects(Vector2 fb_scale)
		{
			ImguiNative.ImDrawData_ScaleClipRects(self, fb_scale);
		}

		public ImDrawData* self => (ImDrawData*)Unsafe.AsPointer(ref this);

	}

	public unsafe partial struct ImDrawList
	{
		public ImVector CmdBuffer;
		public ImVector IdxBuffer;
		public ImVector VtxBuffer;
		public ImDrawListFlags Flags;
		public uint _VtxCurrentIdx;
		public IntPtr _Data;
		public byte* _OwnerName;
		public ImDrawVert* _VtxWritePtr;
		public ushort* _IdxWritePtr;
		public ImVector _ClipRectStack;
		public ImVector _TextureIdStack;
		public ImVector _Path;
		public ImDrawCmdHeader _CmdHeader;
		public ImDrawListSplitter _Splitter;
		public float _FringeScale;

		public void AddBezierCubic(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness, int num_segments = 0)
		{
			ImguiNative.ImDrawList_AddBezierCubic(self, p1, p2, p3, p4, col, thickness, num_segments);
		}

		public void AddBezierQuadratic(Vector2 p1, Vector2 p2, Vector2 p3, uint col, float thickness, int num_segments = 0)
		{
			ImguiNative.ImDrawList_AddBezierQuadratic(self, p1, p2, p3, col, thickness, num_segments);
		}

		public void AddCallback(IntPtr callback, void* callback_data)
		{
			ImguiNative.ImDrawList_AddCallback(self, callback, callback_data);
		}

		public void AddCircle(Vector2 center, float radius, uint col, int num_segments = 0, float thickness = 1.0f)
		{
			ImguiNative.ImDrawList_AddCircle(self, center, radius, col, num_segments, thickness);
		}

		public void AddCircleFilled(Vector2 center, float radius, uint col, int num_segments = 0)
		{
			ImguiNative.ImDrawList_AddCircleFilled(self, center, radius, col, num_segments);
		}

		public void AddConvexPolyFilled(Vector2* points, int num_points, uint col)
		{
			ImguiNative.ImDrawList_AddConvexPolyFilled(self, points, num_points, col);
		}

		public void AddDrawCmd()
		{
			ImguiNative.ImDrawList_AddDrawCmd(self);
		}

		public void AddImage(IntPtr user_texture_id, Vector2 p_min, Vector2 p_max, Vector2 uv_min, Vector2 uv_max, uint col = 4294967295)
		{
			ImguiNative.ImDrawList_AddImage(self, user_texture_id, p_min, p_max, uv_min, uv_max, col);
		}

		public void AddImageQuad(IntPtr user_texture_id, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 uv1, Vector2 uv2, Vector2 uv3, Vector2 uv4, uint col = 4294967295)
		{
			ImguiNative.ImDrawList_AddImageQuad(self, user_texture_id, p1, p2, p3, p4, uv1, uv2, uv3, uv4, col);
		}

		public void AddImageRounded(IntPtr user_texture_id, Vector2 p_min, Vector2 p_max, Vector2 uv_min, Vector2 uv_max, uint col, float rounding, ImDrawFlags flags = 0)
		{
			ImguiNative.ImDrawList_AddImageRounded(self, user_texture_id, p_min, p_max, uv_min, uv_max, col, rounding, flags);
		}

		public void AddLine(Vector2 p1, Vector2 p2, uint col, float thickness = 1.0f)
		{
			ImguiNative.ImDrawList_AddLine(self, p1, p2, col, thickness);
		}

		public void AddNgon(Vector2 center, float radius, uint col, int num_segments, float thickness = 1.0f)
		{
			ImguiNative.ImDrawList_AddNgon(self, center, radius, col, num_segments, thickness);
		}

		public void AddNgonFilled(Vector2 center, float radius, uint col, int num_segments)
		{
			ImguiNative.ImDrawList_AddNgonFilled(self, center, radius, col, num_segments);
		}

		public void AddPolyline(Vector2* points, int num_points, uint col, ImDrawFlags flags, float thickness)
		{
			ImguiNative.ImDrawList_AddPolyline(self, points, num_points, col, flags, thickness);
		}

		public void AddQuad(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness = 1.0f)
		{
			ImguiNative.ImDrawList_AddQuad(self, p1, p2, p3, p4, col, thickness);
		}

		public void AddQuadFilled(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col)
		{
			ImguiNative.ImDrawList_AddQuadFilled(self, p1, p2, p3, p4, col);
		}

		public void AddRect(Vector2 p_min, Vector2 p_max, uint col, float rounding = 0.0f, ImDrawFlags flags = 0, float thickness = 1.0f)
		{
			ImguiNative.ImDrawList_AddRect(self, p_min, p_max, col, rounding, flags, thickness);
		}

		public void AddRectFilled(Vector2 p_min, Vector2 p_max, uint col, float rounding = 0.0f, ImDrawFlags flags = 0)
		{
			ImguiNative.ImDrawList_AddRectFilled(self, p_min, p_max, col, rounding, flags);
		}

		public void AddRectFilledMultiColor(Vector2 p_min, Vector2 p_max, uint col_upr_left, uint col_upr_right, uint col_bot_right, uint col_bot_left)
		{
			ImguiNative.ImDrawList_AddRectFilledMultiColor(self, p_min, p_max, col_upr_left, col_upr_right, col_bot_right, col_bot_left);
		}

		public void AddText_Vec2(Vector2 pos, uint col, [MarshalAs(UnmanagedType.LPStr)] string text_begin, [MarshalAs(UnmanagedType.LPStr)] string text_end = null)
		{
			ImguiNative.ImDrawList_AddText_Vec2(self, pos, col, text_begin, text_end);
		}

		public void AddText_FontPtr(ImFont* font, float font_size, Vector2 pos, uint col, [MarshalAs(UnmanagedType.LPStr)] string text_begin, [MarshalAs(UnmanagedType.LPStr)] string text_end = null, float wrap_width = 0.0f, Vector4* cpu_fine_clip_rect = null)
		{
			ImguiNative.ImDrawList_AddText_FontPtr(self, font, font_size, pos, col, text_begin, text_end, wrap_width, cpu_fine_clip_rect);
		}

		public void AddTriangle(Vector2 p1, Vector2 p2, Vector2 p3, uint col, float thickness = 1.0f)
		{
			ImguiNative.ImDrawList_AddTriangle(self, p1, p2, p3, col, thickness);
		}

		public void AddTriangleFilled(Vector2 p1, Vector2 p2, Vector2 p3, uint col)
		{
			ImguiNative.ImDrawList_AddTriangleFilled(self, p1, p2, p3, col);
		}

		public void ChannelsMerge()
		{
			ImguiNative.ImDrawList_ChannelsMerge(self);
		}

		public void ChannelsSetCurrent(int n)
		{
			ImguiNative.ImDrawList_ChannelsSetCurrent(self, n);
		}

		public void ChannelsSplit(int count)
		{
			ImguiNative.ImDrawList_ChannelsSplit(self, count);
		}

		public ImDrawList* CloneOutput()
		{
			return ImguiNative.ImDrawList_CloneOutput(self);
		}

		public Vector2 GetClipRectMax()
		{
			Vector2 pOut;
			ImguiNative.ImDrawList_GetClipRectMax(&pOut, self);

			return pOut;
		}

		public Vector2 GetClipRectMin()
		{
			Vector2 pOut;
			ImguiNative.ImDrawList_GetClipRectMin(&pOut, self);

			return pOut;
		}

		public void PathArcTo(Vector2 center, float radius, float a_min, float a_max, int num_segments = 0)
		{
			ImguiNative.ImDrawList_PathArcTo(self, center, radius, a_min, a_max, num_segments);
		}

		public void PathArcToFast(Vector2 center, float radius, int a_min_of_12, int a_max_of_12)
		{
			ImguiNative.ImDrawList_PathArcToFast(self, center, radius, a_min_of_12, a_max_of_12);
		}

		public void PathBezierCubicCurveTo(Vector2 p2, Vector2 p3, Vector2 p4, int num_segments = 0)
		{
			ImguiNative.ImDrawList_PathBezierCubicCurveTo(self, p2, p3, p4, num_segments);
		}

		public void PathBezierQuadraticCurveTo(Vector2 p2, Vector2 p3, int num_segments = 0)
		{
			ImguiNative.ImDrawList_PathBezierQuadraticCurveTo(self, p2, p3, num_segments);
		}

		public void PathClear()
		{
			ImguiNative.ImDrawList_PathClear(self);
		}

		public void PathFillConvex(uint col)
		{
			ImguiNative.ImDrawList_PathFillConvex(self, col);
		}

		public void PathLineTo(Vector2 pos)
		{
			ImguiNative.ImDrawList_PathLineTo(self, pos);
		}

		public void PathLineToMergeDuplicate(Vector2 pos)
		{
			ImguiNative.ImDrawList_PathLineToMergeDuplicate(self, pos);
		}

		public void PathRect(Vector2 rect_min, Vector2 rect_max, float rounding = 0.0f, ImDrawFlags flags = 0)
		{
			ImguiNative.ImDrawList_PathRect(self, rect_min, rect_max, rounding, flags);
		}

		public void PathStroke(uint col, ImDrawFlags flags = 0, float thickness = 1.0f)
		{
			ImguiNative.ImDrawList_PathStroke(self, col, flags, thickness);
		}

		public void PopClipRect()
		{
			ImguiNative.ImDrawList_PopClipRect(self);
		}

		public void PopTextureID()
		{
			ImguiNative.ImDrawList_PopTextureID(self);
		}

		public void PrimQuadUV(Vector2 a, Vector2 b, Vector2 c, Vector2 d, Vector2 uv_a, Vector2 uv_b, Vector2 uv_c, Vector2 uv_d, uint col)
		{
			ImguiNative.ImDrawList_PrimQuadUV(self, a, b, c, d, uv_a, uv_b, uv_c, uv_d, col);
		}

		public void PrimRect(Vector2 a, Vector2 b, uint col)
		{
			ImguiNative.ImDrawList_PrimRect(self, a, b, col);
		}

		public void PrimRectUV(Vector2 a, Vector2 b, Vector2 uv_a, Vector2 uv_b, uint col)
		{
			ImguiNative.ImDrawList_PrimRectUV(self, a, b, uv_a, uv_b, col);
		}

		public void PrimReserve(int idx_count, int vtx_count)
		{
			ImguiNative.ImDrawList_PrimReserve(self, idx_count, vtx_count);
		}

		public void PrimUnreserve(int idx_count, int vtx_count)
		{
			ImguiNative.ImDrawList_PrimUnreserve(self, idx_count, vtx_count);
		}

		public void PrimVtx(Vector2 pos, Vector2 uv, uint col)
		{
			ImguiNative.ImDrawList_PrimVtx(self, pos, uv, col);
		}

		public void PrimWriteIdx(ushort idx)
		{
			ImguiNative.ImDrawList_PrimWriteIdx(self, idx);
		}

		public void PrimWriteVtx(Vector2 pos, Vector2 uv, uint col)
		{
			ImguiNative.ImDrawList_PrimWriteVtx(self, pos, uv, col);
		}

		public void PushClipRect(Vector2 clip_rect_min, Vector2 clip_rect_max, [MarshalAs(UnmanagedType.Bool)] bool intersect_with_current_clip_rect = true)
		{
			ImguiNative.ImDrawList_PushClipRect(self, clip_rect_min, clip_rect_max, intersect_with_current_clip_rect);
		}

		public void PushClipRectFullScreen()
		{
			ImguiNative.ImDrawList_PushClipRectFullScreen(self);
		}

		public void PushTextureID(IntPtr texture_id)
		{
			ImguiNative.ImDrawList_PushTextureID(self, texture_id);
		}

		public int _CalcCircleAutoSegmentCount(float radius)
		{
			return ImguiNative.ImDrawList__CalcCircleAutoSegmentCount(self, radius);
		}

		public void _ClearFreeMemory()
		{
			ImguiNative.ImDrawList__ClearFreeMemory(self);
		}

		public void _OnChangedClipRect()
		{
			ImguiNative.ImDrawList__OnChangedClipRect(self);
		}

		public void _OnChangedTextureID()
		{
			ImguiNative.ImDrawList__OnChangedTextureID(self);
		}

		public void _OnChangedVtxOffset()
		{
			ImguiNative.ImDrawList__OnChangedVtxOffset(self);
		}

		public void _PathArcToFastEx(Vector2 center, float radius, int a_min_sample, int a_max_sample, int a_step)
		{
			ImguiNative.ImDrawList__PathArcToFastEx(self, center, radius, a_min_sample, a_max_sample, a_step);
		}

		public void _PathArcToN(Vector2 center, float radius, float a_min, float a_max, int num_segments)
		{
			ImguiNative.ImDrawList__PathArcToN(self, center, radius, a_min, a_max, num_segments);
		}

		public void _PopUnusedDrawCmd()
		{
			ImguiNative.ImDrawList__PopUnusedDrawCmd(self);
		}

		public void _ResetForNewFrame()
		{
			ImguiNative.ImDrawList__ResetForNewFrame(self);
		}

		public void _TryMergeDrawCmds()
		{
			ImguiNative.ImDrawList__TryMergeDrawCmds(self);
		}

		public ImDrawList* self => (ImDrawList*)Unsafe.AsPointer(ref this);

	}

	public unsafe partial struct ImDrawListSplitter
	{
		public int _Current;
		public int _Count;
		public ImVector _Channels;

		public void Clear()
		{
			ImguiNative.ImDrawListSplitter_Clear(self);
		}

		public void ClearFreeMemory()
		{
			ImguiNative.ImDrawListSplitter_ClearFreeMemory(self);
		}

		public void Merge(ImDrawList* draw_list)
		{
			ImguiNative.ImDrawListSplitter_Merge(self, draw_list);
		}

		public void SetCurrentChannel(ImDrawList* draw_list, int channel_idx)
		{
			ImguiNative.ImDrawListSplitter_SetCurrentChannel(self, draw_list, channel_idx);
		}

		public void Split(ImDrawList* draw_list, int count)
		{
			ImguiNative.ImDrawListSplitter_Split(self, draw_list, count);
		}

		public ImDrawListSplitter* self => (ImDrawListSplitter*)Unsafe.AsPointer(ref this);

	}

	public unsafe partial struct ImDrawVert
	{
		public Vector2 pos;
		public Vector2 uv;
		public uint col;
	}

	public unsafe partial struct ImFont
	{
		public ImVector IndexAdvanceX;
		public float FallbackAdvanceX;
		public float FontSize;
		public ImVector IndexLookup;
		public ImVector Glyphs;
		public ImFontGlyph* FallbackGlyph;
		public ImFontAtlas* ContainerAtlas;
		public ImFontConfig* ConfigData;
		public short ConfigDataCount;
		public ushort FallbackChar;
		public ushort EllipsisChar;
		public ushort DotChar;
		public byte DirtyLookupTables;
		public float Scale;
		public float Ascent;
		public float Descent;
		public int MetricsTotalSurface;
		public fixed byte Used4kPagesMap[2];

		public void AddGlyph(ImFontConfig* src_cfg, ushort c, float x0, float y0, float x1, float y1, float u0, float v0, float u1, float v1, float advance_x)
		{
			ImguiNative.ImFont_AddGlyph(self, src_cfg, c, x0, y0, x1, y1, u0, v0, u1, v1, advance_x);
		}

		public void AddRemapChar(ushort dst, ushort src, [MarshalAs(UnmanagedType.Bool)] bool overwrite_dst = true)
		{
			ImguiNative.ImFont_AddRemapChar(self, dst, src, overwrite_dst);
		}

		public void BuildLookupTable()
		{
			ImguiNative.ImFont_BuildLookupTable(self);
		}

		public Vector2 CalcTextSizeA(float size, float max_width, float wrap_width, [MarshalAs(UnmanagedType.LPStr)] string text_begin, [MarshalAs(UnmanagedType.LPStr)] string text_end = null, char** remaining = null)
		{
			Vector2 pOut;
			ImguiNative.ImFont_CalcTextSizeA(&pOut, self, size, max_width, wrap_width, text_begin, text_end, remaining);

			return pOut;
		}

		public string CalcWordWrapPositionA(float scale, [MarshalAs(UnmanagedType.LPStr)] string text, [MarshalAs(UnmanagedType.LPStr)] string text_end, float wrap_width)
		{
			return ImguiNative.ImFont_CalcWordWrapPositionA(self, scale, text, text_end, wrap_width);
		}

		public void ClearOutputData()
		{
			ImguiNative.ImFont_ClearOutputData(self);
		}

		public ImFontGlyph* FindGlyph(ushort c)
		{
			return ImguiNative.ImFont_FindGlyph(self, c);
		}

		public ImFontGlyph* FindGlyphNoFallback(ushort c)
		{
			return ImguiNative.ImFont_FindGlyphNoFallback(self, c);
		}

		public float GetCharAdvance(ushort c)
		{
			return ImguiNative.ImFont_GetCharAdvance(self, c);
		}

		public string GetDebugName()
		{
			return ImguiNative.ImFont_GetDebugName(self);
		}

		public void GrowIndex(int new_size)
		{
			ImguiNative.ImFont_GrowIndex(self, new_size);
		}

		public bool IsGlyphRangeUnused(uint c_begin, uint c_last)
		{
			return ImguiNative.ImFont_IsGlyphRangeUnused(self, c_begin, c_last);
		}

		public bool IsLoaded()
		{
			return ImguiNative.ImFont_IsLoaded(self);
		}

		public void RenderChar(ImDrawList* draw_list, float size, Vector2 pos, uint col, ushort c)
		{
			ImguiNative.ImFont_RenderChar(self, draw_list, size, pos, col, c);
		}

		public void RenderText(ImDrawList* draw_list, float size, Vector2 pos, uint col, Vector4 clip_rect, [MarshalAs(UnmanagedType.LPStr)] string text_begin, [MarshalAs(UnmanagedType.LPStr)] string text_end, float wrap_width = 0.0f, [MarshalAs(UnmanagedType.Bool)] bool cpu_fine_clip = true)
		{
			ImguiNative.ImFont_RenderText(self, draw_list, size, pos, col, clip_rect, text_begin, text_end, wrap_width, cpu_fine_clip);
		}

		public void SetGlyphVisible(ushort c, [MarshalAs(UnmanagedType.Bool)] bool visible)
		{
			ImguiNative.ImFont_SetGlyphVisible(self, c, visible);
		}

		public ImFont* self => (ImFont*)Unsafe.AsPointer(ref this);

	}

	public unsafe partial struct ImFontAtlas
	{
		public ImFontAtlasFlags Flags;
		public IntPtr TexID;
		public int TexDesiredWidth;
		public int TexGlyphPadding;
		public byte Locked;
		public byte TexReady;
		public byte TexPixelsUseColors;
		public byte* TexPixelsAlpha8;
		public uint* TexPixelsRGBA32;
		public int TexWidth;
		public int TexHeight;
		public Vector2 TexUvScale;
		public Vector2 TexUvWhitePixel;
		public ImVector Fonts;
		public ImVector CustomRects;
		public ImVector ConfigData;
		public Vector4 TexUvLines_0;
		public Vector4 TexUvLines_1;
		public Vector4 TexUvLines_2;
		public Vector4 TexUvLines_3;
		public Vector4 TexUvLines_4;
		public Vector4 TexUvLines_5;
		public Vector4 TexUvLines_6;
		public Vector4 TexUvLines_7;
		public Vector4 TexUvLines_8;
		public Vector4 TexUvLines_9;
		public Vector4 TexUvLines_10;
		public Vector4 TexUvLines_11;
		public Vector4 TexUvLines_12;
		public Vector4 TexUvLines_13;
		public Vector4 TexUvLines_14;
		public Vector4 TexUvLines_15;
		public Vector4 TexUvLines_16;
		public Vector4 TexUvLines_17;
		public Vector4 TexUvLines_18;
		public Vector4 TexUvLines_19;
		public Vector4 TexUvLines_20;
		public Vector4 TexUvLines_21;
		public Vector4 TexUvLines_22;
		public Vector4 TexUvLines_23;
		public Vector4 TexUvLines_24;
		public Vector4 TexUvLines_25;
		public Vector4 TexUvLines_26;
		public Vector4 TexUvLines_27;
		public Vector4 TexUvLines_28;
		public Vector4 TexUvLines_29;
		public Vector4 TexUvLines_30;
		public Vector4 TexUvLines_31;
		public Vector4 TexUvLines_32;
		public Vector4 TexUvLines_33;
		public Vector4 TexUvLines_34;
		public Vector4 TexUvLines_35;
		public Vector4 TexUvLines_36;
		public Vector4 TexUvLines_37;
		public Vector4 TexUvLines_38;
		public Vector4 TexUvLines_39;
		public Vector4 TexUvLines_40;
		public Vector4 TexUvLines_41;
		public Vector4 TexUvLines_42;
		public Vector4 TexUvLines_43;
		public Vector4 TexUvLines_44;
		public Vector4 TexUvLines_45;
		public Vector4 TexUvLines_46;
		public Vector4 TexUvLines_47;
		public Vector4 TexUvLines_48;
		public Vector4 TexUvLines_49;
		public Vector4 TexUvLines_50;
		public Vector4 TexUvLines_51;
		public Vector4 TexUvLines_52;
		public Vector4 TexUvLines_53;
		public Vector4 TexUvLines_54;
		public Vector4 TexUvLines_55;
		public Vector4 TexUvLines_56;
		public Vector4 TexUvLines_57;
		public Vector4 TexUvLines_58;
		public Vector4 TexUvLines_59;
		public Vector4 TexUvLines_60;
		public Vector4 TexUvLines_61;
		public Vector4 TexUvLines_62;
		public Vector4 TexUvLines_63;
		public IntPtr FontBuilderIO;
		public uint FontBuilderFlags;
		public int PackIdMouseCursors;
		public int PackIdLines;

		public int AddCustomRectFontGlyph(ImFont* font, ushort id, int width, int height, float advance_x, Vector2 offset)
		{
			return ImguiNative.ImFontAtlas_AddCustomRectFontGlyph(self, font, id, width, height, advance_x, offset);
		}

		public int AddCustomRectRegular(int width, int height)
		{
			return ImguiNative.ImFontAtlas_AddCustomRectRegular(self, width, height);
		}

		public ImFont* AddFont(ImFontConfig* font_cfg)
		{
			return ImguiNative.ImFontAtlas_AddFont(self, font_cfg);
		}

		public ImFont* AddFontDefault(ImFontConfig* font_cfg = null)
		{
			return ImguiNative.ImFontAtlas_AddFontDefault(self, font_cfg);
		}

		public ImFont* AddFontFromFileTTF([MarshalAs(UnmanagedType.LPStr)] string filename, float size_pixels, ImFontConfig* font_cfg = null, ushort* glyph_ranges = null)
		{
			return ImguiNative.ImFontAtlas_AddFontFromFileTTF(self, filename, size_pixels, font_cfg, glyph_ranges);
		}

		public ImFont* AddFontFromMemoryCompressedBase85TTF([MarshalAs(UnmanagedType.LPStr)] string compressed_font_data_base85, float size_pixels, ImFontConfig* font_cfg = null, ushort* glyph_ranges = null)
		{
			return ImguiNative.ImFontAtlas_AddFontFromMemoryCompressedBase85TTF(self, compressed_font_data_base85, size_pixels, font_cfg, glyph_ranges);
		}

		public ImFont* AddFontFromMemoryCompressedTTF(void* compressed_font_data, int compressed_font_size, float size_pixels, ImFontConfig* font_cfg = null, ushort* glyph_ranges = null)
		{
			return ImguiNative.ImFontAtlas_AddFontFromMemoryCompressedTTF(self, compressed_font_data, compressed_font_size, size_pixels, font_cfg, glyph_ranges);
		}

		public ImFont* AddFontFromMemoryTTF(void* font_data, int font_size, float size_pixels, ImFontConfig* font_cfg = null, ushort* glyph_ranges = null)
		{
			return ImguiNative.ImFontAtlas_AddFontFromMemoryTTF(self, font_data, font_size, size_pixels, font_cfg, glyph_ranges);
		}

		public bool Build()
		{
			return ImguiNative.ImFontAtlas_Build(self);
		}

		public void CalcCustomRectUV(ImFontAtlasCustomRect* rect, Vector2* out_uv_min, Vector2* out_uv_max)
		{
			ImguiNative.ImFontAtlas_CalcCustomRectUV(self, rect, out_uv_min, out_uv_max);
		}

		public void Clear()
		{
			ImguiNative.ImFontAtlas_Clear(self);
		}

		public void ClearFonts()
		{
			ImguiNative.ImFontAtlas_ClearFonts(self);
		}

		public void ClearInputData()
		{
			ImguiNative.ImFontAtlas_ClearInputData(self);
		}

		public void ClearTexData()
		{
			ImguiNative.ImFontAtlas_ClearTexData(self);
		}

		public ImFontAtlasCustomRect* GetCustomRectByIndex(int index)
		{
			return ImguiNative.ImFontAtlas_GetCustomRectByIndex(self, index);
		}

		public ushort* GetGlyphRangesChineseFull()
		{
			return ImguiNative.ImFontAtlas_GetGlyphRangesChineseFull(self);
		}

		public ushort* GetGlyphRangesChineseSimplifiedCommon()
		{
			return ImguiNative.ImFontAtlas_GetGlyphRangesChineseSimplifiedCommon(self);
		}

		public ushort* GetGlyphRangesCyrillic()
		{
			return ImguiNative.ImFontAtlas_GetGlyphRangesCyrillic(self);
		}

		public ushort* GetGlyphRangesDefault()
		{
			return ImguiNative.ImFontAtlas_GetGlyphRangesDefault(self);
		}

		public ushort* GetGlyphRangesJapanese()
		{
			return ImguiNative.ImFontAtlas_GetGlyphRangesJapanese(self);
		}

		public ushort* GetGlyphRangesKorean()
		{
			return ImguiNative.ImFontAtlas_GetGlyphRangesKorean(self);
		}

		public ushort* GetGlyphRangesThai()
		{
			return ImguiNative.ImFontAtlas_GetGlyphRangesThai(self);
		}

		public ushort* GetGlyphRangesVietnamese()
		{
			return ImguiNative.ImFontAtlas_GetGlyphRangesVietnamese(self);
		}

		public bool GetMouseCursorTexData(ImGuiMouseCursor cursor, Vector2* out_offset, Vector2* out_size, Vector2* out_uv_border, Vector2* out_uv_fill)
		{
			return ImguiNative.ImFontAtlas_GetMouseCursorTexData(self, cursor, out_offset, out_size, out_uv_border, out_uv_fill);
		}

		public void GetTexDataAsAlpha8(byte** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel = null)
		{
			ImguiNative.ImFontAtlas_GetTexDataAsAlpha8(self, out_pixels, out_width, out_height, out_bytes_per_pixel);
		}

		public void GetTexDataAsRGBA32(byte** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel = null)
		{
			ImguiNative.ImFontAtlas_GetTexDataAsRGBA32(self, out_pixels, out_width, out_height, out_bytes_per_pixel);
		}

		public bool IsBuilt()
		{
			return ImguiNative.ImFontAtlas_IsBuilt(self);
		}

		public void SetTexID(IntPtr id)
		{
			ImguiNative.ImFontAtlas_SetTexID(self, id);
		}

		public ImFontAtlas* self => (ImFontAtlas*)Unsafe.AsPointer(ref this);

	}

	public unsafe partial struct ImFontAtlasCustomRect
	{
		public ushort Width;
		public ushort Height;
		public ushort X;
		public ushort Y;
		public uint GlyphID;
		public float GlyphAdvanceX;
		public Vector2 GlyphOffset;
		public ImFont* Font;

		public bool IsPacked()
		{
			return ImguiNative.ImFontAtlasCustomRect_IsPacked(self);
		}

		public ImFontAtlasCustomRect* self => (ImFontAtlasCustomRect*)Unsafe.AsPointer(ref this);

	}

	public unsafe partial struct ImFontConfig
	{
		public void* FontData;
		public int FontDataSize;
		public byte FontDataOwnedByAtlas;
		public int FontNo;
		public float SizePixels;
		public int OversampleH;
		public int OversampleV;
		public byte PixelSnapH;
		public Vector2 GlyphExtraSpacing;
		public Vector2 GlyphOffset;
		public ushort* GlyphRanges;
		public float GlyphMinAdvanceX;
		public float GlyphMaxAdvanceX;
		public byte MergeMode;
		public uint FontBuilderFlags;
		public float RasterizerMultiply;
		public ushort EllipsisChar;
		public fixed byte Name[40];
		public ImFont* DstFont;
	}

	public unsafe partial struct ImFontGlyph
	{
		public uint Colored;
		public uint Visible;
		public uint Codepoint;
		public float AdvanceX;
		public float X0;
		public float Y0;
		public float X1;
		public float Y1;
		public float U0;
		public float V0;
		public float U1;
		public float V1;
	}

	public unsafe partial struct ImFontGlyphRangesBuilder
	{
		public ImVector UsedChars;

		public void AddChar(ushort c)
		{
			ImguiNative.ImFontGlyphRangesBuilder_AddChar(self, c);
		}

		public void AddRanges(ushort* ranges)
		{
			ImguiNative.ImFontGlyphRangesBuilder_AddRanges(self, ranges);
		}

		public void AddText([MarshalAs(UnmanagedType.LPStr)] string text, [MarshalAs(UnmanagedType.LPStr)] string text_end = null)
		{
			ImguiNative.ImFontGlyphRangesBuilder_AddText(self, text, text_end);
		}

		public void BuildRanges(ImVector* out_ranges)
		{
			ImguiNative.ImFontGlyphRangesBuilder_BuildRanges(self, out_ranges);
		}

		public void Clear()
		{
			ImguiNative.ImFontGlyphRangesBuilder_Clear(self);
		}

		public bool GetBit(uint n)
		{
			return ImguiNative.ImFontGlyphRangesBuilder_GetBit(self, n);
		}

		public void SetBit(uint n)
		{
			ImguiNative.ImFontGlyphRangesBuilder_SetBit(self, n);
		}

		public ImFontGlyphRangesBuilder* self => (ImFontGlyphRangesBuilder*)Unsafe.AsPointer(ref this);

	}

	public unsafe partial struct ImGuiIO
	{
		public ImGuiConfigFlags ConfigFlags;
		public ImGuiBackendFlags BackendFlags;
		public Vector2 DisplaySize;
		public float DeltaTime;
		public float IniSavingRate;
		public byte* IniFilename;
		public byte* LogFilename;
		public float MouseDoubleClickTime;
		public float MouseDoubleClickMaxDist;
		public float MouseDragThreshold;
		public float KeyRepeatDelay;
		public float KeyRepeatRate;
		public void* UserData;
		public ImFontAtlas* Fonts;
		public float FontGlobalScale;
		public byte FontAllowUserScaling;
		public ImFont* FontDefault;
		public Vector2 DisplayFramebufferScale;
		public byte ConfigDockingNoSplit;
		public byte ConfigDockingWithShift;
		public byte ConfigDockingAlwaysTabBar;
		public byte ConfigDockingTransparentPayload;
		public byte ConfigViewportsNoAutoMerge;
		public byte ConfigViewportsNoTaskBarIcon;
		public byte ConfigViewportsNoDecoration;
		public byte ConfigViewportsNoDefaultParent;
		public byte MouseDrawCursor;
		public byte ConfigMacOSXBehaviors;
		public byte ConfigInputTrickleEventQueue;
		public byte ConfigInputTextCursorBlink;
		public byte ConfigDragClickToInputText;
		public byte ConfigWindowsResizeFromEdges;
		public byte ConfigWindowsMoveFromTitleBarOnly;
		public float ConfigMemoryCompactTimer;
		public byte* BackendPlatformName;
		public byte* BackendRendererName;
		public void* BackendPlatformUserData;
		public void* BackendRendererUserData;
		public void* BackendLanguageUserData;
		public IntPtr GetClipboardTextFn;
		public IntPtr SetClipboardTextFn;
		public void* ClipboardUserData;
		public IntPtr SetPlatformImeDataFn;
		public void* _UnusedPadding;
		public byte WantCaptureMouse;
		public byte WantCaptureKeyboard;
		public byte WantTextInput;
		public byte WantSetMousePos;
		public byte WantSaveIniSettings;
		public byte NavActive;
		public byte NavVisible;
		public float Framerate;
		public int MetricsRenderVertices;
		public int MetricsRenderIndices;
		public int MetricsRenderWindows;
		public int MetricsActiveWindows;
		public int MetricsActiveAllocations;
		public Vector2 MouseDelta;
		public fixed int KeyMap[645];
		public fixed byte KeysDown[645];
		public Vector2 MousePos;
		public fixed byte MouseDown[5];
		public float MouseWheel;
		public float MouseWheelH;
		public uint MouseHoveredViewport;
		public byte KeyCtrl;
		public byte KeyShift;
		public byte KeyAlt;
		public byte KeySuper;
		public fixed float NavInputs[20];
		public ImGuiModFlags KeyMods;
		public ImGuiKeyData KeysData_0;
		public ImGuiKeyData KeysData_1;
		public ImGuiKeyData KeysData_2;
		public ImGuiKeyData KeysData_3;
		public ImGuiKeyData KeysData_4;
		public ImGuiKeyData KeysData_5;
		public ImGuiKeyData KeysData_6;
		public ImGuiKeyData KeysData_7;
		public ImGuiKeyData KeysData_8;
		public ImGuiKeyData KeysData_9;
		public ImGuiKeyData KeysData_10;
		public ImGuiKeyData KeysData_11;
		public ImGuiKeyData KeysData_12;
		public ImGuiKeyData KeysData_13;
		public ImGuiKeyData KeysData_14;
		public ImGuiKeyData KeysData_15;
		public ImGuiKeyData KeysData_16;
		public ImGuiKeyData KeysData_17;
		public ImGuiKeyData KeysData_18;
		public ImGuiKeyData KeysData_19;
		public ImGuiKeyData KeysData_20;
		public ImGuiKeyData KeysData_21;
		public ImGuiKeyData KeysData_22;
		public ImGuiKeyData KeysData_23;
		public ImGuiKeyData KeysData_24;
		public ImGuiKeyData KeysData_25;
		public ImGuiKeyData KeysData_26;
		public ImGuiKeyData KeysData_27;
		public ImGuiKeyData KeysData_28;
		public ImGuiKeyData KeysData_29;
		public ImGuiKeyData KeysData_30;
		public ImGuiKeyData KeysData_31;
		public ImGuiKeyData KeysData_32;
		public ImGuiKeyData KeysData_33;
		public ImGuiKeyData KeysData_34;
		public ImGuiKeyData KeysData_35;
		public ImGuiKeyData KeysData_36;
		public ImGuiKeyData KeysData_37;
		public ImGuiKeyData KeysData_38;
		public ImGuiKeyData KeysData_39;
		public ImGuiKeyData KeysData_40;
		public ImGuiKeyData KeysData_41;
		public ImGuiKeyData KeysData_42;
		public ImGuiKeyData KeysData_43;
		public ImGuiKeyData KeysData_44;
		public ImGuiKeyData KeysData_45;
		public ImGuiKeyData KeysData_46;
		public ImGuiKeyData KeysData_47;
		public ImGuiKeyData KeysData_48;
		public ImGuiKeyData KeysData_49;
		public ImGuiKeyData KeysData_50;
		public ImGuiKeyData KeysData_51;
		public ImGuiKeyData KeysData_52;
		public ImGuiKeyData KeysData_53;
		public ImGuiKeyData KeysData_54;
		public ImGuiKeyData KeysData_55;
		public ImGuiKeyData KeysData_56;
		public ImGuiKeyData KeysData_57;
		public ImGuiKeyData KeysData_58;
		public ImGuiKeyData KeysData_59;
		public ImGuiKeyData KeysData_60;
		public ImGuiKeyData KeysData_61;
		public ImGuiKeyData KeysData_62;
		public ImGuiKeyData KeysData_63;
		public ImGuiKeyData KeysData_64;
		public ImGuiKeyData KeysData_65;
		public ImGuiKeyData KeysData_66;
		public ImGuiKeyData KeysData_67;
		public ImGuiKeyData KeysData_68;
		public ImGuiKeyData KeysData_69;
		public ImGuiKeyData KeysData_70;
		public ImGuiKeyData KeysData_71;
		public ImGuiKeyData KeysData_72;
		public ImGuiKeyData KeysData_73;
		public ImGuiKeyData KeysData_74;
		public ImGuiKeyData KeysData_75;
		public ImGuiKeyData KeysData_76;
		public ImGuiKeyData KeysData_77;
		public ImGuiKeyData KeysData_78;
		public ImGuiKeyData KeysData_79;
		public ImGuiKeyData KeysData_80;
		public ImGuiKeyData KeysData_81;
		public ImGuiKeyData KeysData_82;
		public ImGuiKeyData KeysData_83;
		public ImGuiKeyData KeysData_84;
		public ImGuiKeyData KeysData_85;
		public ImGuiKeyData KeysData_86;
		public ImGuiKeyData KeysData_87;
		public ImGuiKeyData KeysData_88;
		public ImGuiKeyData KeysData_89;
		public ImGuiKeyData KeysData_90;
		public ImGuiKeyData KeysData_91;
		public ImGuiKeyData KeysData_92;
		public ImGuiKeyData KeysData_93;
		public ImGuiKeyData KeysData_94;
		public ImGuiKeyData KeysData_95;
		public ImGuiKeyData KeysData_96;
		public ImGuiKeyData KeysData_97;
		public ImGuiKeyData KeysData_98;
		public ImGuiKeyData KeysData_99;
		public ImGuiKeyData KeysData_100;
		public ImGuiKeyData KeysData_101;
		public ImGuiKeyData KeysData_102;
		public ImGuiKeyData KeysData_103;
		public ImGuiKeyData KeysData_104;
		public ImGuiKeyData KeysData_105;
		public ImGuiKeyData KeysData_106;
		public ImGuiKeyData KeysData_107;
		public ImGuiKeyData KeysData_108;
		public ImGuiKeyData KeysData_109;
		public ImGuiKeyData KeysData_110;
		public ImGuiKeyData KeysData_111;
		public ImGuiKeyData KeysData_112;
		public ImGuiKeyData KeysData_113;
		public ImGuiKeyData KeysData_114;
		public ImGuiKeyData KeysData_115;
		public ImGuiKeyData KeysData_116;
		public ImGuiKeyData KeysData_117;
		public ImGuiKeyData KeysData_118;
		public ImGuiKeyData KeysData_119;
		public ImGuiKeyData KeysData_120;
		public ImGuiKeyData KeysData_121;
		public ImGuiKeyData KeysData_122;
		public ImGuiKeyData KeysData_123;
		public ImGuiKeyData KeysData_124;
		public ImGuiKeyData KeysData_125;
		public ImGuiKeyData KeysData_126;
		public ImGuiKeyData KeysData_127;
		public ImGuiKeyData KeysData_128;
		public ImGuiKeyData KeysData_129;
		public ImGuiKeyData KeysData_130;
		public ImGuiKeyData KeysData_131;
		public ImGuiKeyData KeysData_132;
		public ImGuiKeyData KeysData_133;
		public ImGuiKeyData KeysData_134;
		public ImGuiKeyData KeysData_135;
		public ImGuiKeyData KeysData_136;
		public ImGuiKeyData KeysData_137;
		public ImGuiKeyData KeysData_138;
		public ImGuiKeyData KeysData_139;
		public ImGuiKeyData KeysData_140;
		public ImGuiKeyData KeysData_141;
		public ImGuiKeyData KeysData_142;
		public ImGuiKeyData KeysData_143;
		public ImGuiKeyData KeysData_144;
		public ImGuiKeyData KeysData_145;
		public ImGuiKeyData KeysData_146;
		public ImGuiKeyData KeysData_147;
		public ImGuiKeyData KeysData_148;
		public ImGuiKeyData KeysData_149;
		public ImGuiKeyData KeysData_150;
		public ImGuiKeyData KeysData_151;
		public ImGuiKeyData KeysData_152;
		public ImGuiKeyData KeysData_153;
		public ImGuiKeyData KeysData_154;
		public ImGuiKeyData KeysData_155;
		public ImGuiKeyData KeysData_156;
		public ImGuiKeyData KeysData_157;
		public ImGuiKeyData KeysData_158;
		public ImGuiKeyData KeysData_159;
		public ImGuiKeyData KeysData_160;
		public ImGuiKeyData KeysData_161;
		public ImGuiKeyData KeysData_162;
		public ImGuiKeyData KeysData_163;
		public ImGuiKeyData KeysData_164;
		public ImGuiKeyData KeysData_165;
		public ImGuiKeyData KeysData_166;
		public ImGuiKeyData KeysData_167;
		public ImGuiKeyData KeysData_168;
		public ImGuiKeyData KeysData_169;
		public ImGuiKeyData KeysData_170;
		public ImGuiKeyData KeysData_171;
		public ImGuiKeyData KeysData_172;
		public ImGuiKeyData KeysData_173;
		public ImGuiKeyData KeysData_174;
		public ImGuiKeyData KeysData_175;
		public ImGuiKeyData KeysData_176;
		public ImGuiKeyData KeysData_177;
		public ImGuiKeyData KeysData_178;
		public ImGuiKeyData KeysData_179;
		public ImGuiKeyData KeysData_180;
		public ImGuiKeyData KeysData_181;
		public ImGuiKeyData KeysData_182;
		public ImGuiKeyData KeysData_183;
		public ImGuiKeyData KeysData_184;
		public ImGuiKeyData KeysData_185;
		public ImGuiKeyData KeysData_186;
		public ImGuiKeyData KeysData_187;
		public ImGuiKeyData KeysData_188;
		public ImGuiKeyData KeysData_189;
		public ImGuiKeyData KeysData_190;
		public ImGuiKeyData KeysData_191;
		public ImGuiKeyData KeysData_192;
		public ImGuiKeyData KeysData_193;
		public ImGuiKeyData KeysData_194;
		public ImGuiKeyData KeysData_195;
		public ImGuiKeyData KeysData_196;
		public ImGuiKeyData KeysData_197;
		public ImGuiKeyData KeysData_198;
		public ImGuiKeyData KeysData_199;
		public ImGuiKeyData KeysData_200;
		public ImGuiKeyData KeysData_201;
		public ImGuiKeyData KeysData_202;
		public ImGuiKeyData KeysData_203;
		public ImGuiKeyData KeysData_204;
		public ImGuiKeyData KeysData_205;
		public ImGuiKeyData KeysData_206;
		public ImGuiKeyData KeysData_207;
		public ImGuiKeyData KeysData_208;
		public ImGuiKeyData KeysData_209;
		public ImGuiKeyData KeysData_210;
		public ImGuiKeyData KeysData_211;
		public ImGuiKeyData KeysData_212;
		public ImGuiKeyData KeysData_213;
		public ImGuiKeyData KeysData_214;
		public ImGuiKeyData KeysData_215;
		public ImGuiKeyData KeysData_216;
		public ImGuiKeyData KeysData_217;
		public ImGuiKeyData KeysData_218;
		public ImGuiKeyData KeysData_219;
		public ImGuiKeyData KeysData_220;
		public ImGuiKeyData KeysData_221;
		public ImGuiKeyData KeysData_222;
		public ImGuiKeyData KeysData_223;
		public ImGuiKeyData KeysData_224;
		public ImGuiKeyData KeysData_225;
		public ImGuiKeyData KeysData_226;
		public ImGuiKeyData KeysData_227;
		public ImGuiKeyData KeysData_228;
		public ImGuiKeyData KeysData_229;
		public ImGuiKeyData KeysData_230;
		public ImGuiKeyData KeysData_231;
		public ImGuiKeyData KeysData_232;
		public ImGuiKeyData KeysData_233;
		public ImGuiKeyData KeysData_234;
		public ImGuiKeyData KeysData_235;
		public ImGuiKeyData KeysData_236;
		public ImGuiKeyData KeysData_237;
		public ImGuiKeyData KeysData_238;
		public ImGuiKeyData KeysData_239;
		public ImGuiKeyData KeysData_240;
		public ImGuiKeyData KeysData_241;
		public ImGuiKeyData KeysData_242;
		public ImGuiKeyData KeysData_243;
		public ImGuiKeyData KeysData_244;
		public ImGuiKeyData KeysData_245;
		public ImGuiKeyData KeysData_246;
		public ImGuiKeyData KeysData_247;
		public ImGuiKeyData KeysData_248;
		public ImGuiKeyData KeysData_249;
		public ImGuiKeyData KeysData_250;
		public ImGuiKeyData KeysData_251;
		public ImGuiKeyData KeysData_252;
		public ImGuiKeyData KeysData_253;
		public ImGuiKeyData KeysData_254;
		public ImGuiKeyData KeysData_255;
		public ImGuiKeyData KeysData_256;
		public ImGuiKeyData KeysData_257;
		public ImGuiKeyData KeysData_258;
		public ImGuiKeyData KeysData_259;
		public ImGuiKeyData KeysData_260;
		public ImGuiKeyData KeysData_261;
		public ImGuiKeyData KeysData_262;
		public ImGuiKeyData KeysData_263;
		public ImGuiKeyData KeysData_264;
		public ImGuiKeyData KeysData_265;
		public ImGuiKeyData KeysData_266;
		public ImGuiKeyData KeysData_267;
		public ImGuiKeyData KeysData_268;
		public ImGuiKeyData KeysData_269;
		public ImGuiKeyData KeysData_270;
		public ImGuiKeyData KeysData_271;
		public ImGuiKeyData KeysData_272;
		public ImGuiKeyData KeysData_273;
		public ImGuiKeyData KeysData_274;
		public ImGuiKeyData KeysData_275;
		public ImGuiKeyData KeysData_276;
		public ImGuiKeyData KeysData_277;
		public ImGuiKeyData KeysData_278;
		public ImGuiKeyData KeysData_279;
		public ImGuiKeyData KeysData_280;
		public ImGuiKeyData KeysData_281;
		public ImGuiKeyData KeysData_282;
		public ImGuiKeyData KeysData_283;
		public ImGuiKeyData KeysData_284;
		public ImGuiKeyData KeysData_285;
		public ImGuiKeyData KeysData_286;
		public ImGuiKeyData KeysData_287;
		public ImGuiKeyData KeysData_288;
		public ImGuiKeyData KeysData_289;
		public ImGuiKeyData KeysData_290;
		public ImGuiKeyData KeysData_291;
		public ImGuiKeyData KeysData_292;
		public ImGuiKeyData KeysData_293;
		public ImGuiKeyData KeysData_294;
		public ImGuiKeyData KeysData_295;
		public ImGuiKeyData KeysData_296;
		public ImGuiKeyData KeysData_297;
		public ImGuiKeyData KeysData_298;
		public ImGuiKeyData KeysData_299;
		public ImGuiKeyData KeysData_300;
		public ImGuiKeyData KeysData_301;
		public ImGuiKeyData KeysData_302;
		public ImGuiKeyData KeysData_303;
		public ImGuiKeyData KeysData_304;
		public ImGuiKeyData KeysData_305;
		public ImGuiKeyData KeysData_306;
		public ImGuiKeyData KeysData_307;
		public ImGuiKeyData KeysData_308;
		public ImGuiKeyData KeysData_309;
		public ImGuiKeyData KeysData_310;
		public ImGuiKeyData KeysData_311;
		public ImGuiKeyData KeysData_312;
		public ImGuiKeyData KeysData_313;
		public ImGuiKeyData KeysData_314;
		public ImGuiKeyData KeysData_315;
		public ImGuiKeyData KeysData_316;
		public ImGuiKeyData KeysData_317;
		public ImGuiKeyData KeysData_318;
		public ImGuiKeyData KeysData_319;
		public ImGuiKeyData KeysData_320;
		public ImGuiKeyData KeysData_321;
		public ImGuiKeyData KeysData_322;
		public ImGuiKeyData KeysData_323;
		public ImGuiKeyData KeysData_324;
		public ImGuiKeyData KeysData_325;
		public ImGuiKeyData KeysData_326;
		public ImGuiKeyData KeysData_327;
		public ImGuiKeyData KeysData_328;
		public ImGuiKeyData KeysData_329;
		public ImGuiKeyData KeysData_330;
		public ImGuiKeyData KeysData_331;
		public ImGuiKeyData KeysData_332;
		public ImGuiKeyData KeysData_333;
		public ImGuiKeyData KeysData_334;
		public ImGuiKeyData KeysData_335;
		public ImGuiKeyData KeysData_336;
		public ImGuiKeyData KeysData_337;
		public ImGuiKeyData KeysData_338;
		public ImGuiKeyData KeysData_339;
		public ImGuiKeyData KeysData_340;
		public ImGuiKeyData KeysData_341;
		public ImGuiKeyData KeysData_342;
		public ImGuiKeyData KeysData_343;
		public ImGuiKeyData KeysData_344;
		public ImGuiKeyData KeysData_345;
		public ImGuiKeyData KeysData_346;
		public ImGuiKeyData KeysData_347;
		public ImGuiKeyData KeysData_348;
		public ImGuiKeyData KeysData_349;
		public ImGuiKeyData KeysData_350;
		public ImGuiKeyData KeysData_351;
		public ImGuiKeyData KeysData_352;
		public ImGuiKeyData KeysData_353;
		public ImGuiKeyData KeysData_354;
		public ImGuiKeyData KeysData_355;
		public ImGuiKeyData KeysData_356;
		public ImGuiKeyData KeysData_357;
		public ImGuiKeyData KeysData_358;
		public ImGuiKeyData KeysData_359;
		public ImGuiKeyData KeysData_360;
		public ImGuiKeyData KeysData_361;
		public ImGuiKeyData KeysData_362;
		public ImGuiKeyData KeysData_363;
		public ImGuiKeyData KeysData_364;
		public ImGuiKeyData KeysData_365;
		public ImGuiKeyData KeysData_366;
		public ImGuiKeyData KeysData_367;
		public ImGuiKeyData KeysData_368;
		public ImGuiKeyData KeysData_369;
		public ImGuiKeyData KeysData_370;
		public ImGuiKeyData KeysData_371;
		public ImGuiKeyData KeysData_372;
		public ImGuiKeyData KeysData_373;
		public ImGuiKeyData KeysData_374;
		public ImGuiKeyData KeysData_375;
		public ImGuiKeyData KeysData_376;
		public ImGuiKeyData KeysData_377;
		public ImGuiKeyData KeysData_378;
		public ImGuiKeyData KeysData_379;
		public ImGuiKeyData KeysData_380;
		public ImGuiKeyData KeysData_381;
		public ImGuiKeyData KeysData_382;
		public ImGuiKeyData KeysData_383;
		public ImGuiKeyData KeysData_384;
		public ImGuiKeyData KeysData_385;
		public ImGuiKeyData KeysData_386;
		public ImGuiKeyData KeysData_387;
		public ImGuiKeyData KeysData_388;
		public ImGuiKeyData KeysData_389;
		public ImGuiKeyData KeysData_390;
		public ImGuiKeyData KeysData_391;
		public ImGuiKeyData KeysData_392;
		public ImGuiKeyData KeysData_393;
		public ImGuiKeyData KeysData_394;
		public ImGuiKeyData KeysData_395;
		public ImGuiKeyData KeysData_396;
		public ImGuiKeyData KeysData_397;
		public ImGuiKeyData KeysData_398;
		public ImGuiKeyData KeysData_399;
		public ImGuiKeyData KeysData_400;
		public ImGuiKeyData KeysData_401;
		public ImGuiKeyData KeysData_402;
		public ImGuiKeyData KeysData_403;
		public ImGuiKeyData KeysData_404;
		public ImGuiKeyData KeysData_405;
		public ImGuiKeyData KeysData_406;
		public ImGuiKeyData KeysData_407;
		public ImGuiKeyData KeysData_408;
		public ImGuiKeyData KeysData_409;
		public ImGuiKeyData KeysData_410;
		public ImGuiKeyData KeysData_411;
		public ImGuiKeyData KeysData_412;
		public ImGuiKeyData KeysData_413;
		public ImGuiKeyData KeysData_414;
		public ImGuiKeyData KeysData_415;
		public ImGuiKeyData KeysData_416;
		public ImGuiKeyData KeysData_417;
		public ImGuiKeyData KeysData_418;
		public ImGuiKeyData KeysData_419;
		public ImGuiKeyData KeysData_420;
		public ImGuiKeyData KeysData_421;
		public ImGuiKeyData KeysData_422;
		public ImGuiKeyData KeysData_423;
		public ImGuiKeyData KeysData_424;
		public ImGuiKeyData KeysData_425;
		public ImGuiKeyData KeysData_426;
		public ImGuiKeyData KeysData_427;
		public ImGuiKeyData KeysData_428;
		public ImGuiKeyData KeysData_429;
		public ImGuiKeyData KeysData_430;
		public ImGuiKeyData KeysData_431;
		public ImGuiKeyData KeysData_432;
		public ImGuiKeyData KeysData_433;
		public ImGuiKeyData KeysData_434;
		public ImGuiKeyData KeysData_435;
		public ImGuiKeyData KeysData_436;
		public ImGuiKeyData KeysData_437;
		public ImGuiKeyData KeysData_438;
		public ImGuiKeyData KeysData_439;
		public ImGuiKeyData KeysData_440;
		public ImGuiKeyData KeysData_441;
		public ImGuiKeyData KeysData_442;
		public ImGuiKeyData KeysData_443;
		public ImGuiKeyData KeysData_444;
		public ImGuiKeyData KeysData_445;
		public ImGuiKeyData KeysData_446;
		public ImGuiKeyData KeysData_447;
		public ImGuiKeyData KeysData_448;
		public ImGuiKeyData KeysData_449;
		public ImGuiKeyData KeysData_450;
		public ImGuiKeyData KeysData_451;
		public ImGuiKeyData KeysData_452;
		public ImGuiKeyData KeysData_453;
		public ImGuiKeyData KeysData_454;
		public ImGuiKeyData KeysData_455;
		public ImGuiKeyData KeysData_456;
		public ImGuiKeyData KeysData_457;
		public ImGuiKeyData KeysData_458;
		public ImGuiKeyData KeysData_459;
		public ImGuiKeyData KeysData_460;
		public ImGuiKeyData KeysData_461;
		public ImGuiKeyData KeysData_462;
		public ImGuiKeyData KeysData_463;
		public ImGuiKeyData KeysData_464;
		public ImGuiKeyData KeysData_465;
		public ImGuiKeyData KeysData_466;
		public ImGuiKeyData KeysData_467;
		public ImGuiKeyData KeysData_468;
		public ImGuiKeyData KeysData_469;
		public ImGuiKeyData KeysData_470;
		public ImGuiKeyData KeysData_471;
		public ImGuiKeyData KeysData_472;
		public ImGuiKeyData KeysData_473;
		public ImGuiKeyData KeysData_474;
		public ImGuiKeyData KeysData_475;
		public ImGuiKeyData KeysData_476;
		public ImGuiKeyData KeysData_477;
		public ImGuiKeyData KeysData_478;
		public ImGuiKeyData KeysData_479;
		public ImGuiKeyData KeysData_480;
		public ImGuiKeyData KeysData_481;
		public ImGuiKeyData KeysData_482;
		public ImGuiKeyData KeysData_483;
		public ImGuiKeyData KeysData_484;
		public ImGuiKeyData KeysData_485;
		public ImGuiKeyData KeysData_486;
		public ImGuiKeyData KeysData_487;
		public ImGuiKeyData KeysData_488;
		public ImGuiKeyData KeysData_489;
		public ImGuiKeyData KeysData_490;
		public ImGuiKeyData KeysData_491;
		public ImGuiKeyData KeysData_492;
		public ImGuiKeyData KeysData_493;
		public ImGuiKeyData KeysData_494;
		public ImGuiKeyData KeysData_495;
		public ImGuiKeyData KeysData_496;
		public ImGuiKeyData KeysData_497;
		public ImGuiKeyData KeysData_498;
		public ImGuiKeyData KeysData_499;
		public ImGuiKeyData KeysData_500;
		public ImGuiKeyData KeysData_501;
		public ImGuiKeyData KeysData_502;
		public ImGuiKeyData KeysData_503;
		public ImGuiKeyData KeysData_504;
		public ImGuiKeyData KeysData_505;
		public ImGuiKeyData KeysData_506;
		public ImGuiKeyData KeysData_507;
		public ImGuiKeyData KeysData_508;
		public ImGuiKeyData KeysData_509;
		public ImGuiKeyData KeysData_510;
		public ImGuiKeyData KeysData_511;
		public ImGuiKeyData KeysData_512;
		public ImGuiKeyData KeysData_513;
		public ImGuiKeyData KeysData_514;
		public ImGuiKeyData KeysData_515;
		public ImGuiKeyData KeysData_516;
		public ImGuiKeyData KeysData_517;
		public ImGuiKeyData KeysData_518;
		public ImGuiKeyData KeysData_519;
		public ImGuiKeyData KeysData_520;
		public ImGuiKeyData KeysData_521;
		public ImGuiKeyData KeysData_522;
		public ImGuiKeyData KeysData_523;
		public ImGuiKeyData KeysData_524;
		public ImGuiKeyData KeysData_525;
		public ImGuiKeyData KeysData_526;
		public ImGuiKeyData KeysData_527;
		public ImGuiKeyData KeysData_528;
		public ImGuiKeyData KeysData_529;
		public ImGuiKeyData KeysData_530;
		public ImGuiKeyData KeysData_531;
		public ImGuiKeyData KeysData_532;
		public ImGuiKeyData KeysData_533;
		public ImGuiKeyData KeysData_534;
		public ImGuiKeyData KeysData_535;
		public ImGuiKeyData KeysData_536;
		public ImGuiKeyData KeysData_537;
		public ImGuiKeyData KeysData_538;
		public ImGuiKeyData KeysData_539;
		public ImGuiKeyData KeysData_540;
		public ImGuiKeyData KeysData_541;
		public ImGuiKeyData KeysData_542;
		public ImGuiKeyData KeysData_543;
		public ImGuiKeyData KeysData_544;
		public ImGuiKeyData KeysData_545;
		public ImGuiKeyData KeysData_546;
		public ImGuiKeyData KeysData_547;
		public ImGuiKeyData KeysData_548;
		public ImGuiKeyData KeysData_549;
		public ImGuiKeyData KeysData_550;
		public ImGuiKeyData KeysData_551;
		public ImGuiKeyData KeysData_552;
		public ImGuiKeyData KeysData_553;
		public ImGuiKeyData KeysData_554;
		public ImGuiKeyData KeysData_555;
		public ImGuiKeyData KeysData_556;
		public ImGuiKeyData KeysData_557;
		public ImGuiKeyData KeysData_558;
		public ImGuiKeyData KeysData_559;
		public ImGuiKeyData KeysData_560;
		public ImGuiKeyData KeysData_561;
		public ImGuiKeyData KeysData_562;
		public ImGuiKeyData KeysData_563;
		public ImGuiKeyData KeysData_564;
		public ImGuiKeyData KeysData_565;
		public ImGuiKeyData KeysData_566;
		public ImGuiKeyData KeysData_567;
		public ImGuiKeyData KeysData_568;
		public ImGuiKeyData KeysData_569;
		public ImGuiKeyData KeysData_570;
		public ImGuiKeyData KeysData_571;
		public ImGuiKeyData KeysData_572;
		public ImGuiKeyData KeysData_573;
		public ImGuiKeyData KeysData_574;
		public ImGuiKeyData KeysData_575;
		public ImGuiKeyData KeysData_576;
		public ImGuiKeyData KeysData_577;
		public ImGuiKeyData KeysData_578;
		public ImGuiKeyData KeysData_579;
		public ImGuiKeyData KeysData_580;
		public ImGuiKeyData KeysData_581;
		public ImGuiKeyData KeysData_582;
		public ImGuiKeyData KeysData_583;
		public ImGuiKeyData KeysData_584;
		public ImGuiKeyData KeysData_585;
		public ImGuiKeyData KeysData_586;
		public ImGuiKeyData KeysData_587;
		public ImGuiKeyData KeysData_588;
		public ImGuiKeyData KeysData_589;
		public ImGuiKeyData KeysData_590;
		public ImGuiKeyData KeysData_591;
		public ImGuiKeyData KeysData_592;
		public ImGuiKeyData KeysData_593;
		public ImGuiKeyData KeysData_594;
		public ImGuiKeyData KeysData_595;
		public ImGuiKeyData KeysData_596;
		public ImGuiKeyData KeysData_597;
		public ImGuiKeyData KeysData_598;
		public ImGuiKeyData KeysData_599;
		public ImGuiKeyData KeysData_600;
		public ImGuiKeyData KeysData_601;
		public ImGuiKeyData KeysData_602;
		public ImGuiKeyData KeysData_603;
		public ImGuiKeyData KeysData_604;
		public ImGuiKeyData KeysData_605;
		public ImGuiKeyData KeysData_606;
		public ImGuiKeyData KeysData_607;
		public ImGuiKeyData KeysData_608;
		public ImGuiKeyData KeysData_609;
		public ImGuiKeyData KeysData_610;
		public ImGuiKeyData KeysData_611;
		public ImGuiKeyData KeysData_612;
		public ImGuiKeyData KeysData_613;
		public ImGuiKeyData KeysData_614;
		public ImGuiKeyData KeysData_615;
		public ImGuiKeyData KeysData_616;
		public ImGuiKeyData KeysData_617;
		public ImGuiKeyData KeysData_618;
		public ImGuiKeyData KeysData_619;
		public ImGuiKeyData KeysData_620;
		public ImGuiKeyData KeysData_621;
		public ImGuiKeyData KeysData_622;
		public ImGuiKeyData KeysData_623;
		public ImGuiKeyData KeysData_624;
		public ImGuiKeyData KeysData_625;
		public ImGuiKeyData KeysData_626;
		public ImGuiKeyData KeysData_627;
		public ImGuiKeyData KeysData_628;
		public ImGuiKeyData KeysData_629;
		public ImGuiKeyData KeysData_630;
		public ImGuiKeyData KeysData_631;
		public ImGuiKeyData KeysData_632;
		public ImGuiKeyData KeysData_633;
		public ImGuiKeyData KeysData_634;
		public ImGuiKeyData KeysData_635;
		public ImGuiKeyData KeysData_636;
		public ImGuiKeyData KeysData_637;
		public ImGuiKeyData KeysData_638;
		public ImGuiKeyData KeysData_639;
		public ImGuiKeyData KeysData_640;
		public ImGuiKeyData KeysData_641;
		public ImGuiKeyData KeysData_642;
		public ImGuiKeyData KeysData_643;
		public ImGuiKeyData KeysData_644;
		public byte WantCaptureMouseUnlessPopupClose;
		public Vector2 MousePosPrev;
		public Vector2 MouseClickedPos_0;
		public Vector2 MouseClickedPos_1;
		public Vector2 MouseClickedPos_2;
		public Vector2 MouseClickedPos_3;
		public Vector2 MouseClickedPos_4;
		public fixed double MouseClickedTime[5];
		public fixed byte MouseClicked[5];
		public fixed byte MouseDoubleClicked[5];
		public fixed ushort MouseClickedCount[5];
		public fixed ushort MouseClickedLastCount[5];
		public fixed byte MouseReleased[5];
		public fixed byte MouseDownOwned[5];
		public fixed byte MouseDownOwnedUnlessPopupClose[5];
		public fixed float MouseDownDuration[5];
		public fixed float MouseDownDurationPrev[5];
		public Vector2 MouseDragMaxDistanceAbs_0;
		public Vector2 MouseDragMaxDistanceAbs_1;
		public Vector2 MouseDragMaxDistanceAbs_2;
		public Vector2 MouseDragMaxDistanceAbs_3;
		public Vector2 MouseDragMaxDistanceAbs_4;
		public fixed float MouseDragMaxDistanceSqr[5];
		public fixed float NavInputsDownDuration[20];
		public fixed float NavInputsDownDurationPrev[20];
		public float PenPressure;
		public byte AppFocusLost;
		public byte AppAcceptingEvents;
		public sbyte BackendUsingLegacyKeyArrays;
		public byte BackendUsingLegacyNavInputArray;
		public ushort InputQueueSurrogate;
		public ImVector InputQueueCharacters;

		public void AddFocusEvent([MarshalAs(UnmanagedType.Bool)] bool focused)
		{
			ImguiNative.ImGuiIO_AddFocusEvent(self, focused);
		}

		public void AddInputCharacter(uint c)
		{
			ImguiNative.ImGuiIO_AddInputCharacter(self, c);
		}

		public void AddInputCharacterUTF16(ushort c)
		{
			ImguiNative.ImGuiIO_AddInputCharacterUTF16(self, c);
		}

		public void AddInputCharactersUTF8([MarshalAs(UnmanagedType.LPStr)] string str)
		{
			ImguiNative.ImGuiIO_AddInputCharactersUTF8(self, str);
		}

		public void AddKeyAnalogEvent(ImGuiKey key, [MarshalAs(UnmanagedType.Bool)] bool down, float v)
		{
			ImguiNative.ImGuiIO_AddKeyAnalogEvent(self, key, down, v);
		}

		public void AddKeyEvent(ImGuiKey key, [MarshalAs(UnmanagedType.Bool)] bool down)
		{
			ImguiNative.ImGuiIO_AddKeyEvent(self, key, down);
		}

		public void AddMouseButtonEvent(int button, [MarshalAs(UnmanagedType.Bool)] bool down)
		{
			ImguiNative.ImGuiIO_AddMouseButtonEvent(self, button, down);
		}

		public void AddMousePosEvent(float x, float y)
		{
			ImguiNative.ImGuiIO_AddMousePosEvent(self, x, y);
		}

		public void AddMouseViewportEvent(uint id)
		{
			ImguiNative.ImGuiIO_AddMouseViewportEvent(self, id);
		}

		public void AddMouseWheelEvent(float wh_x, float wh_y)
		{
			ImguiNative.ImGuiIO_AddMouseWheelEvent(self, wh_x, wh_y);
		}

		public void ClearInputCharacters()
		{
			ImguiNative.ImGuiIO_ClearInputCharacters(self);
		}

		public void ClearInputKeys()
		{
			ImguiNative.ImGuiIO_ClearInputKeys(self);
		}

		public void SetAppAcceptingEvents([MarshalAs(UnmanagedType.Bool)] bool accepting_events)
		{
			ImguiNative.ImGuiIO_SetAppAcceptingEvents(self, accepting_events);
		}

		public void SetKeyEventNativeData(ImGuiKey key, int native_keycode, int native_scancode, int native_legacy_index = -1)
		{
			ImguiNative.ImGuiIO_SetKeyEventNativeData(self, key, native_keycode, native_scancode, native_legacy_index);
		}

		public ImGuiIO* self => (ImGuiIO*)Unsafe.AsPointer(ref this);

	}

	public unsafe partial struct ImGuiInputTextCallbackData
	{
		public ImGuiInputTextFlags EventFlag;
		public ImGuiInputTextFlags Flags;
		public void* UserData;
		public ushort EventChar;
		public ImGuiKey EventKey;
		public byte* Buf;
		public int BufTextLen;
		public int BufSize;
		public byte BufDirty;
		public int CursorPos;
		public int SelectionStart;
		public int SelectionEnd;

		public void ClearSelection()
		{
			ImguiNative.ImGuiInputTextCallbackData_ClearSelection(self);
		}

		public void DeleteChars(int pos, int bytes_count)
		{
			ImguiNative.ImGuiInputTextCallbackData_DeleteChars(self, pos, bytes_count);
		}

		public bool HasSelection()
		{
			return ImguiNative.ImGuiInputTextCallbackData_HasSelection(self);
		}

		public void InsertChars(int pos, [MarshalAs(UnmanagedType.LPStr)] string text, [MarshalAs(UnmanagedType.LPStr)] string text_end = null)
		{
			ImguiNative.ImGuiInputTextCallbackData_InsertChars(self, pos, text, text_end);
		}

		public void SelectAll()
		{
			ImguiNative.ImGuiInputTextCallbackData_SelectAll(self);
		}

		public ImGuiInputTextCallbackData* self => (ImGuiInputTextCallbackData*)Unsafe.AsPointer(ref this);

	}

	public unsafe partial struct ImGuiKeyData
	{
		public byte Down;
		public float DownDuration;
		public float DownDurationPrev;
		public float AnalogValue;
	}

	public unsafe partial struct ImGuiListClipper
	{
		public int DisplayStart;
		public int DisplayEnd;
		public int ItemsCount;
		public float ItemsHeight;
		public float StartPosY;
		public void* TempData;

		public void Begin(int items_count, float items_height = -1.0f)
		{
			ImguiNative.ImGuiListClipper_Begin(self, items_count, items_height);
		}

		public void End()
		{
			ImguiNative.ImGuiListClipper_End(self);
		}

		public void ForceDisplayRangeByIndices(int item_min, int item_max)
		{
			ImguiNative.ImGuiListClipper_ForceDisplayRangeByIndices(self, item_min, item_max);
		}

		public bool Step()
		{
			return ImguiNative.ImGuiListClipper_Step(self);
		}

		public ImGuiListClipper* self => (ImGuiListClipper*)Unsafe.AsPointer(ref this);

	}

	public unsafe partial struct ImGuiOnceUponAFrame
	{
		public int RefFrame;
	}

	public unsafe partial struct ImGuiPayload
	{
		public void* Data;
		public int DataSize;
		public uint SourceId;
		public uint SourceParentId;
		public int DataFrameCount;
		public fixed byte DataType[33];
		public byte Preview;
		public byte Delivery;

		public void Clear()
		{
			ImguiNative.ImGuiPayload_Clear(self);
		}

		public bool IsDataType([MarshalAs(UnmanagedType.LPStr)] string type)
		{
			return ImguiNative.ImGuiPayload_IsDataType(self, type);
		}

		public bool IsDelivery()
		{
			return ImguiNative.ImGuiPayload_IsDelivery(self);
		}

		public bool IsPreview()
		{
			return ImguiNative.ImGuiPayload_IsPreview(self);
		}

		public ImGuiPayload* self => (ImGuiPayload*)Unsafe.AsPointer(ref this);

	}

	public unsafe partial struct ImGuiPlatformIO
	{
		public InlineDelegate0 Platform_CreateWindow;
		public InlineDelegate0 Platform_DestroyWindow;
		public InlineDelegate0 Platform_ShowWindow;
		public InlineDelegate1 Platform_SetWindowPos;
		public InlineDelegate2 Platform_GetWindowPos;
		public InlineDelegate3 Platform_SetWindowSize;
		public InlineDelegate2 Platform_GetWindowSize;
		public InlineDelegate0 Platform_SetWindowFocus;
		public InlineDelegate4 Platform_GetWindowFocus;
		public InlineDelegate4 Platform_GetWindowMinimized;
		public InlineDelegate5 Platform_SetWindowTitle;
		public InlineDelegate6 Platform_SetWindowAlpha;
		public InlineDelegate0 Platform_UpdateWindow;
		public InlineDelegate7 Platform_RenderWindow;
		public InlineDelegate7 Platform_SwapBuffers;
		public InlineDelegate8 Platform_GetWindowDpiScale;
		public InlineDelegate0 Platform_OnChangedViewport;
		public InlineDelegate9 Platform_CreateVkSurface;
		public InlineDelegate0 Renderer_CreateWindow;
		public InlineDelegate0 Renderer_DestroyWindow;
		public InlineDelegate3 Renderer_SetWindowSize;
		public InlineDelegate7 Renderer_RenderWindow;
		public InlineDelegate7 Renderer_SwapBuffers;
		public ImVector Monitors;
		public ImVector Viewports;
	}

	public unsafe partial struct ImGuiPlatformImeData
	{
		public byte WantVisible;
		public Vector2 InputPos;
		public float InputLineHeight;
	}

	public unsafe partial struct ImGuiPlatformMonitor
	{
		public Vector2 MainPos;
		public Vector2 MainSize;
		public Vector2 WorkPos;
		public Vector2 WorkSize;
		public float DpiScale;
	}

	public unsafe partial struct ImGuiSizeCallbackData
	{
		public void* UserData;
		public Vector2 Pos;
		public Vector2 CurrentSize;
		public Vector2 DesiredSize;
	}

	public unsafe partial struct ImGuiStorage
	{
		public ImVector Data;

		public void BuildSortByKey()
		{
			ImguiNative.ImGuiStorage_BuildSortByKey(self);
		}

		public void Clear()
		{
			ImguiNative.ImGuiStorage_Clear(self);
		}

		public bool GetBool(uint key, [MarshalAs(UnmanagedType.Bool)] bool default_val = true)
		{
			return ImguiNative.ImGuiStorage_GetBool(self, key, default_val);
		}

		public bool GetBoolRef(uint key, [MarshalAs(UnmanagedType.Bool)] bool default_val = true)
		{
			return ImguiNative.ImGuiStorage_GetBoolRef(self, key, default_val);
		}

		public float GetFloat(uint key, float default_val = 0.0f)
		{
			return ImguiNative.ImGuiStorage_GetFloat(self, key, default_val);
		}

		public float* GetFloatRef(uint key, float default_val = 0.0f)
		{
			return ImguiNative.ImGuiStorage_GetFloatRef(self, key, default_val);
		}

		public int GetInt(uint key, int default_val = 0)
		{
			return ImguiNative.ImGuiStorage_GetInt(self, key, default_val);
		}

		public int* GetIntRef(uint key, int default_val = 0)
		{
			return ImguiNative.ImGuiStorage_GetIntRef(self, key, default_val);
		}

		public void* GetVoidPtr(uint key)
		{
			return ImguiNative.ImGuiStorage_GetVoidPtr(self, key);
		}

		public void** GetVoidPtrRef(uint key, void* default_val = null)
		{
			return ImguiNative.ImGuiStorage_GetVoidPtrRef(self, key, default_val);
		}

		public void SetAllInt(int val)
		{
			ImguiNative.ImGuiStorage_SetAllInt(self, val);
		}

		public void SetBool(uint key, [MarshalAs(UnmanagedType.Bool)] bool val)
		{
			ImguiNative.ImGuiStorage_SetBool(self, key, val);
		}

		public void SetFloat(uint key, float val)
		{
			ImguiNative.ImGuiStorage_SetFloat(self, key, val);
		}

		public void SetInt(uint key, int val)
		{
			ImguiNative.ImGuiStorage_SetInt(self, key, val);
		}

		public void SetVoidPtr(uint key, void* val)
		{
			ImguiNative.ImGuiStorage_SetVoidPtr(self, key, val);
		}

		public ImGuiStorage* self => (ImGuiStorage*)Unsafe.AsPointer(ref this);

	}

	public unsafe partial struct ImGuiStyle
	{
		public float Alpha;
		public float DisabledAlpha;
		public Vector2 WindowPadding;
		public float WindowRounding;
		public float WindowBorderSize;
		public Vector2 WindowMinSize;
		public Vector2 WindowTitleAlign;
		public ImGuiDir WindowMenuButtonPosition;
		public float ChildRounding;
		public float ChildBorderSize;
		public float PopupRounding;
		public float PopupBorderSize;
		public Vector2 FramePadding;
		public float FrameRounding;
		public float FrameBorderSize;
		public Vector2 ItemSpacing;
		public Vector2 ItemInnerSpacing;
		public Vector2 CellPadding;
		public Vector2 TouchExtraPadding;
		public float IndentSpacing;
		public float ColumnsMinSpacing;
		public float ScrollbarSize;
		public float ScrollbarRounding;
		public float GrabMinSize;
		public float GrabRounding;
		public float LogSliderDeadzone;
		public float TabRounding;
		public float TabBorderSize;
		public float TabMinWidthForCloseButton;
		public ImGuiDir ColorButtonPosition;
		public Vector2 ButtonTextAlign;
		public Vector2 SelectableTextAlign;
		public Vector2 DisplayWindowPadding;
		public Vector2 DisplaySafeAreaPadding;
		public float MouseCursorScale;
		public byte AntiAliasedLines;
		public byte AntiAliasedLinesUseTex;
		public byte AntiAliasedFill;
		public float CurveTessellationTol;
		public float CircleTessellationMaxError;
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
		public Vector4 Colors_21;
		public Vector4 Colors_22;
		public Vector4 Colors_23;
		public Vector4 Colors_24;
		public Vector4 Colors_25;
		public Vector4 Colors_26;
		public Vector4 Colors_27;
		public Vector4 Colors_28;
		public Vector4 Colors_29;
		public Vector4 Colors_30;
		public Vector4 Colors_31;
		public Vector4 Colors_32;
		public Vector4 Colors_33;
		public Vector4 Colors_34;
		public Vector4 Colors_35;
		public Vector4 Colors_36;
		public Vector4 Colors_37;
		public Vector4 Colors_38;
		public Vector4 Colors_39;
		public Vector4 Colors_40;
		public Vector4 Colors_41;
		public Vector4 Colors_42;
		public Vector4 Colors_43;
		public Vector4 Colors_44;
		public Vector4 Colors_45;
		public Vector4 Colors_46;
		public Vector4 Colors_47;
		public Vector4 Colors_48;
		public Vector4 Colors_49;
		public Vector4 Colors_50;
		public Vector4 Colors_51;
		public Vector4 Colors_52;
		public Vector4 Colors_53;
		public Vector4 Colors_54;

		public void ScaleAllSizes(float scale_factor)
		{
			ImguiNative.ImGuiStyle_ScaleAllSizes(self, scale_factor);
		}

		public ImGuiStyle* self => (ImGuiStyle*)Unsafe.AsPointer(ref this);

	}

	public unsafe partial struct ImGuiTableColumnSortSpecs
	{
		public uint ColumnUserID;
		public short ColumnIndex;
		public short SortOrder;
		public ImGuiSortDirection SortDirection;
	}

	public unsafe partial struct ImGuiTableSortSpecs
	{
		public ImGuiTableColumnSortSpecs* Specs;
		public int SpecsCount;
		public byte SpecsDirty;
	}

	public unsafe partial struct ImGuiTextBuffer
	{
		public ImVector Buf;

		public void append([MarshalAs(UnmanagedType.LPStr)] string str, [MarshalAs(UnmanagedType.LPStr)] string str_end = null)
		{
			ImguiNative.ImGuiTextBuffer_append(self, str, str_end);
		}

		public void appendf([MarshalAs(UnmanagedType.LPStr)] string fmt)
		{
			ImguiNative.ImGuiTextBuffer_appendf(self, fmt);
		}

		public string begin()
		{
			return ImguiNative.ImGuiTextBuffer_begin(self);
		}

		public string c_str()
		{
			return ImguiNative.ImGuiTextBuffer_c_str(self);
		}

		public void clear()
		{
			ImguiNative.ImGuiTextBuffer_clear(self);
		}

		public bool empty()
		{
			return ImguiNative.ImGuiTextBuffer_empty(self);
		}

		public string end()
		{
			return ImguiNative.ImGuiTextBuffer_end(self);
		}

		public void reserve(int capacity)
		{
			ImguiNative.ImGuiTextBuffer_reserve(self, capacity);
		}

		public int size()
		{
			return ImguiNative.ImGuiTextBuffer_size(self);
		}

		public ImGuiTextBuffer* self => (ImGuiTextBuffer*)Unsafe.AsPointer(ref this);

	}

	public unsafe partial struct ImGuiTextFilter
	{
		public fixed byte InputBuf[256];
		public ImVector Filters;
		public int CountGrep;

		public void Build()
		{
			ImguiNative.ImGuiTextFilter_Build(self);
		}

		public void Clear()
		{
			ImguiNative.ImGuiTextFilter_Clear(self);
		}

		public bool Draw([MarshalAs(UnmanagedType.LPStr)] string label = "Filter(inc,-exc)", float width = 0.0f)
		{
			return ImguiNative.ImGuiTextFilter_Draw(self, label, width);
		}

		public bool IsActive()
		{
			return ImguiNative.ImGuiTextFilter_IsActive(self);
		}

		public bool PassFilter([MarshalAs(UnmanagedType.LPStr)] string text, [MarshalAs(UnmanagedType.LPStr)] string text_end = null)
		{
			return ImguiNative.ImGuiTextFilter_PassFilter(self, text, text_end);
		}

		public ImGuiTextFilter* self => (ImGuiTextFilter*)Unsafe.AsPointer(ref this);

	}

	public unsafe partial struct ImGuiTextRange
	{
		public byte* b;
		public byte* e;

		public bool empty()
		{
			return ImguiNative.ImGuiTextRange_empty(self);
		}

		public void split(byte separator, ImVector* @out)
		{
			ImguiNative.ImGuiTextRange_split(self, separator, @out);
		}

		public ImGuiTextRange* self => (ImGuiTextRange*)Unsafe.AsPointer(ref this);

	}

	public unsafe partial struct ImGuiViewport
	{
		public uint ID;
		public ImGuiViewportFlags Flags;
		public Vector2 Pos;
		public Vector2 Size;
		public Vector2 WorkPos;
		public Vector2 WorkSize;
		public float DpiScale;
		public uint ParentViewportId;
		public ImDrawData* DrawData;
		public void* RendererUserData;
		public void* PlatformUserData;
		public void* PlatformHandle;
		public void* PlatformHandleRaw;
		public byte PlatformRequestMove;
		public byte PlatformRequestResize;
		public byte PlatformRequestClose;

		public Vector2 GetCenter()
		{
			Vector2 pOut;
			ImguiNative.ImGuiViewport_GetCenter(&pOut, self);

			return pOut;
		}

		public Vector2 GetWorkCenter()
		{
			Vector2 pOut;
			ImguiNative.ImGuiViewport_GetWorkCenter(&pOut, self);

			return pOut;
		}

		public ImGuiViewport* self => (ImGuiViewport*)Unsafe.AsPointer(ref this);

	}

	public unsafe partial struct ImGuiWindowClass
	{
		public uint ClassId;
		public uint ParentViewportId;
		public ImGuiViewportFlags ViewportFlagsOverrideSet;
		public ImGuiViewportFlags ViewportFlagsOverrideClear;
		public ImGuiTabItemFlags TabItemFlagsOverrideSet;
		public ImGuiDockNodeFlags DockNodeFlagsOverrideSet;
		public byte DockingAlwaysTabBar;
		public byte DockingAllowUnclassed;
	}

	public unsafe partial struct ImVec2
	{
		public float x;
		public float y;
	}

	public unsafe partial struct ImVec4
	{
		public float x;
		public float y;
		public float z;
		public float w;
	}

	public unsafe partial struct STB_TexteditState
	{
		public int cursor;
		public int select_start;
		public int select_end;
		public byte insert_mode;
		public int row_count_per_page;
		public byte cursor_at_end_of_line;
		public byte initialized;
		public byte has_preferred_x;
		public byte single_line;
		public byte padding1;
		public byte padding2;
		public byte padding3;
		public float preferred_x;
		public StbUndoState undostate;
	}

	public unsafe partial struct StbTexteditRow
	{
		public float x0;
		public float x1;
		public float baseline_y_delta;
		public float ymin;
		public float ymax;
		public int num_chars;
	}

	public unsafe partial struct StbUndoRecord
	{
		public int where;
		public int insert_length;
		public int delete_length;
		public int char_storage;
	}

	public unsafe partial struct StbUndoState
	{
		public StbUndoRecord undo_rec_0;
		public StbUndoRecord undo_rec_1;
		public StbUndoRecord undo_rec_2;
		public StbUndoRecord undo_rec_3;
		public StbUndoRecord undo_rec_4;
		public StbUndoRecord undo_rec_5;
		public StbUndoRecord undo_rec_6;
		public StbUndoRecord undo_rec_7;
		public StbUndoRecord undo_rec_8;
		public StbUndoRecord undo_rec_9;
		public StbUndoRecord undo_rec_10;
		public StbUndoRecord undo_rec_11;
		public StbUndoRecord undo_rec_12;
		public StbUndoRecord undo_rec_13;
		public StbUndoRecord undo_rec_14;
		public StbUndoRecord undo_rec_15;
		public StbUndoRecord undo_rec_16;
		public StbUndoRecord undo_rec_17;
		public StbUndoRecord undo_rec_18;
		public StbUndoRecord undo_rec_19;
		public StbUndoRecord undo_rec_20;
		public StbUndoRecord undo_rec_21;
		public StbUndoRecord undo_rec_22;
		public StbUndoRecord undo_rec_23;
		public StbUndoRecord undo_rec_24;
		public StbUndoRecord undo_rec_25;
		public StbUndoRecord undo_rec_26;
		public StbUndoRecord undo_rec_27;
		public StbUndoRecord undo_rec_28;
		public StbUndoRecord undo_rec_29;
		public StbUndoRecord undo_rec_30;
		public StbUndoRecord undo_rec_31;
		public StbUndoRecord undo_rec_32;
		public StbUndoRecord undo_rec_33;
		public StbUndoRecord undo_rec_34;
		public StbUndoRecord undo_rec_35;
		public StbUndoRecord undo_rec_36;
		public StbUndoRecord undo_rec_37;
		public StbUndoRecord undo_rec_38;
		public StbUndoRecord undo_rec_39;
		public StbUndoRecord undo_rec_40;
		public StbUndoRecord undo_rec_41;
		public StbUndoRecord undo_rec_42;
		public StbUndoRecord undo_rec_43;
		public StbUndoRecord undo_rec_44;
		public StbUndoRecord undo_rec_45;
		public StbUndoRecord undo_rec_46;
		public StbUndoRecord undo_rec_47;
		public StbUndoRecord undo_rec_48;
		public StbUndoRecord undo_rec_49;
		public StbUndoRecord undo_rec_50;
		public StbUndoRecord undo_rec_51;
		public StbUndoRecord undo_rec_52;
		public StbUndoRecord undo_rec_53;
		public StbUndoRecord undo_rec_54;
		public StbUndoRecord undo_rec_55;
		public StbUndoRecord undo_rec_56;
		public StbUndoRecord undo_rec_57;
		public StbUndoRecord undo_rec_58;
		public StbUndoRecord undo_rec_59;
		public StbUndoRecord undo_rec_60;
		public StbUndoRecord undo_rec_61;
		public StbUndoRecord undo_rec_62;
		public StbUndoRecord undo_rec_63;
		public StbUndoRecord undo_rec_64;
		public StbUndoRecord undo_rec_65;
		public StbUndoRecord undo_rec_66;
		public StbUndoRecord undo_rec_67;
		public StbUndoRecord undo_rec_68;
		public StbUndoRecord undo_rec_69;
		public StbUndoRecord undo_rec_70;
		public StbUndoRecord undo_rec_71;
		public StbUndoRecord undo_rec_72;
		public StbUndoRecord undo_rec_73;
		public StbUndoRecord undo_rec_74;
		public StbUndoRecord undo_rec_75;
		public StbUndoRecord undo_rec_76;
		public StbUndoRecord undo_rec_77;
		public StbUndoRecord undo_rec_78;
		public StbUndoRecord undo_rec_79;
		public StbUndoRecord undo_rec_80;
		public StbUndoRecord undo_rec_81;
		public StbUndoRecord undo_rec_82;
		public StbUndoRecord undo_rec_83;
		public StbUndoRecord undo_rec_84;
		public StbUndoRecord undo_rec_85;
		public StbUndoRecord undo_rec_86;
		public StbUndoRecord undo_rec_87;
		public StbUndoRecord undo_rec_88;
		public StbUndoRecord undo_rec_89;
		public StbUndoRecord undo_rec_90;
		public StbUndoRecord undo_rec_91;
		public StbUndoRecord undo_rec_92;
		public StbUndoRecord undo_rec_93;
		public StbUndoRecord undo_rec_94;
		public StbUndoRecord undo_rec_95;
		public StbUndoRecord undo_rec_96;
		public StbUndoRecord undo_rec_97;
		public StbUndoRecord undo_rec_98;
		public fixed ushort undo_char[999];
		public short undo_point;
		public short redo_point;
		public int undo_char_point;
		public int redo_char_point;
	}

}

