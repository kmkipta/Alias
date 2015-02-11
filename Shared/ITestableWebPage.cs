﻿using System;
using System.Collections.Generic;

namespace TestAutomation.Shared
{
    public interface ITestableWebPage : ITestableWebElement
    {
        void Open(Uri uri);
        void Open(string url);
        void Close();
        void Maximize();
        void ResetZoomLevel();
        string GetCurrentUrl();
    }
}
