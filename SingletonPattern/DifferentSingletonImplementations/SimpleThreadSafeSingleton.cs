using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern.DifferentSingletonImplementations
{
    sealed class SimpleThreadSafeSingleton
    {
        private static SimpleThreadSafeSingleton instance = null;
        private static readonly object padlock = new object();

        SimpleThreadSafeSingleton()
        {
        }

        public static SimpleThreadSafeSingleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SimpleThreadSafeSingleton();
                    }
                    return instance;
                }
            }
        }
    }
}
