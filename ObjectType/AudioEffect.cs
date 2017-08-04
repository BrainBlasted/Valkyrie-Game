using System;

namespace GodotEngine
{
    public class AudioEffect : Resource
    {
        private const string nativeName = "AudioEffect";

        internal AudioEffect() {}

        internal AudioEffect(bool memoryOwn) : base(memoryOwn) {}
    }
}
