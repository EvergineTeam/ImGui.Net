using Evergine.Mathematics;
using Evergine.Bindings.Imgui;
using System;
using System.Runtime.InteropServices;

namespace Evergine.Bindings.Imnodes
{
	public static unsafe partial class ImnodesNative
	{
		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_BeginInputAttribute(int id, ImNodesPinShape shape);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_BeginNode(int id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_BeginNodeEditor();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_BeginNodeTitleBar();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_BeginOutputAttribute(int id, ImNodesPinShape shape);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_BeginStaticAttribute(int id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_ClearLinkSelection_Nil();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_ClearLinkSelection_Int(int link_id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_ClearNodeSelection_Nil();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_ClearNodeSelection_Int(int node_id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr imnodes_CreateContext();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_DestroyContext(IntPtr ctx);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr imnodes_EditorContextCreate();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_EditorContextFree(IntPtr noname1);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_EditorContextGetPanning(Vector2* pOut);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_EditorContextMoveToNode(int node_id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_EditorContextResetPanning(Vector2 pos);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_EditorContextSet(IntPtr noname1);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_EndInputAttribute();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_EndNode();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_EndNodeEditor();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_EndNodeTitleBar();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_EndOutputAttribute();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_EndStaticAttribute();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr imnodes_GetCurrentContext();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImNodesIO* imnodes_GetIO();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_GetNodeDimensions(Vector2* pOut, int id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_GetNodeEditorSpacePos(Vector2* pOut, int node_id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_GetNodeGridSpacePos(Vector2* pOut, int node_id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_GetNodeScreenSpacePos(Vector2* pOut, int node_id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_GetSelectedLinks(int* link_ids);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_GetSelectedNodes(int* node_ids);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImNodesStyle* imnodes_GetStyle();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.I1)]
		public static extern bool imnodes_IsAnyAttributeActive(int* attribute_id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.I1)]
		public static extern bool imnodes_IsAttributeActive();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.I1)]
		public static extern bool imnodes_IsEditorHovered();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.I1)]
		public static extern bool imnodes_IsLinkCreated_BoolPtr(int* started_at_attribute_id, int* ended_at_attribute_id, byte* created_from_snap);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.I1)]
		public static extern bool imnodes_IsLinkCreated_IntPtr(int* started_at_node_id, int* started_at_attribute_id, int* ended_at_node_id, int* ended_at_attribute_id, byte* created_from_snap);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.I1)]
		public static extern bool imnodes_IsLinkDestroyed(int* link_id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.I1)]
		public static extern bool imnodes_IsLinkDropped(int* started_at_attribute_id, [MarshalAs(UnmanagedType.I1)] bool including_detached_links);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.I1)]
		public static extern bool imnodes_IsLinkHovered(int* link_id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.I1)]
		public static extern bool imnodes_IsLinkSelected(int link_id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.I1)]
		public static extern bool imnodes_IsLinkStarted(int* started_at_attribute_id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.I1)]
		public static extern bool imnodes_IsNodeHovered(int* node_id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.I1)]
		public static extern bool imnodes_IsNodeSelected(int node_id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.I1)]
		public static extern bool imnodes_IsPinHovered(int* attribute_id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_Link(int id, int start_attribute_id, int end_attribute_id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_LoadCurrentEditorStateFromIniFile([MarshalAs(UnmanagedType.LPUTF8Str)] string file_name);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_LoadCurrentEditorStateFromIniString([MarshalAs(UnmanagedType.LPUTF8Str)] string data, uint data_size);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_LoadEditorStateFromIniFile(IntPtr editor, [MarshalAs(UnmanagedType.LPUTF8Str)] string file_name);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_LoadEditorStateFromIniString(IntPtr editor, [MarshalAs(UnmanagedType.LPUTF8Str)] string data, uint data_size);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_MiniMap(float minimap_size_fraction, ImNodesMiniMapLocation location, IntPtr node_hovering_callback, IntPtr node_hovering_callback_data);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int imnodes_NumSelectedLinks();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern int imnodes_NumSelectedNodes();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_PopAttributeFlag();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_PopColorStyle();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_PopStyleVar(int count);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_PushAttributeFlag(ImNodesAttributeFlags flag);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_PushColorStyle(ImNodesCol item, uint color);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_PushStyleVar_Float(ImNodesStyleVar style_item, float value);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_PushStyleVar_Vec2(ImNodesStyleVar style_item, Vector2 value);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_SaveCurrentEditorStateToIniFile([MarshalAs(UnmanagedType.LPUTF8Str)] string file_name);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.LPUTF8Str)]
		public static extern string imnodes_SaveCurrentEditorStateToIniString(uint* data_size);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_SaveEditorStateToIniFile(IntPtr editor, [MarshalAs(UnmanagedType.LPUTF8Str)] string file_name);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.LPUTF8Str)]
		public static extern string imnodes_SaveEditorStateToIniString(IntPtr editor, uint* data_size);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_SelectLink(int link_id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_SelectNode(int node_id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_SetCurrentContext(IntPtr ctx);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_SetImGuiContext(IntPtr ctx);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_SetNodeDraggable(int node_id, [MarshalAs(UnmanagedType.I1)] bool draggable);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_SetNodeEditorSpacePos(int node_id, Vector2 editor_space_pos);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_SetNodeGridSpacePos(int node_id, Vector2 grid_pos);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_SetNodeScreenSpacePos(int node_id, Vector2 screen_space_pos);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_SnapNodeToGrid(int node_id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_StyleColorsClassic(ImNodesStyle* dest);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_StyleColorsDark(ImNodesStyle* dest);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_StyleColorsLight(ImNodesStyle* dest);

	}
}
