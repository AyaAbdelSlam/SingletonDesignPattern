using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern.DifferentSingletonImplementations
{
    class LazyInitiSingleton
    {
        private LazyInitiSingleton()
        {
        }

        public static LazyInitiSingleton Instance { get { return Nested.instance; } }

        private class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
            {
            }

            internal static readonly LazyInitiSingleton instance = new LazyInitiSingleton();
        }
    }
}
