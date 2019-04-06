﻿using System.Collections.Generic;

namespace Optivem.Platform.Core.Common.WebAutomation
{
    public interface ICheckBoxGroup<T>
    {
        void Select(T key);

        void Deselect(T key);

        List<T> GetSelected();

        bool HasSelected();

        int Count { get; }

        T GetValue(int index);
    }
}
