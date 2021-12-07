using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpPratice
{
    class MixMatch
    {
        public string top;
        public string bottom;
        public string shoes;
        public static int video_count = 0;

        public MixMatch(string top,string bottom,string shoes)
        {
            this.top = top;
            this.bottom = bottom;
            this.shoes = shoes;
            video_count++;
        }

        public int getVideoCount()
        {
            return video_count;
        }
    }
}
