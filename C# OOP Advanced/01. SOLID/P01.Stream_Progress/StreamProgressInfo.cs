namespace P01.Stream_Progress
{
    public class StreamProgressInfo
    {
        private IStreamable streamObj;

        // If we want to stream a music file, we can't
        public StreamProgressInfo(IStreamable streamObj)
        {
            this.streamObj = streamObj;
        }

        public int CalculateCurrentPercent()
        {
            return (this.streamObj.BytesSent * 100) / this.streamObj.Length;
        }
    }
}
