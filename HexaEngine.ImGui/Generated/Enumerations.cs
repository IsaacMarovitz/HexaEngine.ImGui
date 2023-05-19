// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;

namespace HexaEngine.ImGui
{
	public enum ImGuiMouseSource
	{
		ImGuiMouseSource_Mouse = unchecked(0),
		TouchScreen = unchecked(1),
		Pen = unchecked(2),
		Count = unchecked(3),
	}

	public enum ImGuiInputEventType
	{
		None = unchecked(0),
		MousePos = unchecked(1),
		MouseWheel = unchecked(2),
		MouseButton = unchecked(3),
		MouseViewport = unchecked(4),
		Key = unchecked(5),
		Text = unchecked(6),
		Focus = unchecked(7),
		Count = unchecked(8),
	}

	public enum ImGuiInputSource
	{
		None = unchecked(0),
		Mouse = unchecked(1),
		Keyboard = unchecked(2),
		Gamepad = unchecked(3),
		Clipboard = unchecked(4),
		Count = unchecked(5),
	}

	public enum ImGuiKey
	{
		None = unchecked(0),
		Tab = unchecked(512),
		LeftArrow = unchecked(513),
		RightArrow = unchecked(514),
		UpArrow = unchecked(515),
		DownArrow = unchecked(516),
		PageUp = unchecked(517),
		PageDown = unchecked(518),
		Home = unchecked(519),
		End = unchecked(520),
		Insert = unchecked(521),
		Delete = unchecked(522),
		Backspace = unchecked(523),
		Space = unchecked(524),
		Enter = unchecked(525),
		Escape = unchecked(526),
		LeftCtrl = unchecked(527),
		LeftShift = unchecked(528),
		LeftAlt = unchecked(529),
		LeftSuper = unchecked(530),
		RightCtrl = unchecked(531),
		RightShift = unchecked(532),
		RightAlt = unchecked(533),
		RightSuper = unchecked(534),
		Menu = unchecked(535),
		Key0 = unchecked(536),
		Key1 = unchecked(537),
		Key2 = unchecked(538),
		Key3 = unchecked(539),
		Key4 = unchecked(540),
		Key5 = unchecked(541),
		Key6 = unchecked(542),
		Key7 = unchecked(543),
		Key8 = unchecked(544),
		Key9 = unchecked(545),
		A = unchecked(546),
		B = unchecked(547),
		C = unchecked(548),
		D = unchecked(549),
		E = unchecked(550),
		F = unchecked(551),
		G = unchecked(552),
		H = unchecked(553),
		I = unchecked(554),
		J = unchecked(555),
		K = unchecked(556),
		L = unchecked(557),
		M = unchecked(558),
		N = unchecked(559),
		O = unchecked(560),
		P = unchecked(561),
		Q = unchecked(562),
		R = unchecked(563),
		S = unchecked(564),
		T = unchecked(565),
		U = unchecked(566),
		V = unchecked(567),
		W = unchecked(568),
		X = unchecked(569),
		Y = unchecked(570),
		Z = unchecked(571),
		F1 = unchecked(572),
		F2 = unchecked(573),
		F3 = unchecked(574),
		F4 = unchecked(575),
		F5 = unchecked(576),
		F6 = unchecked(577),
		F7 = unchecked(578),
		F8 = unchecked(579),
		F9 = unchecked(580),
		F10 = unchecked(581),
		F11 = unchecked(582),
		F12 = unchecked(583),
		Apostrophe = unchecked(584),
		Comma = unchecked(585),
		Minus = unchecked(586),
		Period = unchecked(587),
		Slash = unchecked(588),
		Semicolon = unchecked(589),
		Equal = unchecked(590),
		LeftBracket = unchecked(591),
		Backslash = unchecked(592),
		RightBracket = unchecked(593),
		GraveAccent = unchecked(594),
		CapsLock = unchecked(595),
		ScrollLock = unchecked(596),
		NumLock = unchecked(597),
		PrintScreen = unchecked(598),
		Pause = unchecked(599),
		Keypad0 = unchecked(600),
		Keypad1 = unchecked(601),
		Keypad2 = unchecked(602),
		Keypad3 = unchecked(603),
		Keypad4 = unchecked(604),
		Keypad5 = unchecked(605),
		Keypad6 = unchecked(606),
		Keypad7 = unchecked(607),
		Keypad8 = unchecked(608),
		Keypad9 = unchecked(609),
		KeypadDecimal = unchecked(610),
		KeypadDivide = unchecked(611),
		KeypadMultiply = unchecked(612),
		KeypadSubtract = unchecked(613),
		KeypadAdd = unchecked(614),
		KeypadEnter = unchecked(615),
		KeypadEqual = unchecked(616),
		GamepadStart = unchecked(617),
		GamepadBack = unchecked(618),
		GamepadFaceLeft = unchecked(619),
		GamepadFaceRight = unchecked(620),
		GamepadFaceUp = unchecked(621),
		GamepadFaceDown = unchecked(622),
		GamepadDpadLeft = unchecked(623),
		GamepadDpadRight = unchecked(624),
		GamepadDpadUp = unchecked(625),
		GamepadDpadDown = unchecked(626),
		GamepadL1 = unchecked(627),
		GamepadR1 = unchecked(628),
		GamepadL2 = unchecked(629),
		GamepadR2 = unchecked(630),
		GamepadL3 = unchecked(631),
		GamepadR3 = unchecked(632),
		GamepadLStickLeft = unchecked(633),
		GamepadLStickRight = unchecked(634),
		GamepadLStickUp = unchecked(635),
		GamepadLStickDown = unchecked(636),
		GamepadRStickLeft = unchecked(637),
		GamepadRStickRight = unchecked(638),
		GamepadRStickUp = unchecked(639),
		GamepadRStickDown = unchecked(640),
		MouseLeft = unchecked(641),
		MouseRight = unchecked(642),
		MouseMiddle = unchecked(643),
		MouseX1 = unchecked(644),
		MouseX2 = unchecked(645),
		MouseWheelX = unchecked(646),
		MouseWheelY = unchecked(647),
		ReservedForModCtrl = unchecked(648),
		ReservedForModShift = unchecked(649),
		ReservedForModAlt = unchecked(650),
		ReservedForModSuper = unchecked(651),
		Count = unchecked(652),
		ModNone = unchecked(0),
		ModCtrl = unchecked(4096),
		ModShift = unchecked(8192),
		ModAlt = unchecked(16384),
		ModSuper = unchecked(32768),
		ModShortcut = unchecked(2048),
		ModMask = unchecked(63488),
		NamedKeyBegin = unchecked(512),
		NamedKeyEnd = Count,
		NamedKeyCount = unchecked(140),
		KeysDataSize = Count,
		KeysDataOffset = unchecked(0),
	}

