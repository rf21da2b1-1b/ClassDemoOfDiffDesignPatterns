using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoOfDiffDesignPatterns.pattern.factory
{
    class DemoFactory
    {
        public static IDemoObject GetClass(FactoryType type)
        {
            if (type == FactoryType.Friendly)
            {
                return new FriendlyVersion();
            }
            else
            {
                return new PoliteVersion();
            }

        }
    }
}
