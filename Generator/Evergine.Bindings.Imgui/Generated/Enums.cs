using Evergine.Mathematics;
using Evergine.Bindings.Imgui;
using System;

namespace Evergine.Bindings.Imgui
{
	[Flags]
	public enum ImDrawFlags
	{
		None = 0,
		Closed = 1,
		RoundCornersTopLeft = 16,
		RoundCornersTopRight = 32,
		RoundCornersBottomLeft = 64,
		RoundCornersBottomRight = 128,
		RoundCornersNone = 256,
		RoundCornersTop = 48,
		RoundCornersBottom = 192,
		RoundCornersLeft = 80,
		RoundCornersRight = 160,
		RoundCornersAll = 240,
		RoundCornersDefault_ = 240,
		RoundCornersMask_ = 496,
	}

	[Flags]
	public enum ImDrawListFlags
	{
		None = 0,
		AntiAliasedLines = 1,
		AntiAliasedLinesUseTex = 2,
		AntiAliasedFill = 4,
		AllowVtxOffset = 8,
	}

	[Flags]
	public enum ImFontAtlasFlags
	{
		None = 0,
		NoPowerOfTwoHeight = 1,
		NoMouseCursors = 2,
		NoBakedLines = 4,
	}

	[Flags]
	public enum ImGuiBackendFlags
	{
		None = 0,
		HasGamepad = 1,
		HasMouseCursors = 2,
		HasSetMousePos = 4,
		RendererHasVtxOffset = 8,
	}

	[Flags]
	public enum ImGuiButtonFlags
	{
		None = 0,
		MouseButtonLeft = 1,
		MouseButtonRight = 2,
		MouseButtonMiddle = 4,
		MouseButtonMask_ = 7,
		MouseButtonDefault_ = 1,
	}

	public enum ImGuiCol
	{
		Text = 0,
		TextDisabled = 1,
		WindowBg = 2,
		ChildBg = 3,
		PopupBg = 4,
		Border = 5,
		BorderShadow = 6,
		FrameBg = 7,
		FrameBgHovered = 8,
		FrameBgActive = 9,
		TitleBg = 10,
		TitleBgActive = 11,
		TitleBgCollapsed = 12,
		MenuBarBg = 13,
		ScrollbarBg = 14,
		ScrollbarGrab = 15,
		ScrollbarGrabHovered = 16,
		ScrollbarGrabActive = 17,
		CheckMark = 18,
		SliderGrab = 19,
		SliderGrabActive = 20,
		Button = 21,
		ButtonHovered = 22,
		ButtonActive = 23,
		Header = 24,
		HeaderHovered = 25,
		HeaderActive = 26,
		Separator = 27,
		SeparatorHovered = 28,
		SeparatorActive = 29,
		ResizeGrip = 30,
		ResizeGripHovered = 31,
		ResizeGripActive = 32,
		Tab = 33,
		TabHovered = 34,
		TabActive = 35,
		TabUnfocused = 36,
		TabUnfocusedActive = 37,
		PlotLines = 38,
		PlotLinesHovered = 39,
		PlotHistogram = 40,
		PlotHistogramHovered = 41,
		TableHeaderBg = 42,
		TableBorderStrong = 43,
		TableBorderLight = 44,
		TableRowBg = 45,
		TableRowBgAlt = 46,
		TextSelectedBg = 47,
		DragDropTarget = 48,
		NavHighlight = 49,
		NavWindowingHighlight = 50,
		NavWindowingDimBg = 51,
		ModalWindowDimBg = 52,
		COUNT = 53,
	}

	[Flags]
	public enum ImGuiColorEditFlags
	{
		None = 0,
		NoAlpha = 2,
		NoPicker = 4,
		NoOptions = 8,
		NoSmallPreview = 16,
		NoInputs = 32,
		NoTooltip = 64,
		NoLabel = 128,
		NoSidePreview = 256,
		NoDragDrop = 512,
		NoBorder = 1024,
		AlphaBar = 65536,
		AlphaPreview = 131072,
		AlphaPreviewHalf = 262144,
		HDR = 524288,
		DisplayRGB = 1048576,
		DisplayHSV = 2097152,
		DisplayHex = 4194304,
		Uint8 = 8388608,
		Float = 16777216,
		PickerHueBar = 33554432,
		PickerHueWheel = 67108864,
		InputRGB = 134217728,
		InputHSV = 268435456,
		DefaultOptions_ = 177209344,
		DisplayMask_ = 7340032,
		DataTypeMask_ = 25165824,
		PickerMask_ = 100663296,
		InputMask_ = 402653184,
	}