	public enum ImGuiNavLayer
	{
		Main = unchecked(0),
		Menu = unchecked(1),
		Count = unchecked(2),
	}

	public enum ImGuiDockNodeState
	{
		Unknown = unchecked(0),
		HostWindowHiddenBecauseSingleWindow = unchecked(1),
		HostWindowHiddenBecauseWindowsAreResizing = unchecked(2),
		HostWindowVisible = unchecked(3),
	}

	public enum ImGuiAxis
	{
		None = unchecked(-1),
		X = unchecked(0),
		Y = unchecked(1),
	}

	public enum ImGuiContextHookType
	{
		NewFramePre = unchecked(0),
		NewFramePost = unchecked(1),
		EndFramePre = unchecked(2),
		EndFramePost = unchecked(3),
		RenderPre = unchecked(4),
		RenderPost = unchecked(5),
		Shutdown = unchecked(6),
		PendingRemoval = unchecked(7),
	}

	public enum ImGuiLogType
	{
		None = unchecked(0),
		Tty = unchecked(1),
		File = unchecked(2),
		Buffer = unchecked(3),
		Clipboard = unchecked(4),
	}

	public enum ImGuiLocKey
	{
		TableSizeOne = unchecked(0),
		TableSizeAllFit = unchecked(1),
		TableSizeAllDefault = unchecked(2),
		TableResetOrder = unchecked(3),
		WindowingMainMenuBar = unchecked(4),
		WindowingPopup = unchecked(5),
		WindowingUntitled = unchecked(6),
		DockingHideTabBar = unchecked(7),
		Count = unchecked(8),
	}

	public enum ImGuiWindowFlags
	{
		None = unchecked(0),
		NoTitleBar = unchecked(1),
		NoResize = unchecked(2),
		NoMove = unchecked(4),
		NoScrollbar = unchecked(8),
		NoScrollWithMouse = unchecked(16),
		NoCollapse = unchecked(32),
		AlwaysAutoResize = unchecked(64),
		NoBackground = unchecked(128),
		NoSavedSettings = unchecked(256),
		NoMouseInputs = unchecked(512),
		MenuBar = unchecked(1024),
		HorizontalScrollbar = unchecked(2048),
		NoFocusOnAppearing = unchecked(4096),
		NoBringToFrontOnFocus = unchecked(8192),
		AlwaysVerticalScrollbar = unchecked(16384),
		AlwaysHorizontalScrollbar = unchecked(32768),
		AlwaysUseWindowPadding = unchecked(65536),
		NoNavInputs = unchecked(262144),
		NoNavFocus = unchecked(524288),
		UnsavedDocument = unchecked(1048576),
		NoDocking = unchecked(2097152),
		NoNav = unchecked(786432),
		NoDecoration = unchecked(43),
		NoInputs = unchecked(786944),
		NavFlattened = unchecked(8388608),
		ChildWindow = unchecked(16777216),
		Tooltip = unchecked(33554432),
		Popup = unchecked(67108864),
		Modal = unchecked(134217728),
		ChildMenu = unchecked(268435456),
		DockNodeHost = unchecked(536870912),
	}

