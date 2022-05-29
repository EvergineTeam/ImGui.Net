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
                return result = "IntPtr";
            }

            result = ConvertToBasicTypes(result);

            return result;
        }

        private static string ConvertToBasicTypes(string type)
        {
            switch (type)
            {
                case "bool":
                    return "byte";
                case "ImU32":
                    return "uint";
                case "ImVec2":
                    return "Vector2";
                default:
                    return type;
            }
        }

        public static bool IsInPtr(string type)
        {
            switch (type)
            {
                case "ImGuiContext*":
                case "ImPlotContext*":
                case "EditorContext*":
                    return true;
                default:
                    return false;
            }
        }
    }
}
