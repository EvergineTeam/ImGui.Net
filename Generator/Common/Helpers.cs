using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public static class Helpers
    {
        public static string ConvertToCSharpType(string type, Family family = Family.field)
        {
            string result = type.Replace("const ", "");

            result = ConvertToBasicTypes(result, family);

            return result;
        }

        public enum Family
        {
            param,
            field,
            ret,
        }

        private static string ConvertToBasicTypes(string type, Family family)
        {
            if (type.StartsWith("bool(*)"))
                return "bool*";
            if (type.StartsWith("float(*)"))
                return "float*";

            switch (type)
            {
                case "char":
                case "unsigned char":
                    return "byte";
                case "bool":
                    switch (family)
                    {
                        case Family.param:
                            return "[MarshalAs(UnmanagedType.Bool)] bool";
                        case Family.ret:
                            return "bool";
                        case Family.field:
                        default:
                            return "byte";
                    }
                case "bool*":
                    switch (family)
                    {
                        case Family.param:
                            return "[MarshalAs(UnmanagedType.Bool)] bool";
                        case Family.ret:
                            return "bool";
                        case Family.field:
                        default:
                            return "byte*";
                    }
                case "char*":
                case "unsigned char*":
                    switch (family)
                    {
                        case Family.param:
                            return "[MarshalAs(UnmanagedType.LPStr)] string";
                        case Family.ret:
                            return "string";
                        case Family.field:
                        default:
                            return "byte*";
                    }
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
                case "unsigned short":
                case "ImWchar":
                case "ImDrawIdx":
                    return "ushort";
                case "ImU16*":
                case "ImDrawIdx*":
                case "ImWchar*":
                    return "ushort*";
                case "ImS16":
                    return "short";
                case "ImS16*":
                    return "short*";
                case "ImU32":
                case "unsigned int":
                case "ImGuiID":
                case "size_t":
                    return "uint";
                case "unsigned int*":
                case "ImU32*":
                case "size_t*":
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
                case "unsigned char**":
                    return "byte**";
                case "char* const[]":
                    switch (family)
                    {
                        case Family.param:
                            return "[MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr)] string[]";
                        case Family.ret:
                            return "string[]";
                        case Family.field:
                        default:
                            return "byte**";
                    }
                case "ImVector_ImDrawCmd":
                case "ImVector_ImDrawIdx":
                case "ImVector_ImDrawVert":
                case "ImVector_ImVec4":
                case "ImVector_ImTextureID":
                case "ImVector_ImVec2":
                case "ImVector_ImDrawChannel":
                case "ImVector_ImFontPtr":
                case "ImVector_ImFontAtlasCustomRect":
                case "ImVector_ImFontConfig":
                case "ImVector_ImWchar":
                case "ImVector_ImGuiStoragePair":
                case "ImVector_ImGuiTextRange":
                case "ImVector_char":
                case "ImVector_float":
                case "ImVector_ImFontGlyph":
                case "ImVector_ImU32":
                    return "ImVector";
                case "ImVector_ImWchar*":
                case "ImVector_ImGuiTextRange*":
                    return "ImVector*";
                case "ImGuiContext*":
                case "ImNodesContext*":
                case "ImPlotContext*":
                case "EditorContext*":
                case "ImNodesEditorContext*":
                case "ImNodesMiniMapNodeHoveringCallback":
                case "ImNodesMiniMapNodeHoveringCallbackUserData":
                case "ImDrawListSharedData*":
                case "ImTextureID":
                case "ImFontBuilderIO*":
                case "ImDrawCallback":
                case "ImGuiWindow*":
                case "ImGuiMemAllocFunc":
                case "ImGuiMemFreeFunc":
                    return "IntPtr";
                case "ImGuiMemAllocFunc*":
                case "ImGuiMemFreeFunc*":
                    return "IntPtr*";
                case "float[2]":
                case "ImVec2[2]":
                    return "Vector2*";
                case "float[3]":
                    return "Vector3*";
                case "float[4]":
                    return "Vector4*";
                case "int[2]":
                case "int[3]":
                case "int[4]":
                    return "int*";
                case "ImPlotFormatter":
                    return "void*";
                case "ImPlotGetter":
                    return "ImPlotPoint*";
                default:
                    return type;
            }
        }

        public static string ConvertDefault(string value, string type, Specification spec)
        {
            if (type.EndsWith("bool"))
                return value == "NULL" ? "false" : "true";

            if (spec.Enums.Exists(e => e.FrienlyName == type) && value != "0")
                return $"({type}) {value}";

            if (type == "ImGuiContext*" || type == "ImPlotContext" || type == "EditorContext*")
                return "IntPtr.Zero";

            if (value == "NULL")
                return "null";

            if (value.StartsWith("ImVec"))
                return null;

            return value;
        }

        public static string GetReturnTypeHeader(string csType)
        {
            switch (csType)
            {
                case "string":
                    return "[return:MarshalAs(UnmanagedType.LPStr)]";
                case "bool":
                    return "[return:MarshalAs(UnmanagedType.Bool)]";
                default:
                    return null;
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
