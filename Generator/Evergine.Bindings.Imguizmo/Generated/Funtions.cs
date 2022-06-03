using Evergine.Mathematics;
using Evergine.Bindings.Imgui;
using System;
using System.Runtime.InteropServices;

namespace Evergine.Bindings.Imguizmo
{
	public static unsafe partial class ImguizmoNative
	{
		[DllImport("cimguizmo", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuizmo_AllowAxisFlip([MarshalAs(UnmanagedType.Bool)] bool value);

		[DllImport("cimguizmo", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuizmo_BeginFrame();

		[DllImport("cimguizmo", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuizmo_DecomposeMatrixToComponents(float* matrix, float* translation, float* rotation, float* scale);

		[DllImport("cimguizmo", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuizmo_DrawCubes(float* view, float* projection, float* matrices, int matrixCount);

		[DllImport("cimguizmo", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuizmo_DrawGrid(float* view, float* projection, float* matrix, float gridSize);

		[DllImport("cimguizmo", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuizmo_Enable([MarshalAs(UnmanagedType.Bool)] bool enable);

		[DllImport("cimguizmo", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.Bool)]
		public static extern bool ImGuizmo_IsOver_Nil();

		[DllImport("cimguizmo", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.Bool)]
		public static extern bool ImGuizmo_IsOver_OPERATION(OPERATION op);

		[DllImport("cimguizmo", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.Bool)]
		public static extern bool ImGuizmo_IsUsing();

		[DllImport("cimguizmo", CallingConvention = CallingConvention.Cdecl)]
		[return:MarshalAs(UnmanagedType.Bool)]
		public static extern bool ImGuizmo_Manipulate(float* view, float* projection, OPERATION operation, MODE mode, float* matrix, float* deltaMatrix, float* snap, float* localBounds, float* boundsSnap);

		[DllImport("cimguizmo", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuizmo_RecomposeMatrixFromComponents(float* translation, float* rotation, float* scale, float* matrix);

		[DllImport("cimguizmo", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuizmo_SetDrawlist(ImDrawList* drawlist);

		[DllImport("cimguizmo", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuizmo_SetGizmoSizeClipSpace(float value);

		[DllImport("cimguizmo", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuizmo_SetID(int id);

		[DllImport("cimguizmo", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuizmo_SetImGuiContext(IntPtr ctx);

		[DllImport("cimguizmo", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuizmo_SetOrthographic([MarshalAs(UnmanagedType.Bool)] bool isOrthographic);

		[DllImport("cimguizmo", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuizmo_SetRect(float x, float y, float width, float height);

		[DllImport("cimguizmo", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuizmo_ViewManipulate(float* view, float length, Vector2 position, Vector2 size, uint backgroundColor);

	}
}
