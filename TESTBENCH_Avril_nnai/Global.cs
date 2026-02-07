
using System.ComponentModel;

namespace AvrilNNAI_OpenConcurrency_IO_Praise_Nth
{
    public class Global
    {
// definitions.
        public enum FILE_NAME
        {
            [Description("Avril_NNAI_OpenCFSD_Praise_0_IO.nnai")]
            PRAISE_0 = 0,
            [Description("Avril_NNAI_OpenCFSD_Praise_1_IO.nnai")]
            PRAISE_1 = 1,
            [Description("Avril_NNAI_OpenCFSD_Praise_2_IO.nnai")]
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
        public enum PraiseID : ulong
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
