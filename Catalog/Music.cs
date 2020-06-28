using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog
{
    class Music : Item
    {
        private string singer;
        private int length;

        public Music(string singer, int length)
        {
            this.singer = singer;
            this.length = length;
        }
        public string GetSinger()
        {
            return singer;
        }
        public void SetSinger(string singer)
        {
            this.singer = singer;
        }
        public int GetLength()
        {
            return length;
        }
        public void SetLength(int length)
        {
            this.length = length;
        }
        public string Play()
        {
            return "";
        }
        public string RetrieveInformation()
        {
            return "";
        }
    }
}
