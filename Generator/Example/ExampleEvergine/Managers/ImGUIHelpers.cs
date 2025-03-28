using Evergine.Mathematics;
using System.Runtime.CompilerServices;

namespace ExampleEvergine.Managers
{
    public static unsafe class ImGUIHelpers
    {
        public static float* Ptr(this ref Matrix4x4 matrix)
        {
            return (float*)Unsafe.AsPointer(ref matrix.M11);
        }

        public static byte* Ptr(this ref bool b)
        {
            return (byte*)Unsafe.AsPointer(ref b);
        }
    }
}
