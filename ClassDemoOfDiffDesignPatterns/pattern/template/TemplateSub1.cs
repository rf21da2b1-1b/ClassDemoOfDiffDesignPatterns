using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoOfDiffDesignPatterns.pattern.template
{
    class TemplateSub1 : AbstractTemplateClass
    {
        protected override string MakeString(string s)
        {
            return "Dette er template 1 " + s;
        }
    }
}
