﻿using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace Optivem.Platform.Infrastructure.Common.WebAutomation.Selenium
{
    public class BaseSeleniumElementRange
    {
        public BaseSeleniumElementRange(ReadOnlyCollection<IWebElement> elements)
        {
            Elements = elements;
        }

        public ReadOnlyCollection<IWebElement> Elements { get; private set; }
    }
}
