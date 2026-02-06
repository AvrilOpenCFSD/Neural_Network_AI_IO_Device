
namespace Avril_NNAI
{
    public class Execute
    {
// classes.

// registers.
        private Avril_NNAI.FileRead _FileReadWrite;

// constructor.
        public Execute()
        {
            //System.Console.WriteLine("entered Execute.");
            Create_FileRead(new Avril_NNAI.FileRead());
            while (Get_FileRead() == null) { }
        }

// destructor.
        ~Execute()
        {

        }

// public.

    // get.
        public Avril_NNAI.FileRead Get_FileRead()
        {
            return _FileReadWrite;
        }
    // set.

// private.
        private void Create_FileRead(Avril_NNAI.FileRead fileReadWrite)
        {
            _FileReadWrite = fileReadWrite;
        }
    // get.
    // set.
    }
}
