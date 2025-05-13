using Evergine.Mathematics;
using Evergine.Bindings.Imgui;
using System;
using System.Runtime.InteropServices;

namespace Evergine.Bindings.Imguizmo
{
	public static unsafe partial class ImguizmoNative
	{
		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuizmo_AllowAxisFlip([MarshalAs(UnmanagedType.I1)] bool value);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuizmo_BeginFrame();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuizmo_DecomposeMatrixToComponents(float* matrix, float* translation, float* rotation, float* scale);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuizmo_DrawCubes(float* view, float* projection, float* matrices, int matrixCount);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuizmo_DrawGrid(float* view, float* projection, float* matrix, float gridSize);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuizmo_Enable([MarshalAs(UnmanagedType.I1)] bool enable);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ImGuizmo_GetID_Str([MarshalAs(UnmanagedType.LPUTF8Str)] string str_id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ImGuizmo_GetID_StrStr([MarshalAs(UnmanagedType.LPUTF8Str)] string str_id_begin, [MarshalAs(UnmanagedType.LPUTF8Str)] string str_id_end);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ImGuizmo_GetID_Ptr(void* ptr_id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern Style* ImGuizmo_GetStyle();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.I1)]
		public static extern bool ImGuizmo_IsOver_Nil();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.I1)]
		public static extern bool ImGuizmo_IsOver_OPERATION(OPERATION op);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.I1)]
		public static extern bool ImGuizmo_IsOver_FloatPtr(float* position, float pixelRadius);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.I1)]
		public static extern bool ImGuizmo_IsUsing();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.I1)]
		public static extern bool ImGuizmo_IsUsingAny();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.I1)]
		public static extern bool ImGuizmo_IsUsingViewManipulate();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.I1)]
		public static extern bool ImGuizmo_IsViewManipulateHovered();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.I1)]
		public static extern bool ImGuizmo_Manipulate(float* view, float* projection, OPERATION operation, MODE mode, float* matrix, float* deltaMatrix, float* snap, float* localBounds, float* boundsSnap);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuizmo_PopID();

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuizmo_PushID_Str([MarshalAs(UnmanagedType.LPUTF8Str)] string str_id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuizmo_PushID_StrStr([MarshalAs(UnmanagedType.LPUTF8Str)] string str_id_begin, [MarshalAs(UnmanagedType.LPUTF8Str)] string str_id_end);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuizmo_PushID_Ptr(void* ptr_id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuizmo_PushID_Int(int int_id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuizmo_RecomposeMatrixFromComponents(float* translation, float* rotation, float* scale, float* matrix);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuizmo_SetAlternativeWindow(IntPtr window);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuizmo_SetAxisLimit(float value);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuizmo_SetAxisMask([MarshalAs(UnmanagedType.I1)] bool x, [MarshalAs(UnmanagedType.I1)] bool y, [MarshalAs(UnmanagedType.I1)] bool z);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuizmo_SetDrawlist(ImDrawList* drawlist);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuizmo_SetGizmoSizeClipSpace(float value);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuizmo_SetID(int id);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuizmo_SetImGuiContext(IntPtr ctx);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuizmo_SetOrthographic([MarshalAs(UnmanagedType.I1)] bool isOrthographic);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuizmo_SetPlaneLimit(float value);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuizmo_SetRect(float x, float y, float width, float height);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuizmo_ViewManipulate_Float(float* view, float length, Vector2 position, Vector2 size, uint backgroundColor);

		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuizmo_ViewManipulate_FloatPtr(float* view, float* projection, OPERATION operation, MODE mode, float* matrix, float length, Vector2 position, Vector2 size, uint backgroundColor);

	}
}
