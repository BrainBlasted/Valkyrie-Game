using System;

namespace GodotEngine
{
    public class Shape : Resource
    {
        private const string nativeName = "Shape";

        internal Shape() {}

        internal Shape(bool memoryOwn) : base(memoryOwn) {}
    }
}