	[Flags]
	public enum ImGuiComboFlags
	{
		None = 0,
		PopupAlignLeft = 1,
		HeightSmall = 2,
		HeightRegular = 4,
		HeightLarge = 8,
		HeightLargest = 16,
		NoArrowButton = 32,
		NoPreview = 64,
		HeightMask_ = 30,
	}

	public enum ImGuiCond
	{
		None = 0,
		Always = 1,
		Once = 2,
		FirstUseEver = 4,
		Appearing = 8,
	}

	[Flags]
	public enum ImGuiConfigFlags
	{
		None = 0,
		NavEnableKeyboard = 1,
		NavEnableGamepad = 2,
		NavEnableSetMousePos = 4,
		NavNoCaptureKeyboard = 8,
		NoMouse = 16,
		NoMouseCursorChange = 32,
		IsSRGB = 1048576,
		IsTouchScreen = 2097152,
	}

	public enum ImGuiDataType
	{
		S8 = 0,
		U8 = 1,
		S16 = 2,
		U16 = 3,
		S32 = 4,
		U32 = 5,
		S64 = 6,
		U64 = 7,
		Float = 8,
		Double = 9,
		COUNT = 10,
	}

	public enum ImGuiDir
	{
		None = -1,
		Left = 0,
		Right = 1,
		Up = 2,
		Down = 3,
		COUNT = 4,
	}

	[Flags]
	public enum ImGuiDragDropFlags
	{
		None = 0,
		SourceNoPreviewTooltip = 1,
		SourceNoDisableHover = 2,
		SourceNoHoldToOpenOthers = 4,
		SourceAllowNullID = 8,
		SourceExtern = 16,
		SourceAutoExpirePayload = 32,
		AcceptBeforeDelivery = 1024,
		AcceptNoDrawDefaultRect = 2048,
		AcceptNoPreviewTooltip = 4096,
		AcceptPeekOnly = 3072,
	}

	[Flags]
	public enum ImGuiFocusedFlags
	{
		None = 0,
		ChildWindows = 1,
		RootWindow = 2,
		AnyWindow = 4,
		NoPopupHierarchy = 8,
		RootAndChildWindows = 3,
	}

	[Flags]
	public enum ImGuiHoveredFlags
	{
		None = 0,
		ChildWindows = 1,
		RootWindow = 2,
		AnyWindow = 4,
		NoPopupHierarchy = 8,
		AllowWhenBlockedByPopup = 32,
		AllowWhenBlockedByActiveItem = 128,
		AllowWhenOverlapped = 256,
		AllowWhenDisabled = 512,
		RectOnly = 416,
		RootAndChildWindows = 3,
	}

	[Flags]
	public enum ImGuiInputTextFlags
	{
		None = 0,
		CharsDecimal = 1,
		CharsHexadecimal = 2,
		CharsUppercase = 4,
		CharsNoBlank = 8,
		AutoSelectAll = 16,
		EnterReturnsTrue = 32,
		CallbackCompletion = 64,
		CallbackHistory = 128,
		CallbackAlways = 256,
		CallbackCharFilter = 512,
		AllowTabInput = 1024,
		CtrlEnterForNewLine = 2048,
		NoHorizontalScroll = 4096,
		AlwaysOverwrite = 8192,
		ReadOnly = 16384,
		Password = 32768,
		NoUndoRedo = 65536,
		CharsScientific = 131072,
		CallbackResize = 262144,
		CallbackEdit = 524288,
	}

	[Flags]
	public enum ImGuiKeyModFlags
	{
		None = 0,
		Ctrl = 1,
		Shift = 2,
		Alt = 4,
		Super = 8,
	}

