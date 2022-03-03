using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoOfDiffDesignPatterns.pattern.template
{
    class TamplateSub2: AbstractTemplateClass
    {
        protected override string MakeString(string s)
        {

            return " Peter was here " + s;
        }
    }
}
