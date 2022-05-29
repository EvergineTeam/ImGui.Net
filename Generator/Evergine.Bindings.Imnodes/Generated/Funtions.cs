using Evergine.Mathematics;
using Evergine.Bindings.Imgui;
using System;
using System.Runtime.InteropServices;

namespace Evergine.Bindings.Imnodes
{
	public static unsafe partial class ImnodesNative
	{
		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void EmulateThreeButtonMouse_EmulateThreeButtonMouse();

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void EmulateThreeButtonMouse_destroy(EmulateThreeButtonMouse* self);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImNodesIO_ImNodesIO();

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImNodesIO_destroy(ImNodesIO* self);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImNodesStyle_ImNodesStyle();

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImNodesStyle_destroy(ImNodesStyle* self);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void LinkDetachWithModifierClick_LinkDetachWithModifierClick();

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void LinkDetachWithModifierClick_destroy(LinkDetachWithModifierClick* self);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_BeginInputAttribute(int id, ImNodesPinShape shape);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_BeginNode(int id);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_BeginNodeEditor();

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_BeginNodeTitleBar();

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_BeginOutputAttribute(int id, ImNodesPinShape shape);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_BeginStaticAttribute(int id);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_ClearLinkSelection_Nil();

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_ClearLinkSelection_Int(int link_id);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_ClearNodeSelection_Nil();

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_ClearNodeSelection_Int(int node_id);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr imnodes_CreateContext();

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_DestroyContext(IntPtr ctx);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr imnodes_EditorContextCreate();

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_EditorContextFree(IntPtr noname1);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_EditorContextGetPanning(Vector2* pOut);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_EditorContextMoveToNode(int node_id);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_EditorContextResetPanning(Vector2 pos);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_EditorContextSet(IntPtr noname1);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_EndInputAttribute();

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_EndNode();

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_EndNodeEditor();

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_EndNodeTitleBar();

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_EndOutputAttribute();

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_EndStaticAttribute();

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr imnodes_GetCurrentContext();

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImNodesIO* imnodes_GetIO();

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_GetNodeDimensions(Vector2* pOut, int id);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_GetNodeEditorSpacePos(Vector2* pOut, int node_id);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_GetNodeGridSpacePos(Vector2* pOut, int node_id);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_GetNodeScreenSpacePos(Vector2* pOut, int node_id);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_GetSelectedLinks(int* link_ids);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_GetSelectedNodes(int* node_ids);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImNodesStyle* imnodes_GetStyle();

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte imnodes_IsAnyAttributeActive(int* attribute_id);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte imnodes_IsAttributeActive();

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte imnodes_IsEditorHovered();

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte imnodes_IsLinkCreated_BoolPtr(int* started_at_attribute_id, int* ended_at_attribute_id, byte* created_from_snap);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte imnodes_IsLinkCreated_IntPtr(int* started_at_node_id, int* started_at_attribute_id, int* ended_at_node_id, int* ended_at_attribute_id, byte* created_from_snap);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte imnodes_IsLinkDestroyed(int* link_id);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte imnodes_IsLinkDropped(int* started_at_attribute_id, byte including_detached_links);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte imnodes_IsLinkHovered(int* link_id);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte imnodes_IsLinkSelected(int link_id);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte imnodes_IsLinkStarted(int* started_at_attribute_id);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte imnodes_IsNodeHovered(int* node_id);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte imnodes_IsNodeSelected(int node_id);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte imnodes_IsPinHovered(int* attribute_id);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_Link(int id, int start_attribute_id, int end_attribute_id);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_LoadCurrentEditorStateFromIniFile(byte* file_name);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_LoadCurrentEditorStateFromIniString(byte* data, uint data_size);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_LoadEditorStateFromIniFile(IntPtr editor, byte* file_name);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_LoadEditorStateFromIniString(IntPtr editor, byte* data, uint data_size);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_MiniMap(float minimap_size_fraction, ImNodesMiniMapLocation location, IntPtr node_hovering_callback, IntPtr node_hovering_callback_data);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern int imnodes_NumSelectedLinks();

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern int imnodes_NumSelectedNodes();

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_PopAttributeFlag();

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_PopColorStyle();

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_PopStyleVar(int count);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_PushAttributeFlag(ImNodesAttributeFlags flag);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_PushColorStyle(ImNodesCol item, uint color);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_PushStyleVar_Float(ImNodesStyleVar style_item, float value);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_PushStyleVar_Vec2(ImNodesStyleVar style_item, Vector2 value);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_SaveCurrentEditorStateToIniFile(byte* file_name);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* imnodes_SaveCurrentEditorStateToIniString(UIntPtr data_size);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_SaveEditorStateToIniFile(IntPtr editor, byte* file_name);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* imnodes_SaveEditorStateToIniString(IntPtr editor, UIntPtr data_size);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_SelectLink(int link_id);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_SelectNode(int node_id);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_SetCurrentContext(IntPtr ctx);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_SetImGuiContext(IntPtr ctx);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_SetNodeDraggable(int node_id, byte draggable);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_SetNodeEditorSpacePos(int node_id, Vector2 editor_space_pos);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_SetNodeGridSpacePos(int node_id, Vector2 grid_pos);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_SetNodeScreenSpacePos(int node_id, Vector2 screen_space_pos);

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_StyleColorsClassic();

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_StyleColorsDark();

		[DllImport("cimnodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void imnodes_StyleColorsLight();

	}
}
