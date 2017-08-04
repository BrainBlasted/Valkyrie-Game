using System;

namespace GodotEngine
{
    public class ResourceImporter : Reference
    {
        private const string nativeName = "ResourceImporter";

        internal ResourceImporter() {}

        internal ResourceImporter(bool memoryOwn) : base(memoryOwn) {}
    }
}
