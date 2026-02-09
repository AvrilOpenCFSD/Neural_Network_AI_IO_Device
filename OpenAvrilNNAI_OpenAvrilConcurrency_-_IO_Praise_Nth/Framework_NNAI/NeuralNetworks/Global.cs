
using System.ComponentModel;

namespace OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth
{
    public class Global
    {
// definitions.
        public enum FILE_NAME : byte
        {
            [Description("OpenAvrilNNI_OpenCFSD_Praise_0_IO.nni")]
            PRAISE_0 = 0,
            [Description("OpenAvrilNNI_OpenCFSD_Praise_1_IO.nni")]
            PRAISE_1 = 1,
            [Description("OpenAvrilNNI_OpenCFSD_Praise_2_IO.nni")]
            PRAISE_2 = 2
        }
        public enum NodeLayer : byte
        {
            Layer_4 = 4,
            Layer_3 = 3,
            Layer_2 = 2,
            Layer_1 = 1,
            Layer_0 = 0,
        }
        public enum PraiseID : byte
        {
            Praise_0 = 0,
            Praise_1 = 1,
            Praise_2 = 2
        }
        public enum PRAISE_1 : byte
        {
            Mouse_Screen_X,
            Mouse_Screen_Y,
            Capsule_Fowards_X,
            Capsule_Fowards_Y,
            Capsule_Fowards_Z,
            Capsule_Right_X,
            Capsule_Right_Y,
            Capsule_Right_Z,
            Capsule_Up_X,
            Capsule_Up_Y,
            Capsule_Up_Z,
        }

// classes.

// registers.

// constructor.
        public Global()
        {
            System.Console.WriteLine("entered Global.");
        }

// destructor
        ~Global()
        {
            //System.Console.WriteLine("exited Global.");
        }

// public.
    // get.
    // set.

// private.
    // get.
    // set.
    }
}
