
namespace KeyenceDataProcessing
{
    public interface IKeyenceReader
    {
        void KeyenceStart();
        void KeyenceStop();
        KeyenceReaderData KeyenceReadProfile();
    }

    public class KeyenceReaderData
    {
        public double[] ProfileData = null;
        public double YStart = 0;
        public  double YPitch = 0;
    }
}
