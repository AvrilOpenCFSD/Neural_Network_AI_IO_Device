
namespace OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth
{
    public class Execute
    {
// classes.

// registers.
        private OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.FileReader _FileReader;

// constructor.
        public Execute()
        {
            //System.Console.WriteLine("entered Execute.");
            Create_FileReader();
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
        public OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.FileReader Get_FileReader()
        {
            return _FileReader;
        }
    // set.

// private.
        private void Create_FileReader()
        {
            _FileReader = new OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.FileReader();
            while (Get_FileReader() == null) { }
        }
    // get.
    // set.
    }
}
