using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern.DifferentSingletonImplementations
{
    sealed class DoubleCheckLocingSingleton
    {
        // Bad Code, Dont use
        private static DoubleCheckLocingSingleton instance = null;
        private static readonly object padlock = new object();

        DoubleCheckLocingSingleton()
        {
        }

        public static DoubleCheckLocingSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new DoubleCheckLocingSingleton();
                        }
                    }
                }
                return instance;
            }
        }
    }
}
