using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Common
{
    public static class CSCodeWriter
    {
        public static void WriteEnums(string outputPath, string @namespace, Specification spec)
        {
            if (spec.Enums.Count > 0)
            {
                using (StreamWriter file = File.CreateText(Path.Combine(outputPath, "Enums.cs")))
                {
                    file.WriteLine("using System;\n");
                    file.WriteLine($"namespace Evergine.Bindings.{@namespace}");
                    file.WriteLine("{");

                    foreach (var e in spec.Enums)
                    {
                        if (e.Type == EnumType.Bitmask)
                            file.WriteLine("\t[Flags]");

                        file.WriteLine($"\tpublic enum {e.Name}");
                        file.WriteLine("\t{");

                        if (!(e.Values.Exists(v => v.Value == 0)))
                        {
                            file.WriteLine("\t\tNone = 0,");
                        }

                        foreach (var member in e.Values)
                        {
                            file.WriteLine($"\t\t{member.Name} = {member.Value},");
                        }

                        file.WriteLine("\t}\n");
                    }

                    file.WriteLine("}");
                }
            }
        }

        public static void WriteStructs(string outputPath, string @namespace, Specification spec)
        {
            if (spec.Structs.Count > 0)
            {
                using (StreamWriter file = File.CreateText(Path.Combine(outputPath, "Structs.cs")))
                {
                    file.WriteLine("using System;");
                    file.WriteLine("using System.Runtime.InteropServices;\n");
                    file.WriteLine($"namespace Evergine.Bindings.{@namespace}");
                    file.WriteLine("{");

                    file.WriteLine("}\n");
                }
            }
        }

        public static void WriteFuntions(string outputPath, string @namespace, string libraryName, Specification spec)
        {
            if (spec.Funtions.Count > 0)
            {
                using (StreamWriter file = File.CreateText(Path.Combine(outputPath, "Funtions.cs")))
                {
                    file.WriteLine("using Evergine.Mathematics;");
                    file.WriteLine("using System;");
                    file.WriteLine("using System.Runtime.InteropServices;\n");
                    file.WriteLine($"namespace Evergine.Bindings.{@namespace}");
                    file.WriteLine("{");
                    file.WriteLine($"\tpublic static unsafe partial class {@namespace}Native");
                    file.WriteLine("\t{");

                    foreach (var c in spec.Funtions)
                    {
                        foreach (var o in c.Overloads)
                        {
                            string csType = Helpers.ConvertToCSharpType(o.ReturnType, spec);

                            file.WriteLine($"\t\t[DllImport(\"{libraryName}\", CallingConvention = CallingConvention.Cdecl)]");
                            file.WriteLine($"\t\tpublic static extern {csType} {o.FuncName}({o.GetParametersSignature(spec)});\n");
                        }
                    }

                    file.WriteLine("\t}");
                    file.WriteLine("}");
                }
            }
        }
    }
}
