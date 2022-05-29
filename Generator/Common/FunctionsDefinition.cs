using System;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class FunctionsDefinition
    {
        public List<OverloadDefinition> Overloads = new List<OverloadDefinition>();

        public static FunctionsDefinition FromJson(JToken f)
        {
            FunctionsDefinition func = new FunctionsDefinition();

            foreach (var o in f.Values())
            {
                func.Overloads.Add(OverloadDefinition.FromJson(o));
            }

            return func;
        }
    }

    public class OverloadDefinition
    {
        public string FuncName;
        public string ReturnType;
        public List<Param> Params = new List<Param>();

        public static OverloadDefinition FromJson(JToken f)
        {
            OverloadDefinition overload = new OverloadDefinition();
            overload.FuncName = f["ov_cimguiname"].ToString();
            overload.ReturnType = f["ret"]?.ToString() ?? "void";

            foreach (var a in f["argsT"])
            {
                overload.Params.Add(Param.FromJson(a));
            }

            return overload;
        }

        public string GetParametersSignature(Specification spec)
        {
            StringBuilder signature = new StringBuilder();
            foreach (var p in Params)
            {
                string csType = Helpers.ConvertToCSharpType(p.Type, spec);
                signature.Append($"{csType} ");
                signature.Append($"{p.Name}, ");
            }

            if(signature.Length > 0)
                signature.Length -= 2;

            return signature.ToString();
        }
    }

    public class Param
    {
        public string Name;
        public string Type;

        public static Param FromJson(JToken elem)
        {
            Param p = new Param();
            p.Name = elem["name"].ToString();
            p.Type = elem["type"].ToString();

            return p;
        }
    }
}