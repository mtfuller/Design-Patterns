using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLibrary
{
    class Singleton
    {
        private static readonly Singleton _instance = new Singleton();
        public static Singleton Instance {
            get {
                    return _instance;
                }
        }
        public Singleton()
        {

        }
    }
}
