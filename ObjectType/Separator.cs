using System;

namespace GodotEngine
{
    /// <summary>
    /// Separator is a [Control] used for separating other controls. It's purely a visual decoration. Horizontal ([HSeparator]) and Vertical ([VSeparator]) versions are available.
    /// </summary>
    public class Separator : Control
    {
        private const string nativeName = "Separator";

        internal Separator() {}

        internal Separator(bool memoryOwn) : base(memoryOwn) {}
    }
}
