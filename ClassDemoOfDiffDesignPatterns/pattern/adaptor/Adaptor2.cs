using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoOfDiffDesignPatterns.pattern.adaptor
{
    class Adaptor2:IAdaptor
    {
        private DemoAdaptee2 _adap2;

        public Adaptor2()
        {
            _adap2 = new DemoAdaptee2();
        }
        public string Request(string str)
        {
            return _adap2.Upper(str);

        }
    }
}