	public enum ImGuiInputTextFlags
	{
		None = unchecked(0),
		CharsDecimal = unchecked(1),
		CharsHexadecimal = unchecked(2),
		CharsUppercase = unchecked(4),
		CharsNoBlank = unchecked(8),
		AutoSelectAll = unchecked(16),
		EnterReturnsTrue = unchecked(32),
		CallbackCompletion = unchecked(64),
		CallbackHistory = unchecked(128),
		CallbackAlways = unchecked(256),
		CallbackCharFilter = unchecked(512),
		AllowTabInput = unchecked(1024),
		CtrlEnterForNewLine = unchecked(2048),
		NoHorizontalScroll = unchecked(4096),
		AlwaysOverwrite = unchecked(8192),
		ReadOnly = unchecked(16384),
		Password = unchecked(32768),
		NoUndoRedo = unchecked(65536),
		CharsScientific = unchecked(131072),
		CallbackResize = unchecked(262144),
		CallbackEdit = unchecked(524288),
		EscapeClearsAll = unchecked(1048576),
	}

	public enum ImGuiTreeNodeFlags
	{
		None = unchecked(0),
		Selected = unchecked(1),
		Framed = unchecked(2),
		AllowItemOverlap = unchecked(4),
		NoTreePushOnOpen = unchecked(8),
		NoAutoOpenOnLog = unchecked(16),
		DefaultOpen = unchecked(32),
		OpenOnDoubleClick = unchecked(64),
		OpenOnArrow = unchecked(128),
		Leaf = unchecked(256),
		Bullet = unchecked(512),
		FramePadding = unchecked(1024),
		SpanAvailWidth = unchecked(2048),
		SpanFullWidth = unchecked(4096),
		NavLeftJumpsBackHere = unchecked(8192),
		CollapsingHeader = unchecked(26),
	}

	public enum ImGuiPopupFlags
	{
		None = unchecked(0),
		MouseButtonLeft = unchecked(0),
		MouseButtonRight = unchecked(1),
		MouseButtonMiddle = unchecked(2),
		MouseButtonMask = unchecked(31),
		MouseButtonDefault = unchecked(1),
		NoOpenOverExistingPopup = unchecked(32),
		NoOpenOverItems = unchecked(64),
		AnyPopupId = unchecked(128),
		AnyPopupLevel = unchecked(256),
		AnyPopup = unchecked(384),
	}

	public enum ImGuiSelectableFlags
	{
		None = unchecked(0),
		DontClosePopups = unchecked(1),
		SpanAllColumns = unchecked(2),
		AllowDoubleClick = unchecked(4),
		Disabled = unchecked(8),
		AllowItemOverlap = unchecked(16),
	}

	public enum ImGuiComboFlags
	{
		None = unchecked(0),
		PopupAlignLeft = unchecked(1),
		HeightSmall = unchecked(2),
		HeightRegular = unchecked(4),
		HeightLarge = unchecked(8),
		HeightLargest = unchecked(16),
		NoArrowButton = unchecked(32),
		NoPreview = unchecked(64),
		HeightMask = unchecked(30),
	}

	public enum ImGuiTabBarFlags
	{
		None = unchecked(0),
		Reorderable = unchecked(1),
		AutoSelectNewTabs = unchecked(2),
		ListPopupButton = unchecked(4),
		NoCloseWithMiddleMouseButton = unchecked(8),
		NoTabListScrollingButtons = unchecked(16),
		NoTooltip = unchecked(32),
		FittingPolicyResizeDown = unchecked(64),
		FittingPolicyScroll = unchecked(128),
		FittingPolicyMask = unchecked(192),
		FittingPolicyDefault = FittingPolicyResizeDown,
	}

	public enum ImGuiTabItemFlags
	{
		None = unchecked(0),
		UnsavedDocument = unchecked(1),
		SetSelected = unchecked(2),
		NoCloseWithMiddleMouseButton = unchecked(4),
		NoPushId = unchecked(8),
		NoTooltip = unchecked(16),
		NoReorder = unchecked(32),
		Leading = unchecked(64),
		Trailing = unchecked(128),
	}

	public enum ImGuiTableFlags
	{
		None = unchecked(0),
		Resizable = unchecked(1),
		Reorderable = unchecked(2),
		Hideable = unchecked(4),
		Sortable = unchecked(8),
		NoSavedSettings = unchecked(16),
		ContextMenuInBody = unchecked(32),
		RowBg = unchecked(64),
		BordersInnerH = unchecked(128),
		BordersOuterH = unchecked(256),
		BordersInnerV = unchecked(512),
		BordersOuterV = unchecked(1024),
		BordersH = unchecked(384),
		BordersV = unchecked(1536),
		BordersInner = unchecked(640),
		BordersOuter = unchecked(1280),
		Borders = unchecked(1920),
		NoBordersInBody = unchecked(2048),
		NoBordersInBodyUntilResize = unchecked(4096),
		SizingFixedFit = unchecked(8192),
		SizingFixedSame = unchecked(16384),
		SizingStretchProp = unchecked(24576),
		SizingStretchSame = unchecked(32768),
		NoHostExtendX = unchecked(65536),
		NoHostExtendY = unchecked(131072),
		NoKeepColumnsVisible = unchecked(262144),
		PreciseWidths = unchecked(524288),
		NoClip = unchecked(1048576),
		PadOuterX = unchecked(2097152),
		NoPadOuterX = unchecked(4194304),
		NoPadInnerX = unchecked(8388608),
		ScrollX = unchecked(16777216),
		ScrollY = unchecked(33554432),
		SortMulti = unchecked(67108864),
		SortTristate = unchecked(134217728),
		SizingMask = unchecked(57344),
	}

