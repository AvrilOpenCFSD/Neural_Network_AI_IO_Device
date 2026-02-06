using System.ComponentModel;
using System.Text;

namespace Avril_NNAI
{
    public class FileReadWrite
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
        // classes.

        // constructor.
        public FileReadWrite()
        {

        }

// destructor.
        ~FileReadWrite() 
        {
        
        }

// public.
        public void WriteValues(Avril_NNAI.Framework_NNAI obj, Avril_NNAI.MachineAI objNNAI, string fileName)
        {
            using (var stream = File.Open(fileName, FileMode.Create))
            {
                using (var writer = new BinaryWriter(stream, Encoding.UTF8, false))
                {

                }
            }
        }

        public void ReadValues(Avril_NNAI.Framework_NNAI obj, Avril_NNAI.MachineAI objNNAI, string fileName)
        {
            float aspectRatio = (float)0.0;


            if (File.Exists(fileName))
            {
                using (var stream = File.Open(fileName, FileMode.Open))
                {
                    using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                    {

                    }
                }
                Console.WriteLine("Aspect ratio set to: " + aspectRatio);
            }
        }
    // get.

    // set.

// private.

    // get.

    // set.
    }
}
