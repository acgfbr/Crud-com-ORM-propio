using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public enum ToneAttribute
    {
        None,
        Check,
        Button,
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class ToneField : Attribute
    {
        public ToneAttribute AttributeType { get; set; }
        public ToneField(ToneAttribute attributeType = ToneAttribute.None)
        {
            this.AttributeType = attributeType;
        }
    }

}
