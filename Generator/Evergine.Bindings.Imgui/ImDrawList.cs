using System;
using System.Collections.Generic;
using System.Text;

namespace Evergine.Bindings.Imgui
{
    public unsafe partial struct ImDrawList
    {
        public ImDrawCmd* this[int index]
        {
            get
            {
                return (ImDrawCmd*)((long)CmdBuffer.Data + index * (sizeof(ImDrawCmd)));
            }
        }

        public ImDrawCmd* GetDrawCmdAt(int index)
        {
            return (ImDrawCmd*)((long)CmdBuffer.Data + index * (sizeof(ImDrawCmd)));
        }
    }
}
