using System;
using Common;

namespace ImnodesGen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string outputPath = "..\\..\\..\\..\\Evergine.Bindings.Imgui\\Imnodes";

            string structs_and_enums_json = "Jsons/structs_and_enums.json";
            string definitions_json = "Jsons/definitions.json";
            string @namespace = "Imnodes";
            string libraryName = "cimgui";

            var imnodesVersion = Specification.FromFiles(structs_and_enums_json, definitions_json);

            if (imnodesVersion != null)
            {
                // Enums
                CSCodeWriter.WriteEnums(outputPath, @namespace, imnodesVersion);

                // Structs
                CSCodeWriter.WriteStructs(outputPath, @namespace, imnodesVersion);

                // Functions
                CSCodeWriter.WriteFuntions(outputPath, @namespace, libraryName, imnodesVersion);
            }
        }
    }
}
