using System;
using System.Collections.Generic;
using System.Text;

namespace P01.Stream_Progress
{
    public class StreamProgressInfo
    {
        private File file;
        private IStreamProgress istreamProgress;
      

        public StreamProgressInfo(IStreamProgress istreamProgress)
        {
            this.istreamProgress = istreamProgress;
        }

        public int CalculateCurrentPercent()
        {
            return (this.istreamProgress.BytesSent * 100) / this.istreamProgress.Length;
        }
    }
}
