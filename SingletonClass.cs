using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public class Singleton
    {
        private static Singleton instance = null;
        private static object instanceLock = new object();
        private Singleton() 
        {
        }

        public static Singleton GetInstance() 
        {
            lock (instanceLock)
            {
                if (instance == null)
                    instance = new Singleton();

                return instance;
            }
        }

        public int Calculate(int a, int b)
        {
            return a + b;
        }
    }
}
