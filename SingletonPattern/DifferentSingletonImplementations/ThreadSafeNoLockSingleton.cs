using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern.DifferentSingletonImplementations
{
    sealed class ThreadSafeNoLockSingleton
    {
        private static readonly ThreadSafeNoLockSingleton instance = new ThreadSafeNoLockSingleton();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static ThreadSafeNoLockSingleton()
        {
        }

        private ThreadSafeNoLockSingleton()
        {
        }

        public static ThreadSafeNoLockSingleton Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
