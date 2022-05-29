using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Common
{
    public enum EnumType
    {
        Enum,
        Bitmask,
    }

    public class EnumDefinition
    {
        public string Name;
        public string FrienlyName;
        public EnumType Type;
        public List<EnumValue> Values = new List<EnumValue>();

        internal static EnumDefinition FromJson(JProperty t)
        {
            EnumDefinition newEnum = new EnumDefinition();
            newEnum.Name = t.Name;
            newEnum.FrienlyName = t.Name.EndsWith("_") ? t.Name.Substring(0, t.Name.Length - 1) : t.Name;
            newEnum.Type = t.Name.Contains("flags") ? EnumType.Bitmask : EnumType.Enum;

            foreach (var v in t.Values())
            {
                newEnum.Values.Add(EnumValue.FromJson(v));
            }
            
            return newEnum;
        }
    }

    public class EnumValue
    {
        public string Name;
        public string Alias;
        public int Value;

        internal static EnumValue FromJson(JToken v)
        {
            EnumValue newValue= new EnumValue();
            newValue.Name = v["name"].ToString();
            string stringValue = v["calc_value"].ToString();
            newValue.Value = int.Parse(stringValue);

            return newValue;
        }
    }
}