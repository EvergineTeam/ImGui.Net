using Evergine.Mathematics;
using System;
using System.Runtime.InteropServices;

namespace Evergine.Bindings.Imgui
{
	public unsafe partial struct ImColor
	{
		public Vector4 Value;
	}

	public unsafe partial struct ImDrawChannel
	{
		public ImVector_ImDrawCmd _CmdBuffer;
		public ImVector_ImDrawIdx _IdxBuffer;
	}

	public unsafe partial struct ImDrawCmd
	{
		public Vector4 ClipRect;
		public ImTextureID TextureId;
		public uint VtxOffset;
		public uint IdxOffset;
		public uint ElemCount;
		public ImDrawCallback UserCallback;
		public void* UserCallbackData;
	}

	public unsafe partial struct ImDrawCmdHeader
	{
		public Vector4 ClipRect;
		public ImTextureID TextureId;
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
	}

	public unsafe partial struct ImDrawList
	{
		public ImVector_ImDrawCmd CmdBuffer;
		public ImVector_ImDrawIdx IdxBuffer;
		public ImVector_ImDrawVert VtxBuffer;
		public ImDrawListFlags Flags;
		public uint _VtxCurrentIdx;
		public ImDrawListSharedData* _Data;
		public byte* _OwnerName;
		public ImDrawVert* _VtxWritePtr;
		public ImDrawIdx* _IdxWritePtr;
		public ImVector_ImVec4 _ClipRectStack;
		public ImVector_ImTextureID _TextureIdStack;
		public ImVector_ImVec2 _Path;
		public ImDrawCmdHeader _CmdHeader;
		public ImDrawListSplitter _Splitter;
		public float _FringeScale;
	}

	public unsafe partial struct ImDrawListSplitter
	{
		public int _Current;
		public int _Count;
		public ImVector_ImDrawChannel _Channels;
	}

	public unsafe partial struct ImDrawVert
	{
		public Vector2 pos;
		public Vector2 uv;
		public uint col;
	}

	public unsafe partial struct ImFont
	{
		public ImVector_float IndexAdvanceX;
		public float FallbackAdvanceX;
		public float FontSize;
		public ImVector_ImWchar IndexLookup;
		public ImVector_ImFontGlyph Glyphs;
		public ImFontGlyph* FallbackGlyph;
		public ImFontAtlas* ContainerAtlas;
		public ImFontConfig* ConfigData;
		public short ConfigDataCount;
		public ImWchar FallbackChar;
		public ImWchar EllipsisChar;
		public ImWchar DotChar;
		public byte DirtyLookupTables;
		public float Scale;
		public float Ascent;
		public float Descent;
		public int MetricsTotalSurface;
		public byte Used4kPagesMap[(0xFFFF+1)/4096/8];
	}

	public unsafe partial struct ImFontAtlas
	{
		public ImFontAtlasFlags Flags;
		public ImTextureID TexID;
		public int TexDesiredWidth;
		public int TexGlyphPadding;
		public byte Locked;
		public byte TexReady;
		public byte TexPixelsUseColors;
		public unsigned char* TexPixelsAlpha8;
		public uint* TexPixelsRGBA32;
		public int TexWidth;
		public int TexHeight;
		public Vector2 TexUvScale;
		public Vector2 TexUvWhitePixel;
		public ImVector_ImFontPtr Fonts;
		public ImVector_ImFontAtlasCustomRect CustomRects;
		public ImVector_ImFontConfig ConfigData;
		public Vector4 TexUvLines[(63)+1];
		public ImFontBuilderIO* FontBuilderIO;
		public uint FontBuilderFlags;
		public int PackIdMouseCursors;
		public int PackIdLines;
	}

