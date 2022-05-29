using Newtonsoft.Json;
using System;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using Common;

namespace ImguizmoGen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string outputPath = "..\\..\\..\\..\\Evergine.Bindings.Imguizmo\\Generated";

            string structs_and_enums_json = "Jsons/structs_and_enums.json";
            string definitions_json = "Jsons/definitions.json";
            string @namespace = "Imguizmo";
            string libraryName = "cimguizmo";

            var imguizmoVersion = Specification.FromFiles(structs_and_enums_json, definitions_json);

            if (imguizmoVersion != null)
            {
                // Enums
                CSCodeWriter.WriteEnums(outputPath, @namespace, imguizmoVersion);

                // Structs
                CSCodeWriter.WriteStructs(outputPath, @namespace, imguizmoVersion);

                // Functions
                CSCodeWriter.WriteFuntions(outputPath, @namespace, libraryName, imguizmoVersion);
            }
        }
    }
}