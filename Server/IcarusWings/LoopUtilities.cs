using System;

namespace PEGASUS.IcarusWings
{
    // Normally in a namespace, of course.
    public class LoopUtilities
    {
        public static void Repeat(int count, Action action)
        {
            for (var i = 0; i < count; i++) action();
        }
    }
}