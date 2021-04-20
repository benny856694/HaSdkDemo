using System;

namespace HaSdkWrapper
{
    public class VideoParmReceivedArgs : EventArgs
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public VideoParmReceivedArgs(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}