using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using System;

namespace Evergine.Bindings.Imgui
{
    public unsafe struct ImVector
    {
        public readonly int Size;
        public readonly int Capacity;
        public readonly IntPtr Data;
    }
}
