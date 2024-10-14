using Common;
using System;

namespace ImguiGen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string outputPath = "..\\..\\..\\..\\Evergine.Bindings.ImGui\\Generated";

            string structs_and_enums_json = "Jsons/structs_and_enums.json";
            string definitions_json = "Jsons/definitions.json";
            string @namespace = "Imgui";
            string libraryName = "cimgui";

            var imguiVersion = Specification.FromFiles(structs_and_enums_json, definitions_json);

            if (imguiVersion != null)
            {
                // Enums
                CSCodeWriter.WriteEnums(outputPath, @namespace, imguiVersion);

                // Structs
                CSCodeWriter.WriteStructs(outputPath, @namespace, imguiVersion);

                // Functions
                CSCodeWriter.WriteFuntions(outputPath, @namespace, libraryName, imguiVersion);

                // Delegates
                CSCodeWriter.WriteInlineDelegates(outputPath, @namespace);
            }
        }
    }
}
