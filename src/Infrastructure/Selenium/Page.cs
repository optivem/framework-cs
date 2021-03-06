﻿using Atomiv.Core.Common.WebAutomation;

namespace Atomiv.Infrastructure.Selenium
{
    public class Page : PageObject<Driver>
    {
        public Page(Driver driver, string url, bool navigateTo)
            : base(driver)
        {
            if (navigateTo)
            {
                driver.Url = url;
            }

            Url = url;

            if (driver.Url != url)
            {
                throw new PageNotOpenException();
            }
        }

        public string Url { get; }
    }
}