	public enum ImGuiTableColumnFlags
	{
		None = unchecked(0),
		Disabled = unchecked(1),
		DefaultHide = unchecked(2),
		DefaultSort = unchecked(4),
		WidthStretch = unchecked(8),
		WidthFixed = unchecked(16),
		NoResize = unchecked(32),
		NoReorder = unchecked(64),
		NoHide = unchecked(128),
		NoClip = unchecked(256),
		NoSort = unchecked(512),
		NoSortAscending = unchecked(1024),
		NoSortDescending = unchecked(2048),
		NoHeaderLabel = unchecked(4096),
		NoHeaderWidth = unchecked(8192),
		PreferSortAscending = unchecked(16384),
		PreferSortDescending = unchecked(32768),
		IndentEnable = unchecked(65536),
		IndentDisable = unchecked(131072),
		IsEnabled = unchecked(16777216),
		IsVisible = unchecked(33554432),
		IsSorted = unchecked(67108864),
		IsHovered = unchecked(134217728),
		WidthMask = unchecked(24),
		IndentMask = unchecked(196608),
		StatusMask = unchecked(251658240),
		NoDirectResize = unchecked(1073741824),
	}

	public enum ImGuiTableRowFlags
	{
		None = unchecked(0),
		Headers = unchecked(1),
	}

	public enum ImGuiTableBgTarget
	{
		None = unchecked(0),
		RowBg0 = unchecked(1),
		RowBg1 = unchecked(2),
		CellBg = unchecked(3),
	}

	public enum ImGuiFocusedFlags
	{
		None = unchecked(0),
		ChildWindows = unchecked(1),
		RootWindow = unchecked(2),
		AnyWindow = unchecked(4),
		NoPopupHierarchy = unchecked(8),
		DockHierarchy = unchecked(16),
		RootAndChildWindows = unchecked(3),
	}

	public enum ImGuiHoveredFlags
	{
		None = unchecked(0),
		ChildWindows = unchecked(1),
		RootWindow = unchecked(2),
		AnyWindow = unchecked(4),
		NoPopupHierarchy = unchecked(8),
		DockHierarchy = unchecked(16),
		AllowWhenBlockedByPopup = unchecked(32),
		AllowWhenBlockedByActiveItem = unchecked(128),
		AllowWhenOverlapped = unchecked(256),
		AllowWhenDisabled = unchecked(512),
		NoNavOverride = unchecked(1024),
		RectOnly = unchecked(416),
		RootAndChildWindows = unchecked(3),
		DelayNormal = unchecked(2048),
		DelayShort = unchecked(4096),
		NoSharedDelay = unchecked(8192),
	}

	public enum ImGuiDockNodeFlags
	{
		None = unchecked(0),
		KeepAliveOnly = unchecked(1),
		NoDockingInCentralNode = unchecked(4),
		PassthruCentralNode = unchecked(8),
		NoSplit = unchecked(16),
		NoResize = unchecked(32),
		AutoHideTabBar = unchecked(64),
	}

	public enum ImGuiDragDropFlags
	{
		None = unchecked(0),
		SourceNoPreviewTooltip = unchecked(1),
		SourceNoDisableHover = unchecked(2),
		SourceNoHoldToOpenOthers = unchecked(4),
		SourceAllowNullId = unchecked(8),
		SourceExtern = unchecked(16),
		SourceAutoExpirePayload = unchecked(32),
		AcceptBeforeDelivery = unchecked(1024),
		AcceptNoDrawDefaultRect = unchecked(2048),
		AcceptNoPreviewTooltip = unchecked(4096),
		AcceptPeekOnly = unchecked(3072),
	}

	public enum ImGuiDataType
	{
		S8 = unchecked(0),
		U8 = unchecked(1),
		S16 = unchecked(2),
		U16 = unchecked(3),
		S32 = unchecked(4),
		U32 = unchecked(5),
		S64 = unchecked(6),
		U64 = unchecked(7),
		Float = unchecked(8),
		Double = unchecked(9),
		Count = unchecked(10),
	}

	public enum ImGuiDir
	{
		None = unchecked(-1),
		Left = unchecked(0),
		Right = unchecked(1),
		Up = unchecked(2),
		Down = unchecked(3),
		Count = unchecked(4),
	}

	public enum ImGuiSortDirection
	{
		None = unchecked(0),
		Ascending = unchecked(1),
		Descending = unchecked(2),
	}

	public enum ImGuiNavInput
	{
		Activate = unchecked(0),
		Cancel = unchecked(1),
		ImGuiNavInput_Input = unchecked(2),
		Menu = unchecked(3),
		DpadLeft = unchecked(4),
		DpadRight = unchecked(5),
		DpadUp = unchecked(6),
		DpadDown = unchecked(7),
		LStickLeft = unchecked(8),
		LStickRight = unchecked(9),
		LStickUp = unchecked(10),
		LStickDown = unchecked(11),
		FocusPrev = unchecked(12),
		FocusNext = unchecked(13),
		TweakSlow = unchecked(14),
		TweakFast = unchecked(15),
		Count = unchecked(16),
	}

