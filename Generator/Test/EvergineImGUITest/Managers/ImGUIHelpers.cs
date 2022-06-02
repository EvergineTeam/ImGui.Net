namespace EvergineImGUITest.Managers
{
    public static unsafe class ImGUIHelpers
    {
        public static byte* ToPointer(this string text)
        {
            return (byte*)System.Runtime.InteropServices.Marshal.StringToHGlobalAnsi(text);
        }
    }
}