	public enum ImGuiKey
	{
		None = 0,
		Tab = 512,
		LeftArrow = 513,
		RightArrow = 514,
		UpArrow = 515,
		DownArrow = 516,
		PageUp = 517,
		PageDown = 518,
		Home = 519,
		End = 520,
		Insert = 521,
		Delete = 522,
		Backspace = 523,
		Space = 524,
		Enter = 525,
		Escape = 526,
		LeftCtrl = 527,
		LeftShift = 528,
		LeftAlt = 529,
		LeftSuper = 530,
		RightCtrl = 531,
		RightShift = 532,
		RightAlt = 533,
		RightSuper = 534,
		Menu = 535,
		_0 = 536,
		_1 = 537,
		_2 = 538,
		_3 = 539,
		_4 = 540,
		_5 = 541,
		_6 = 542,
		_7 = 543,
		_8 = 544,
		_9 = 545,
		A = 546,
		B = 547,
		C = 548,
		D = 549,
		E = 550,
		F = 551,
		G = 552,
		H = 553,
		I = 554,
		J = 555,
		K = 556,
		L = 557,
		M = 558,
		N = 559,
		O = 560,
		P = 561,
		Q = 562,
		R = 563,
		S = 564,
		T = 565,
		U = 566,
		V = 567,
		W = 568,
		X = 569,
		Y = 570,
		Z = 571,
		F1 = 572,
		F2 = 573,
		F3 = 574,
		F4 = 575,
		F5 = 576,
		F6 = 577,
		F7 = 578,
		F8 = 579,
		F9 = 580,
		F10 = 581,
		F11 = 582,
		F12 = 583,
		Apostrophe = 584,
		Comma = 585,
		Minus = 586,
		Period = 587,
		Slash = 588,
		Semicolon = 589,
		Equal = 590,
		LeftBracket = 591,
		Backslash = 592,
		RightBracket = 593,
		GraveAccent = 594,
		CapsLock = 595,
		ScrollLock = 596,
		NumLock = 597,
		PrintScreen = 598,
		Pause = 599,
		Keypad0 = 600,
		Keypad1 = 601,
		Keypad2 = 602,
		Keypad3 = 603,
		Keypad4 = 604,
		Keypad5 = 605,
		Keypad6 = 606,
		Keypad7 = 607,
		Keypad8 = 608,
		Keypad9 = 609,
		KeypadDecimal = 610,
		KeypadDivide = 611,
		KeypadMultiply = 612,
		KeypadSubtract = 613,
		KeypadAdd = 614,
		KeypadEnter = 615,
		KeypadEqual = 616,
		GamepadStart = 617,
		GamepadBack = 618,
		GamepadFaceUp = 619,
		GamepadFaceDown = 620,
		GamepadFaceLeft = 621,
		GamepadFaceRight = 622,
		GamepadDpadUp = 623,
		GamepadDpadDown = 624,
		GamepadDpadLeft = 625,
		GamepadDpadRight = 626,
		GamepadL1 = 627,
		GamepadR1 = 628,
		GamepadL2 = 629,
		GamepadR2 = 630,
		GamepadL3 = 631,
		GamepadR3 = 632,
		GamepadLStickUp = 633,
		GamepadLStickDown = 634,
		GamepadLStickLeft = 635,
		GamepadLStickRight = 636,
		GamepadRStickUp = 637,
		GamepadRStickDown = 638,
		GamepadRStickLeft = 639,
		GamepadRStickRight = 640,
		ModCtrl = 641,
		ModShift = 642,
		ModAlt = 643,
		ModSuper = 644,
		COUNT = 645,
		NamedKey_BEGIN = 512,
		NamedKey_END = 645,
		NamedKey_COUNT = 133,
		KeysData_SIZE = 645,
		KeysData_OFFSET = 0,
	}

	public enum ImGuiMouseButton
	{
		Left = 0,
		Right = 1,
		Middle = 2,
		COUNT = 5,
	}