	public enum ImGuiConfigFlags
	{
		None = unchecked(0),
		NavEnableKeyboard = unchecked(1),
		NavEnableGamepad = unchecked(2),
		NavEnableSetMousePos = unchecked(4),
		NavNoCaptureKeyboard = unchecked(8),
		NoMouse = unchecked(16),
		NoMouseCursorChange = unchecked(32),
		DockingEnable = unchecked(64),
		ViewportsEnable = unchecked(1024),
		DpiEnableScaleViewports = unchecked(16384),
		DpiEnableScaleFonts = unchecked(32768),
		IsSrgb = unchecked(1048576),
		IsTouchScreen = unchecked(2097152),
	}

	public enum ImGuiBackendFlags
	{
		None = unchecked(0),
		HasGamepad = unchecked(1),
		HasMouseCursors = unchecked(2),
		HasSetMousePos = unchecked(4),
		RendererHasVtxOffset = unchecked(8),
		PlatformHasViewports = unchecked(1024),
		HasMouseHoveredViewport = unchecked(2048),
		RendererHasViewports = unchecked(4096),
	}

	public enum ImGuiCol
	{
		Text = unchecked(0),
		TextDisabled = unchecked(1),
		WindowBg = unchecked(2),
		ChildBg = unchecked(3),
		PopupBg = unchecked(4),
		Border = unchecked(5),
		BorderShadow = unchecked(6),
		FrameBg = unchecked(7),
		FrameBgHovered = unchecked(8),
		FrameBgActive = unchecked(9),
		TitleBg = unchecked(10),
		TitleBgActive = unchecked(11),
		TitleBgCollapsed = unchecked(12),
		MenuBarBg = unchecked(13),
		ScrollbarBg = unchecked(14),
		ScrollbarGrab = unchecked(15),
		ScrollbarGrabHovered = unchecked(16),
		ScrollbarGrabActive = unchecked(17),
		CheckMark = unchecked(18),
		SliderGrab = unchecked(19),
		SliderGrabActive = unchecked(20),
		Button = unchecked(21),
		ButtonHovered = unchecked(22),
		ButtonActive = unchecked(23),
		Header = unchecked(24),
		HeaderHovered = unchecked(25),
		HeaderActive = unchecked(26),
		Separator = unchecked(27),
		SeparatorHovered = unchecked(28),
		SeparatorActive = unchecked(29),
		ResizeGrip = unchecked(30),
		ResizeGripHovered = unchecked(31),
		ResizeGripActive = unchecked(32),
		Tab = unchecked(33),
		TabHovered = unchecked(34),
		TabActive = unchecked(35),
		TabUnfocused = unchecked(36),
		TabUnfocusedActive = unchecked(37),
		DockingPreview = unchecked(38),
		DockingEmptyBg = unchecked(39),
		PlotLines = unchecked(40),
		PlotLinesHovered = unchecked(41),
		PlotHistogram = unchecked(42),
		PlotHistogramHovered = unchecked(43),
		TableHeaderBg = unchecked(44),
		TableBorderStrong = unchecked(45),
		TableBorderLight = unchecked(46),
		TableRowBg = unchecked(47),
		TableRowBgAlt = unchecked(48),
		TextSelectedBg = unchecked(49),
		DragDropTarget = unchecked(50),
		NavHighlight = unchecked(51),
		NavWindowingHighlight = unchecked(52),
		NavWindowingDimBg = unchecked(53),
		ModalWindowDimBg = unchecked(54),
		Count = unchecked(55),
	}

	public enum ImGuiStyleVar
	{
		Alpha = unchecked(0),
		DisabledAlpha = unchecked(1),
		WindowPadding = unchecked(2),
		WindowRounding = unchecked(3),
		WindowBorderSize = unchecked(4),
		WindowMinSize = unchecked(5),
		WindowTitleAlign = unchecked(6),
		ChildRounding = unchecked(7),
		ChildBorderSize = unchecked(8),
		PopupRounding = unchecked(9),
		PopupBorderSize = unchecked(10),
		FramePadding = unchecked(11),
		FrameRounding = unchecked(12),
		FrameBorderSize = unchecked(13),
		ItemSpacing = unchecked(14),
		ItemInnerSpacing = unchecked(15),
		IndentSpacing = unchecked(16),
		CellPadding = unchecked(17),
		ScrollbarSize = unchecked(18),
		ScrollbarRounding = unchecked(19),
		GrabMinSize = unchecked(20),
		GrabRounding = unchecked(21),
		TabRounding = unchecked(22),
		ButtonTextAlign = unchecked(23),
		SelectableTextAlign = unchecked(24),
		SeparatorTextBorderSize = unchecked(25),
		SeparatorTextAlign = unchecked(26),
		SeparatorTextPadding = unchecked(27),
		Count = unchecked(28),
	}

