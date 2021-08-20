
namespace KeyenceDataProcessing
{
    public interface IKeyenceReader
    {
        void KeyenceStart();
        void KeyenceStop();
        double[] KeyenceReadProfile();
    }
}
