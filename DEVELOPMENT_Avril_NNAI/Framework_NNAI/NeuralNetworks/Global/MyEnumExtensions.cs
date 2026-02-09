
using System.ComponentModel;

namespace OpenAvrilNNI
{
    public static class MyEnumExtensions
    {
// definitions.

// classes.

// constructor.

// destructor.

// public.
        public static string ToDescriptionString(OpenAvrilNNI.Global.FILE_NAME val)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val
               .GetType()
               .GetField(val.ToString())
               .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }
    // get.
    // set.

// private.
    // get.
    // set.
    }
}
