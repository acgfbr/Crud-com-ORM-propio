using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public static class PropertyValue
    {
        public static object GetPropertyValue(object o, string propertyName)
        {
            Type type = o.GetType();
            PropertyInfo info = type.GetProperty(propertyName);
            object value = info.GetValue(o, null);
            return value;
        }

        public static string getDisplayName(MemberInfo mi)
        {

            object[] atts = mi.GetCustomAttributes(typeof(DisplayAttribute), false);
            if (atts.Length != 0)
            {
                DisplayAttribute da = atts[0] as DisplayAttribute;
                return da.Name;
            }
            return string.Empty;
        }

        public static ToneAttribute getBaseAttribute(MemberInfo mi)
        {

           var atts = mi.GetCustomAttributes(typeof(ToneField), false);
            if (atts.Length != 0)
            {
                var da = atts[0] as ToneField;
                return da.AttributeType;
            }
            return ToneAttribute.None;
        }
    }
}
