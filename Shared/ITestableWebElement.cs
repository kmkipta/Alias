﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Shared
{
    public interface ITestableWebElement : ISearchableWebObject
    {
        void Clear();
        void Type(string text);
        void Type(ITestableWebElement element, string text);
        void Click();
        void Click(ITestableWebElement element);
        string InnerHtml();
        ITestableWebElement Parent(int? levels = null);
    }
}
