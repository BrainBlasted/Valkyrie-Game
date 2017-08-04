using System;

namespace GodotEngine
{
    /// <summary>
    /// Base class for audio streams. Audio streams are used for music playback, or other types of streamed sounds that don't fit or require more flexibility than a [Sample].
    /// </summary>
    public class AudioStream : Resource
    {
        private const string nativeName = "AudioStream";

        internal AudioStream() {}

        internal AudioStream(bool memoryOwn) : base(memoryOwn) {}
    }
}