	public enum ImGuiButtonFlags
	{
		None = unchecked(0),
		MouseButtonLeft = unchecked(1),
		MouseButtonRight = unchecked(2),
		MouseButtonMiddle = unchecked(4),
		MouseButtonMask = unchecked(7),
		MouseButtonDefault = MouseButtonLeft,
	}

	public enum ImGuiColorEditFlags
	{
		None = unchecked(0),
		NoAlpha = unchecked(2),
		NoPicker = unchecked(4),
		NoOptions = unchecked(8),
		NoSmallPreview = unchecked(16),
		NoInputs = unchecked(32),
		NoTooltip = unchecked(64),
		NoLabel = unchecked(128),
		NoSidePreview = unchecked(256),
		NoDragDrop = unchecked(512),
		NoBorder = unchecked(1024),
		AlphaBar = unchecked(65536),
		AlphaPreview = unchecked(131072),
		AlphaPreviewHalf = unchecked(262144),
		Hdr = unchecked(524288),
		DisplayRgb = unchecked(1048576),
		DisplayHsv = unchecked(2097152),
		DisplayHex = unchecked(4194304),
		Uint8 = unchecked(8388608),
		Float = unchecked(16777216),
		PickerHueBar = unchecked(33554432),
		PickerHueWheel = unchecked(67108864),
		InputRgb = unchecked(134217728),
		InputHsv = unchecked(268435456),
		DefaultOptions = unchecked(177209344),
		DisplayMask = unchecked(7340032),
		DataTypeMask = unchecked(25165824),
		PickerMask = unchecked(100663296),
		InputMask = unchecked(402653184),
	}

	public enum ImGuiSliderFlags
	{
		None = unchecked(0),
		AlwaysClamp = unchecked(16),
		Logarithmic = unchecked(32),
		NoRoundToFormat = unchecked(64),
		NoInput = unchecked(128),
		InvalidMask = unchecked(1879048207),
	}

	public enum ImGuiMouseButton
	{
		Left = unchecked(0),
		Right = unchecked(1),
		Middle = unchecked(2),
		Count = unchecked(5),
	}

	public enum ImGuiMouseCursor
	{
		None = unchecked(-1),
		Arrow = unchecked(0),
		TextInput = unchecked(1),
		ResizeAll = unchecked(2),
		ResizeNs = unchecked(3),
		ResizeEw = unchecked(4),
		ResizeNesw = unchecked(5),
		ResizeNwse = unchecked(6),
		Hand = unchecked(7),
		NotAllowed = unchecked(8),
		Count = unchecked(9),
	}

	public enum ImGuiCond
	{
		None = unchecked(0),
		Always = unchecked(1),
		Once = unchecked(2),
		FirstUseEver = unchecked(4),
		Appearing = unchecked(8),
	}

	public enum ImDrawFlags
	{
		None = unchecked(0),
		Closed = unchecked(1),
		RoundCornersTopLeft = unchecked(16),
		RoundCornersTopRight = unchecked(32),
		RoundCornersBottomLeft = unchecked(64),
		RoundCornersBottomRight = unchecked(128),
		RoundCornersNone = unchecked(256),
		RoundCornersTop = unchecked(48),
		RoundCornersBottom = unchecked(192),
		RoundCornersLeft = unchecked(80),
		RoundCornersRight = unchecked(160),
		RoundCornersAll = unchecked(240),
		RoundCornersDefault = RoundCornersAll,
		RoundCornersMask = unchecked(496),
	}

	public enum ImDrawListFlags
	{
		None = unchecked(0),
		AntiAliasedLines = unchecked(1),
		AntiAliasedLinesUseTex = unchecked(2),
		AntiAliasedFill = unchecked(4),
		AllowVtxOffset = unchecked(8),
	}

	public enum ImFontAtlasFlags
	{
		None = unchecked(0),
		NoPowerOfTwoHeight = unchecked(1),
		NoMouseCursors = unchecked(2),
		NoBakedLines = unchecked(4),
	}

	public enum ImGuiViewportFlags
	{
		None = unchecked(0),
		IsPlatformWindow = unchecked(1),
		IsPlatformMonitor = unchecked(2),
		OwnedByApp = unchecked(4),
		NoDecoration = unchecked(8),
		NoTaskBarIcon = unchecked(16),
		NoFocusOnAppearing = unchecked(32),
		NoFocusOnClick = unchecked(64),
		NoInputs = unchecked(128),
		NoRendererClear = unchecked(256),
		NoAutoMerge = unchecked(512),
		TopMost = unchecked(1024),
		CanHostOtherWindows = unchecked(2048),
		IsMinimized = unchecked(4096),
		IsFocused = unchecked(8192),
	}

	public enum ImGuiItemFlags
	{
		None = unchecked(0),
		NoTabStop = unchecked(1),
		ButtonRepeat = unchecked(2),
		Disabled = unchecked(4),
		NoNav = unchecked(8),
		NoNavDefaultFocus = unchecked(16),
		SelectableDontClosePopup = unchecked(32),
		MixedValue = unchecked(64),
		ReadOnly = unchecked(128),
		NoWindowHoverableCheck = unchecked(256),
		Inputable = unchecked(1024),
	}

