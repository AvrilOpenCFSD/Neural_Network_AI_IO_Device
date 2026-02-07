
using System.ComponentModel;

namespace AvrilNNAI_OpenConcurrency_IO_Praise_Nth
{
    public class Global
    {
// definitions.
        public enum FILE_NAME
        {
            [Description("AvrilNNAI_OpenConcurrency_IO_Praise_Nth_OpenCFSD_Praise_0_IO.nnai")]
            PRAISE_0 = 0,
            [Description("AvrilNNAI_OpenConcurrency_IO_Praise_Nth_OpenCFSD_Praise_1_IO.nnai")]
            PRAISE_1 = 1,
            [Description("AvrilNNAI_OpenConcurrency_IO_Praise_Nth_OpenCFSD_Praise_2_IO.nnai")]
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
