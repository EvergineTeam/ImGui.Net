using System;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class FunctionsDefinition
    {
        public List<OverloadDefinition> Overloads = new List<OverloadDefinition>();

        public static FunctionsDefinition FromJson(JToken f, Specification spec)
        {
            FunctionsDefinition func = new FunctionsDefinition();

            foreach (var o in f.Values())
            {
                // Skip internal functions
                string location = o["location"]?.ToString();
                string funcname = o["funcname"]?.ToString();
                if (!string.IsNullOrEmpty(location) && location.Contains("internal")
                    || string.IsNullOrEmpty(funcname))
                    continue;

                string typename = o["stname"]?.ToString();
                if (!string.IsNullOrEmpty(typename))
                {
                    if (!spec.Structs.Any(x => x.Name == typename))
                        return null;
                }

                func.Overloads.Add(OverloadDefinition.FromJson(o));
            }

            return func.Overloads.Count == 0 ? null : func;
        }
    }

    public class OverloadDefinition
    {
        public string FuncName;
        public string ReturnType;
        public string Signature;
        public bool IsConstructor;
        public bool IsDestructor;
        public List<Param> Params = new List<Param>();
        public Dictionary<string, string> Defaults = new Dictionary<string, string>();

        public static OverloadDefinition FromJson(JToken f)
        {
            OverloadDefinition overload = new OverloadDefinition();
            overload.FuncName = f["ov_cimguiname"].ToString();
            overload.ReturnType = f["ret"]?.ToString() ?? "void";
            overload.Signature = f["signature"]?.ToString();
            overload.IsConstructor = f.Value<bool>("constructor");
            overload.IsDestructor = f.Value<bool>("destructor");

            foreach (var a in f["argsT"])
            {
                overload.Params.Add(Param.FromJson(a));
            }

            foreach (var d in f["defaults"])
            {
                overload.Defaults.Add(((JProperty)d).Name.ToString(), ((JProperty)d).Value.ToString());
            }

            return overload;
        }

        public string GetParametersSignature(bool writeType = true, bool avoidSelfpOut = false, bool pOutAddress = false)
        {
            StringBuilder signature = new StringBuilder();
            foreach (var p in Params)
            {
                if (p.Name == "...")
                    continue;

                if (avoidSelfpOut && (p.Name == "self" || p.Name == "pOut"))
                    continue;


                if (writeType)
                {
                    string csType = Helpers.ConvertToCSharpType(p.Type, Helpers.Family.param);
                    signature.Append($"{csType} ");
                }

                string address = pOutAddress && p.Name == "pOut" ? "&" : "";
                signature.Append($"{address}{p.Name}, ");
            }

            if(signature.Length > 0)
                signature.Length -= 2;

            return signature.ToString();
        }

        public Param HasOut()
        {
            return Params.Find(p => p.Name == "pOut");
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

            if (p.Name == "out" ||
                p.Name == "in" ||
                p.Name == "ref")
                p.Name = "@" + p.Name;

            p.Type = elem["type"].ToString();

            return p;
        }
    }
}