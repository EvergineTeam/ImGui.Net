﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
                    file.WriteLine("using Evergine.Mathematics;");
                    file.WriteLine("using Evergine.Bindings.Imgui;");
                    file.WriteLine("using System;\n");
                    file.WriteLine($"namespace Evergine.Bindings.{@namespace}");
                    file.WriteLine("{");

                    foreach (var e in spec.Enums)
                    {
                        if (e.Type == EnumType.Bitmask)
                            file.WriteLine("\t[Flags]");

                        file.WriteLine($"\tpublic enum {e.FrienlyName}");
                        file.WriteLine("\t{");

                        if (!(e.Values.Exists(v => v.Value == 0)))
                        {
                            file.WriteLine("\t\tNone = 0,");
                        }

                        foreach (var member in e.Values)
                        {
                            file.WriteLine($"\t\t{member.FriendlyName} = {member.Value},");
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
                    file.WriteLine("using Evergine.Mathematics;");
                    file.WriteLine("using Evergine.Bindings.Imgui;");
                    file.WriteLine("using System;");
                    file.WriteLine("using System.Runtime.InteropServices;");
                    file.WriteLine("using System.Runtime.CompilerServices;\n");
                    file.WriteLine($"namespace Evergine.Bindings.{@namespace}");
                    file.WriteLine("{");

                    foreach (var structure in spec.Structs)
                    {
                        file.WriteLine($"\tpublic unsafe partial struct {structure.Name}");
                        file.WriteLine("\t{");

                        foreach (var member in structure.Members)
                        {
                            string csType = Helpers.ConvertToCSharpType(member.Type);

                            if (member.Count > 0)
                            {
                                if (Helpers.SupportFixed(csType))
                                {
                                    file.WriteLine($"\t\tpublic fixed {csType} {member.Name}[{member.Count}];");
                                }
                                else
                                {
                                    for (int i = 0; i < member.Count; i++)
                                    {
                                        file.WriteLine($"\t\tpublic {csType} {member.Name}_{i};");
                                    }
                                }
                            }
                            else
                            {
                                file.WriteLine($"\t\tpublic {csType} {member.Name};");
                            }
                        }


                        //Write Selft pointer
                        file.WriteLine($"\n\t\tpublic {structure.Name}* self => ({structure.Name}*)Unsafe.AsPointer(ref this);\n");

                        // Write Methods
                        foreach (var m in spec.Funtions)
                        {
                            foreach (var o in m.Overloads)
                            {
                                if (o.FuncName.StartsWith($"{structure.Name}_"))
                                {
                                    // Remove var_list functions
                                    if (o.Signature.Contains("va_list"))
                                        continue;

                                    //Jump Constructs
                                    if (o.IsConstructor || o.IsDestructor)
                                        continue;

                                    file.WriteLine();

                                    int underLineIndex = o.FuncName.IndexOf('_') + 1;
                                    string simpleFuncName = o.FuncName.Substring(underLineIndex);
                                    string csType = Helpers.ConvertToCSharpType(o.ReturnType, Helpers.Family.ret);
                                    string returncall = csType != "void" ? "return " : "";

                                    Param param = o.HasOut();
                                    if (param != null)
                                    {
                                        csType = Helpers.ConvertToCSharpType(param.Type.Trim('*'), Helpers.Family.ret);
                                    }

                                    file.WriteLine($"\t\tpublic {csType} {simpleFuncName}({o.GetParametersSignature(true, true)})");
                                    file.WriteLine("\t\t{");

                                    if (param != null) file.WriteLine($"\t\t\t{csType} pOut;");

                                    file.WriteLine($"\t\t\t{returncall}{@namespace}Native.{o.FuncName}({o.GetParametersSignature(false, false, true)});");

                                    if (param != null) file.WriteLine("\n\t\t\treturn pOut;");

                                    file.WriteLine("\t\t}");
                                }
                            }
                        }

                        file.WriteLine("\t}\n");
                    }

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
                    file.WriteLine("using Evergine.Bindings.Imgui;");
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
                            // Remove var_list functions
                            if (o.Signature.Contains("va_list"))
                                continue;

                            //Jump Constructs
                            if (o.IsConstructor || o.IsDestructor)
                                continue;

                            file.WriteLine($"\t\t[DllImport(\"{libraryName}\", CallingConvention = CallingConvention.Cdecl)]");

                            string csType = Helpers.ConvertToCSharpType(o.ReturnType, Helpers.Family.ret);
                            string returnHeader = Helpers.GetReturnTypeHeader(csType);
                            if(!string.IsNullOrEmpty(returnHeader))
                                file.WriteLine($"\t\t{returnHeader}");

                            file.WriteLine($"\t\tpublic static extern {csType} {o.FuncName}({o.GetParametersSignature()});\n");
                        }
                    }

                    file.WriteLine("\t}");
                    file.WriteLine("}");
                }
            }
        }
    }
}
