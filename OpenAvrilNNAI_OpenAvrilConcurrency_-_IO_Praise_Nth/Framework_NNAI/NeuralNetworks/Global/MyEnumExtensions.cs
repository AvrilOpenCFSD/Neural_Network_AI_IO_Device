
using System.ComponentModel;

namespace OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth
{
    public static class MyEnumExtensions
    {
// definitions.

// classes.

// constructor.

// destructor.

// public.
        public static string ToDescriptionString(OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Global.FILE_NAME val)
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
