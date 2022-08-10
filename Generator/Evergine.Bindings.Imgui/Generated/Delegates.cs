using Evergine.Mathematics;
using System.Runtime.InteropServices;

namespace Evergine.Bindings.Imgui
{
	public unsafe delegate void InlineDelegate0(ImGuiViewport* vp);
	public unsafe delegate void InlineDelegate1(ImGuiViewport* vp, Vector2 pos);
	public unsafe delegate ImVec2 InlineDelegate2(ImGuiViewport* vp);
	public unsafe delegate void InlineDelegate3(ImGuiViewport* vp, Vector2 size);
	public unsafe delegate bool InlineDelegate4(ImGuiViewport* vp);
	public unsafe delegate void InlineDelegate5(ImGuiViewport* vp, [MarshalAs(UnmanagedType.LPStr)] string str);
	public unsafe delegate void InlineDelegate6(ImGuiViewport* vp, float alpha);
	public unsafe delegate void InlineDelegate7(ImGuiViewport* vp, void* render_arg);
	public unsafe delegate float InlineDelegate8(ImGuiViewport* vp);
	public unsafe delegate int InlineDelegate9(ImGuiViewport* vp, ulong vk_inst, void* vk_allocators, ulong* out_vk_surface);
	public unsafe delegate bool InlineDelegate10(void* data, int idx, char** out_text);
	public unsafe delegate float InlineDelegate11(void* data, int idx);
}
