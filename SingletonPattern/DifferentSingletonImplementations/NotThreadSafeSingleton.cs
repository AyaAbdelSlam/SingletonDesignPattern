using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern.DifferentSingletonImplementations
{
    sealed class NotThreadSafeSingleton
    {
        // Bad code! Do not use!
        private static NotThreadSafeSingleton instance = null;

        private NotThreadSafeSingleton()
        {
        }

        public static NotThreadSafeSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NotThreadSafeSingleton();
                }
                return instance;
            }
        }
        
    }
}