	public enum ImGuiItemStatusFlags
	{
		None = unchecked(0),
		HoveredRect = unchecked(1),
		HasDisplayRect = unchecked(2),
		Edited = unchecked(4),
		ToggledSelection = unchecked(8),
		ToggledOpen = unchecked(16),
		HasDeactivated = unchecked(32),
		Deactivated = unchecked(64),
		HoveredWindow = unchecked(128),
		FocusedByTabbing = unchecked(256),
		Visible = unchecked(512),
	}

	public enum ImGuiInputTextFlagsPrivate
	{
		Multiline = unchecked(67108864),
		NoMarkEdited = unchecked(134217728),
		MergedItem = unchecked(268435456),
	}

	public enum ImGuiButtonFlagsPrivate
	{
		PressedOnClick = unchecked(16),
		PressedOnClickRelease = unchecked(32),
		PressedOnClickReleaseAnywhere = unchecked(64),
		PressedOnRelease = unchecked(128),
		PressedOnDoubleClick = unchecked(256),
		PressedOnDragDropHold = unchecked(512),
		Repeat = unchecked(1024),
		FlattenChildren = unchecked(2048),
		AllowItemOverlap = unchecked(4096),
		DontClosePopups = unchecked(8192),
		AlignTextBaseLine = unchecked(32768),
		NoKeyModifiers = unchecked(65536),
		NoHoldingActiveId = unchecked(131072),
		NoNavFocus = unchecked(262144),
		NoHoveredOnFocus = unchecked(524288),
		NoSetKeyOwner = unchecked(1048576),
		NoTestKeyOwner = unchecked(2097152),
		PressedOnMask = unchecked(1008),
		PressedOnDefault = PressedOnClickRelease,
	}

	public enum ImGuiComboFlagsPrivate
	{
		CustomPreview = unchecked(1048576),
	}

	public enum ImGuiSliderFlagsPrivate
	{
		Vertical = unchecked(1048576),
		ReadOnly = unchecked(2097152),
	}

	public enum ImGuiSelectableFlagsPrivate
	{
		NoHoldingActiveId = unchecked(1048576),
		SelectOnNav = unchecked(2097152),
		SelectOnClick = unchecked(4194304),
		SelectOnRelease = unchecked(8388608),
		SpanAvailWidth = unchecked(16777216),
		SetNavIdOnHover = unchecked(33554432),
		NoPadWithHalfSpacing = unchecked(67108864),
		NoSetKeyOwner = unchecked(134217728),
	}

	public enum ImGuiTreeNodeFlagsPrivate
	{
		ClipLabelForTrailingButton = unchecked(1048576),
	}

	public enum ImGuiSeparatorFlags
	{
		None = unchecked(0),
		Horizontal = unchecked(1),
		Vertical = unchecked(2),
		SpanAllColumns = unchecked(4),
	}

	public enum ImGuiFocusRequestFlags
	{
		None = unchecked(0),
		RestoreFocusedChild = unchecked(1),
		UnlessBelowModal = unchecked(2),
	}

	public enum ImGuiTextFlags
	{
		None = unchecked(0),
		NoWidthForLargeClippedText = unchecked(1),
	}

	public enum ImGuiTooltipFlags
	{
		None = unchecked(0),
		OverridePreviousTooltip = unchecked(1),
	}

	public enum ImGuiLayoutType
	{
		Horizontal = unchecked(0),
		Vertical = unchecked(1),
	}

	public enum ImGuiPlotType
	{
		Lines = unchecked(0),
		Histogram = unchecked(1),
	}

	public enum ImGuiPopupPositionPolicy
	{
		Default = unchecked(0),
		ComboBox = unchecked(1),
		Tooltip = unchecked(2),
	}

	public enum ImGuiDataTypePrivate
	{
		String = unchecked(11),
		Pointer = unchecked(12),
		Id = unchecked(13),
	}

	public enum ImGuiNextWindowDataFlags
	{
		None = unchecked(0),
		HasPos = unchecked(1),
		HasSize = unchecked(2),
		HasContentSize = unchecked(4),
		HasCollapsed = unchecked(8),
		HasSizeConstraint = unchecked(16),
		HasFocus = unchecked(32),
		HasBgAlpha = unchecked(64),
		HasScroll = unchecked(128),
		HasViewport = unchecked(256),
		HasDock = unchecked(512),
		HasWindowClass = unchecked(1024),
	}

	public enum ImGuiNextItemDataFlags
	{
		None = unchecked(0),
		HasWidth = unchecked(1),
		HasOpen = unchecked(2),
	}

