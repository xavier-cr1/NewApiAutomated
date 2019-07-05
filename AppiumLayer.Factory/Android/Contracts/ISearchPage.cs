﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AppiumLayer.Factory.Android.Contracts
{
    public interface ISearchPage
    {
        void UseSearch(string text);

        bool AllEntrancesContainsTheCorrectTag(string tag);
    }
}
