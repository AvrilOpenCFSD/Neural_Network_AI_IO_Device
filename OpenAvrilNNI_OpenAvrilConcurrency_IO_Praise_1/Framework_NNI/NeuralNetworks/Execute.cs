
namespace OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1
{
    public class Execute
    {
// classes.

// registers.
        private FileReadWrite _FileReadWrite;

// constructor.
        public Execute()
        {
            //System.Console.WriteLine("entered Execute.");
            Create_FileReadWrite(new FileReadWrite());
            while (Get_FileReadWrite() == null) { }
        }

// destructor.
        ~Execute()
        {

        }

// public.
        public void Create_And_Run_UI()
        {

        }
    // get.
        public FileReadWrite Get_FileReadWrite()
        {
            return _FileReadWrite;
        }
    // set.

// private.
        private void Create_FileReadWrite(FileReadWrite fileReadWrite)
        {
            _FileReadWrite = fileReadWrite;
        }
    // get.
    // set.
    }
}
