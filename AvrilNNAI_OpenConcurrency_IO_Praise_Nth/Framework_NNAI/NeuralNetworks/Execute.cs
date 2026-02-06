
namespace Avril_NNAI
{
    public class Execute
    {
// classes.

// registers.
        private Avril_NNAI.FileReadWrite _FileReadWrite;

// constructor.
        public Execute()
        {
            //System.Console.WriteLine("entered Execute.");
            Create_FileReadWrite(new Avril_NNAI.FileReadWrite());
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
        public Avril_NNAI.FileReadWrite Get_FileReadWrite()
        {
            return _FileReadWrite;
        }
    // set.

// private.
        private void Create_FileReadWrite(Avril_NNAI.FileReadWrite fileReadWrite)
        {
            _FileReadWrite = fileReadWrite;
        }
    // get.
    // set.
    }
}