	public enum ImGuiMouseCursor
	{
		None = -1,
		Arrow = 0,
		TextInput = 1,
		ResizeAll = 2,
		ResizeNS = 3,
		ResizeEW = 4,
		ResizeNESW = 5,
		ResizeNWSE = 6,
		Hand = 7,
		NotAllowed = 8,
		COUNT = 9,
	}

	public enum ImGuiNavInput
	{
		Activate = 0,
		Cancel = 1,
		Input = 2,
		Menu = 3,
		DpadLeft = 4,
		DpadRight = 5,
		DpadUp = 6,
		DpadDown = 7,
		LStickLeft = 8,
		LStickRight = 9,
		LStickUp = 10,
		LStickDown = 11,
		FocusPrev = 12,
		FocusNext = 13,
		TweakSlow = 14,
		TweakFast = 15,
		KeyLeft_ = 16,
		KeyRight_ = 17,
		KeyUp_ = 18,
		KeyDown_ = 19,
		COUNT = 20,
	}

	[Flags]
	public enum ImGuiPopupFlags
	{
		None = 0,
		MouseButtonLeft = 0,
		MouseButtonRight = 1,
		MouseButtonMiddle = 2,
		MouseButtonMask_ = 31,
		MouseButtonDefault_ = 1,
		NoOpenOverExistingPopup = 32,
		NoOpenOverItems = 64,
		AnyPopupId = 128,
		AnyPopupLevel = 256,
		AnyPopup = 384,
	}

	[Flags]
	public enum ImGuiSelectableFlags
	{
		None = 0,
		DontClosePopups = 1,
		SpanAllColumns = 2,
		AllowDoubleClick = 4,
		Disabled = 8,
		AllowItemOverlap = 16,
	}

	[Flags]
	public enum ImGuiSliderFlags
	{
		None = 0,
		AlwaysClamp = 16,
		Logarithmic = 32,
		NoRoundToFormat = 64,
		NoInput = 128,
		InvalidMask_ = 1879048207,
	}

	public enum ImGuiSortDirection
	{
		None = 0,
		Ascending = 1,
		Descending = 2,
	}

	public enum ImGuiStyleVar
	{
		Alpha = 0,
		DisabledAlpha = 1,
		WindowPadding = 2,
		WindowRounding = 3,
		WindowBorderSize = 4,
		WindowMinSize = 5,
		WindowTitleAlign = 6,
		ChildRounding = 7,
		ChildBorderSize = 8,
		PopupRounding = 9,
		PopupBorderSize = 10,
		FramePadding = 11,
		FrameRounding = 12,
		FrameBorderSize = 13,
		ItemSpacing = 14,
		ItemInnerSpacing = 15,
		IndentSpacing = 16,
		CellPadding = 17,
		ScrollbarSize = 18,
		ScrollbarRounding = 19,
		GrabMinSize = 20,
		GrabRounding = 21,
		TabRounding = 22,
		ButtonTextAlign = 23,
		SelectableTextAlign = 24,
		COUNT = 25,
	}

	[Flags]
	public enum ImGuiTabBarFlags
	{
		None = 0,
		Reorderable = 1,
		AutoSelectNewTabs = 2,
		TabListPopupButton = 4,
		NoCloseWithMiddleMouseButton = 8,
		NoTabListScrollingButtons = 16,
		NoTooltip = 32,
		FittingPolicyResizeDown = 64,
		FittingPolicyScroll = 128,
		FittingPolicyMask_ = 192,
		FittingPolicyDefault_ = 64,
	}

	[Flags]
	public enum ImGuiTabItemFlags
	{
		None = 0,
		UnsavedDocument = 1,
		SetSelected = 2,
		NoCloseWithMiddleMouseButton = 4,
		NoPushId = 8,
		NoTooltip = 16,
		NoReorder = 32,
		Leading = 64,
		Trailing = 128,
	}

	public enum ImGuiTableBgTarget
	{
		None = 0,
		RowBg0 = 1,
		RowBg1 = 2,
		CellBg = 3,
	}

