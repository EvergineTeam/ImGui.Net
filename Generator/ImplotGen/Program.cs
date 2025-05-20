using System;
using Common;

namespace ImplotGen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string outputPath = "..\\..\\..\\..\\Evergine.Bindings.Imgui\\Implot";

            string structs_and_enums_json = "Jsons/structs_and_enums.json";
            string definitions_json = "Jsons/definitions.json";
            string @namespace = "Implot";
            string libraryName = "cimgui";

            var implotVersion = Specification.FromFiles(structs_and_enums_json, definitions_json);

            if (implotVersion != null)
            {
                // Enums
                CSCodeWriter.WriteEnums(outputPath, @namespace, implotVersion);

                // Structs
                CSCodeWriter.WriteStructs(outputPath, @namespace, implotVersion);

                // Functions
                CSCodeWriter.WriteFuntions(outputPath, @namespace, libraryName, implotVersion);
            }
        }
    }
}
