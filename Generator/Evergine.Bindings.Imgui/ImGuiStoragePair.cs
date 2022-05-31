using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Evergine.Bindings.Imgui
{
    public class ImGuiStoragePair
    {
        public uint Key;
        public UnionValue Value;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct UnionValue
    {
        [FieldOffset(0)]
        public int ValueI32;
        [FieldOffset(0)]
        public float ValueF32;
        [FieldOffset(0)]
        public IntPtr ValuePtr;
    }
}