	public enum ImGuiInputFlags
	{
		None = unchecked(0),
		Repeat = unchecked(1),
		RepeatRateDefault = unchecked(2),
		RepeatRateNavMove = unchecked(4),
		RepeatRateNavTweak = unchecked(8),
		RepeatRateMask = unchecked(14),
		CondHovered = unchecked(16),
		CondActive = unchecked(32),
		CondDefault = unchecked(48),
		CondMask = unchecked(48),
		LockThisFrame = unchecked(64),
		LockUntilRelease = unchecked(128),
		RouteFocused = unchecked(256),
		RouteGlobalLow = unchecked(512),
		RouteGlobal = unchecked(1024),
		RouteGlobalHigh = unchecked(2048),
		RouteMask = unchecked(3840),
		RouteAlways = unchecked(4096),
		RouteUnlessBgFocused = unchecked(8192),
		RouteExtraMask = unchecked(12288),
		SupportedByIsKeyPressed = unchecked(15),
		SupportedByShortcut = unchecked(16143),
		SupportedBySetKeyOwner = unchecked(192),
		SupportedBySetItemKeyOwner = unchecked(240),
	}

	public enum ImGuiActivateFlags
	{
		None = unchecked(0),
		PreferInput = unchecked(1),
		PreferTweak = unchecked(2),
		TryToPreserveState = unchecked(4),
	}

	public enum ImGuiScrollFlags
	{
		None = unchecked(0),
		KeepVisibleEdgeX = unchecked(1),
		KeepVisibleEdgeY = unchecked(2),
		KeepVisibleCenterX = unchecked(4),
		KeepVisibleCenterY = unchecked(8),
		AlwaysCenterX = unchecked(16),
		AlwaysCenterY = unchecked(32),
		NoScrollParent = unchecked(64),
		MaskX = unchecked(21),
		MaskY = unchecked(42),
	}

	public enum ImGuiNavHighlightFlags
	{
		None = unchecked(0),
		TypeDefault = unchecked(1),
		TypeThin = unchecked(2),
		AlwaysDraw = unchecked(4),
		NoRounding = unchecked(8),
	}

	public enum ImGuiNavMoveFlags
	{
		None = unchecked(0),
		LoopX = unchecked(1),
		LoopY = unchecked(2),
		WrapX = unchecked(4),
		WrapY = unchecked(8),
		WrapMask = unchecked(15),
		AllowCurrentNavId = unchecked(16),
		AlsoScoreVisibleSet = unchecked(32),
		ScrollToEdgeY = unchecked(64),
		Forwarded = unchecked(128),
		DebugNoResult = unchecked(256),
		FocusApi = unchecked(512),
		Tabbing = unchecked(1024),
		Activate = unchecked(2048),
		DontSetNavHighlight = unchecked(4096),
	}

	public enum ImGuiOldColumnFlags
	{
		None = unchecked(0),
		NoBorder = unchecked(1),
		NoResize = unchecked(2),
		NoPreserveWidths = unchecked(4),
		NoForceWithinWindow = unchecked(8),
		GrowParentContentsSize = unchecked(16),
	}

	public enum ImGuiDockNodeFlagsPrivate
	{
		Space = unchecked(1024),
		CentralNode = unchecked(2048),
		NoTabBar = unchecked(4096),
		HiddenTabBar = unchecked(8192),
		NoWindowMenuButton = unchecked(16384),
		NoCloseButton = unchecked(32768),
		NoDocking = unchecked(65536),
		NoDockingSplitMe = unchecked(131072),
		NoDockingSplitOther = unchecked(262144),
		NoDockingOverMe = unchecked(524288),
		NoDockingOverOther = unchecked(1048576),
		NoDockingOverEmpty = unchecked(2097152),
		NoResizeX = unchecked(4194304),
		NoResizeY = unchecked(8388608),
		SharedFlagsInheritMask = unchecked(-1),
		NoResizeFlagsMask = unchecked(12582944),
		LocalFlagsMask = unchecked(12713072),
		LocalFlagsTransferMask = unchecked(12712048),
		SavedFlagsMask = unchecked(12712992),
	}

	public enum ImGuiDataAuthority
	{
		Auto = unchecked(0),
		DockNode = unchecked(1),
		Window = unchecked(2),
	}

	public enum ImGuiWindowDockStyleCol
	{
		Text = unchecked(0),
		Tab = unchecked(1),
		TabHovered = unchecked(2),
		TabActive = unchecked(3),
		TabUnfocused = unchecked(4),
		TabUnfocusedActive = unchecked(5),
		Count = unchecked(6),
	}

	public enum ImGuiDebugLogFlags
	{
		None = unchecked(0),
		EventActiveId = unchecked(1),
		EventFocus = unchecked(2),
		EventPopup = unchecked(4),
		EventNav = unchecked(8),
		EventClipper = unchecked(16),
		EventSelection = unchecked(32),
		EventIo = unchecked(64),
		EventDocking = unchecked(128),
		EventViewport = unchecked(256),
		EventMask = unchecked(511),
		OutputToTty = unchecked(1024),
	}

	public enum ImGuiTabBarFlagsPrivate
	{
		DockNode = unchecked(1048576),
		IsFocused = unchecked(2097152),
		SaveSettings = unchecked(4194304),
	}

	public enum ImGuiTabItemFlagsPrivate
	{
		SectionMask = unchecked(192),
		NoCloseButton = unchecked(1048576),
		Button = unchecked(2097152),
		Unsorted = unchecked(4194304),
		Preview = unchecked(8388608),
	}

}