	[Flags]
	public enum ImGuiTableColumnFlags
	{
		None = 0,
		Disabled = 1,
		DefaultHide = 2,
		DefaultSort = 4,
		WidthStretch = 8,
		WidthFixed = 16,
		NoResize = 32,
		NoReorder = 64,
		NoHide = 128,
		NoClip = 256,
		NoSort = 512,
		NoSortAscending = 1024,
		NoSortDescending = 2048,
		NoHeaderLabel = 4096,
		NoHeaderWidth = 8192,
		PreferSortAscending = 16384,
		PreferSortDescending = 32768,
		IndentEnable = 65536,
		IndentDisable = 131072,
		IsEnabled = 16777216,
		IsVisible = 33554432,
		IsSorted = 67108864,
		IsHovered = 134217728,
		WidthMask_ = 24,
		IndentMask_ = 196608,
		StatusMask_ = 251658240,
		NoDirectResize_ = 1073741824,
	}

	[Flags]
	public enum ImGuiTableFlags
	{
		None = 0,
		Resizable = 1,
		Reorderable = 2,
		Hideable = 4,
		Sortable = 8,
		NoSavedSettings = 16,
		ContextMenuInBody = 32,
		RowBg = 64,
		BordersInnerH = 128,
		BordersOuterH = 256,
		BordersInnerV = 512,
		BordersOuterV = 1024,
		BordersH = 384,
		BordersV = 1536,
		BordersInner = 640,
		BordersOuter = 1280,
		Borders = 1920,
		NoBordersInBody = 2048,
		NoBordersInBodyUntilResize = 4096,
		SizingFixedFit = 8192,
		SizingFixedSame = 16384,
		SizingStretchProp = 24576,
		SizingStretchSame = 32768,
		NoHostExtendX = 65536,
		NoHostExtendY = 131072,
		NoKeepColumnsVisible = 262144,
		PreciseWidths = 524288,
		NoClip = 1048576,
		PadOuterX = 2097152,
		NoPadOuterX = 4194304,
		NoPadInnerX = 8388608,
		ScrollX = 16777216,
		ScrollY = 33554432,
		SortMulti = 67108864,
		SortTristate = 134217728,
		SizingMask_ = 57344,
	}

	[Flags]
	public enum ImGuiTableRowFlags
	{
		None = 0,
		Headers = 1,
	}

	[Flags]
	public enum ImGuiTreeNodeFlags
	{
		None = 0,
		Selected = 1,
		Framed = 2,
		AllowItemOverlap = 4,
		NoTreePushOnOpen = 8,
		NoAutoOpenOnLog = 16,
		DefaultOpen = 32,
		OpenOnDoubleClick = 64,
		OpenOnArrow = 128,
		Leaf = 256,
		Bullet = 512,
		FramePadding = 1024,
		SpanAvailWidth = 2048,
		SpanFullWidth = 4096,
		NavLeftJumpsBackHere = 8192,
		CollapsingHeader = 26,
	}

	[Flags]
	public enum ImGuiViewportFlags
	{
		None = 0,
		IsPlatformWindow = 1,
		IsPlatformMonitor = 2,
		OwnedByApp = 4,
	}

	[Flags]
	public enum ImGuiWindowFlags
	{
		None = 0,
		NoTitleBar = 1,
		NoResize = 2,
		NoMove = 4,
		NoScrollbar = 8,
		NoScrollWithMouse = 16,
		NoCollapse = 32,
		AlwaysAutoResize = 64,
		NoBackground = 128,
		NoSavedSettings = 256,
		NoMouseInputs = 512,
		MenuBar = 1024,
		HorizontalScrollbar = 2048,
		NoFocusOnAppearing = 4096,
		NoBringToFrontOnFocus = 8192,
		AlwaysVerticalScrollbar = 16384,
		AlwaysHorizontalScrollbar = 32768,
		AlwaysUseWindowPadding = 65536,
		NoNavInputs = 262144,
		NoNavFocus = 524288,
		UnsavedDocument = 1048576,
		NoNav = 786432,
		NoDecoration = 43,
		NoInputs = 786944,
		NavFlattened = 8388608,
		ChildWindow = 16777216,
		Tooltip = 33554432,
		Popup = 67108864,
		Modal = 134217728,
		ChildMenu = 268435456,
	}

}
