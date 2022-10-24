using System;

namespace P01.Stream_Progress
{
    public class Program
    {
        static void Main()
        {
            Music music = new Music("", "", 1, 1);
            StreamProgressInfo spi = new StreamProgressInfo(music);
        }
    }
}