	public unsafe partial struct ImFontAtlasCustomRect
	{
		public unsigned short Width;
		public unsigned short Height;
		public unsigned short X;
		public unsigned short Y;
		public uint GlyphID;
		public float GlyphAdvanceX;
		public Vector2 GlyphOffset;
		public ImFont* Font;
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
		public ImWchar* GlyphRanges;
		public float GlyphMinAdvanceX;
		public float GlyphMaxAdvanceX;
		public byte MergeMode;
		public uint FontBuilderFlags;
		public float RasterizerMultiply;
		public ImWchar EllipsisChar;
		public byte Name[40];
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
		public ImVector_ImU32 UsedChars;
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
		public char*(*)(void* user_data) GetClipboardTextFn;
		public void(*)(void* user_data,char* text) SetClipboardTextFn;
		public void* ClipboardUserData;
		public void(*)(ImGuiViewport* viewport,ImGuiPlatformImeData* data) SetPlatformImeDataFn;
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
		public int KeyMap[ImGuiKey_COUNT];
		public byte KeysDown[512];
		public Vector2 MousePos;
		public byte MouseDown[5];
		public float MouseWheel;
		public float MouseWheelH;
		public byte KeyCtrl;
		public byte KeyShift;
		public byte KeyAlt;
		public byte KeySuper;
		public float NavInputs[ImGuiNavInput_COUNT];
		public ImGuiKeyModFlags KeyMods;
		public ImGuiKeyModFlags KeyModsPrev;
		public ImGuiKeyData KeysData[ImGuiKey_KeysData_SIZE];
		public byte WantCaptureMouseUnlessPopupClose;
		public Vector2 MousePosPrev;
		public Vector2 MouseClickedPos[5];
		public double MouseClickedTime[5];
		public byte MouseClicked[5];
		public byte MouseDoubleClicked[5];
		public ushort MouseClickedCount[5];
		public ushort MouseClickedLastCount[5];
		public byte MouseReleased[5];
		public byte MouseDownOwned[5];
		public byte MouseDownOwnedUnlessPopupClose[5];
		public float MouseDownDuration[5];
		public float MouseDownDurationPrev[5];
		public float MouseDragMaxDistanceSqr[5];
		public float NavInputsDownDuration[ImGuiNavInput_COUNT];
		public float NavInputsDownDurationPrev[ImGuiNavInput_COUNT];
		public float PenPressure;
		public byte AppFocusLost;
		public sbyte BackendUsingLegacyKeyArrays;
		public byte BackendUsingLegacyNavInputArray;
		public ushort InputQueueSurrogate;
		public ImVector_ImWchar InputQueueCharacters;
	}

	public unsafe partial struct ImGuiInputTextCallbackData
	{
		public ImGuiInputTextFlags EventFlag;
		public ImGuiInputTextFlags Flags;
		public void* UserData;
		public ImWchar EventChar;
		public ImGuiKey EventKey;
		public byte* Buf;
		public int BufTextLen;
		public int BufSize;
		public byte BufDirty;
		public int CursorPos;
		public int SelectionStart;
		public int SelectionEnd;
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
	}

	public unsafe partial struct ImGuiOnceUponAFrame
	{
		public int RefFrame;
	}

	public unsafe partial struct ImGuiPayload
	{
		public void* Data;
		public int DataSize;
		public ImGuiID SourceId;
		public ImGuiID SourceParentId;
		public int DataFrameCount;
		public byte DataType[32+1];
		public byte Preview;
		public byte Delivery;
	}

	public unsafe partial struct ImGuiPlatformImeData
	{
		public byte WantVisible;
		public Vector2 InputPos;
		public float InputLineHeight;
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
		public ImVector_ImGuiStoragePair Data;
	}

	public unsafe partial struct ImGuiStoragePair
	{
		public ImGuiID key;
		public union { int val_i; float val_f; void* val_p;} ;
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
		public Vector4 Colors[ImGuiCol_COUNT];
	}

	public unsafe partial struct ImGuiTableColumnSortSpecs
	{
		public ImGuiID ColumnUserID;
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
		public ImVector_char Buf;
	}

	public unsafe partial struct ImGuiTextFilter
	{
		public byte InputBuf[256];
		public ImVector_ImGuiTextRange Filters;
		public int CountGrep;
	}

	public unsafe partial struct ImGuiTextRange
	{
		public byte* b;
		public byte* e;
	}

	public unsafe partial struct ImGuiViewport
	{
		public ImGuiViewportFlags Flags;
		public Vector2 Pos;
		public Vector2 Size;
		public Vector2 WorkPos;
		public Vector2 WorkSize;
		public void* PlatformHandleRaw;
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
		public unsigned char insert_mode;
		public int row_count_per_page;
		public unsigned char cursor_at_end_of_line;
		public unsigned char initialized;
		public unsigned char has_preferred_x;
		public unsigned char single_line;
		public unsigned char padding1;
		public unsigned char padding2;
		public unsigned char padding3;
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
		public StbUndoRecord undo_rec[99];
		public ImWchar undo_char[999];
		public short undo_point;
		public short redo_point;
		public int undo_char_point;
		public int redo_char_point;
	}

}

