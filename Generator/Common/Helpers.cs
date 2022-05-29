using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public static class Helpers
    {
        public static string ConvertToCSharpType(string type, Specification spec)
        {
            string result = type.Replace("const ", "");

            if (IsInPtr(result))
            {
                return "IntPtr";
            }

            result = ConvertToBasicTypes(result);

            return result;
        }

        private static string ConvertToBasicTypes(string type)
        {
            switch (type)
            {
                case "bool":
                case "char":
                    return "byte";
                case "bool*":
                case "char*":
                    return "byte*";
                case "size_t":
                    return "uint";
                case "size_t*":
                    return "UIntPtr";
                case "ImVec2":
                    return "Vector2";
                case "ImVec2*":
                    return "Vector2*";
                case "ImVec3":
                    return "Vector3";
                case "ImVec3*":
                    return "Vector3*";
                case "ImVec4":
                    return "Vector4";
                case "ImVec4*":
                    return "Vector4*";
                case "ImU8":
                    return "byte";
                case "ImU8*":
                    return "byte*";
                case "ImS8":
                    return "sbyte";
                case "ImS8*":
                    return "sbyte*";
                case "ImU16":
                case "ImWchar16":
                    return "ushort";
                case "ImU16*":
                    return "ushort*";
                case "ImS16":
                    return "short";
                case "ImS16*":
                    return "short*";
                case "unsigned int":
                case "ImU32":
                    return "uint";
                case "unsigned int*":
                case "ImU32*":
                    return "uint*";
                case "ImS32":
                    return "int";
                case "ImS32*":
                    return "int*";
                case "ImU64":
                    return "ulong";
                case "ImU64*":
                    return "ulong*";
                case "ImS64":
                    return "long";
                case "ImS64*":
                    return "long*";
                default:
                    return type;
            }
        }

        public static bool IsInPtr(string type)
        {
            switch (type)
            {
                case "ImGuiContext*":
                case "ImNodesContext*":
                case "ImPlotContext*":
                case "EditorContext*":
                case "ImNodesEditorContext*":
                case "ImNodesMiniMapNodeHoveringCallback":
                case "ImNodesMiniMapNodeHoveringCallbackUserData":
                    return true;
                default:
                    return false;
            }
        }

        public static bool SupportFixed(string type)
        {
            switch (type)
            {
                case "bool":
                case "byte":
                case "short":
                case "int":
                case "long":
                case "char":
                case "sbyte":
                case "ushort":
                case "uint":
                case "ulong":
                case "float":
                case "double":
                    return true;
                default:
                    return false;
            }
        }
    }
}
