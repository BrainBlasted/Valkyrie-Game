using System;

namespace GodotEngine
{
    public class VideoStream : Resource
    {
        private const string nativeName = "VideoStream";

        internal VideoStream() {}

        internal VideoStream(bool memoryOwn) : base(memoryOwn) {}
    }
}
