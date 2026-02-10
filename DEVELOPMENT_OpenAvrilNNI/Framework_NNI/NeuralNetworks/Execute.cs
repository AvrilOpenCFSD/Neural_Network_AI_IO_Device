
namespace OpenAvrilNNI
{
    public class Execute
    {
// classes.

// registers.
        private OpenAvrilNNI.FileReadWrite _FileReadWrite;

// constructor.
        public Execute()
        {
            //System.Console.WriteLine("entered Execute.");
            Create_FileReadWrite(new OpenAvrilNNI.FileReadWrite());
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
        public OpenAvrilNNI.FileReadWrite Get_FileReadWrite()
        {
            return _FileReadWrite;
        }
    // set.

// private.
        private void Create_FileReadWrite(OpenAvrilNNI.FileReadWrite fileReadWrite)
        {
            _FileReadWrite = fileReadWrite;
        }
    // get.
    // set.
    }
}
