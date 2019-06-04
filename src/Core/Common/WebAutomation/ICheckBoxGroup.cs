﻿using System.Collections.Generic;

namespace Optivem.Core.Common.WebAutomation
{
    public interface ICheckBoxGroup
    {
        void SelectValue(string key);

        void DeselectValue(string key);

        List<string> ReadSelectedValues();

        bool HasSelected();

        int Count { get; }

        string ReadValue(int index);
    }

    public interface ICheckBoxGroup<T> : ICheckBoxGroup
    {
        void Select(T key);

        void Deselect(T key);

        List<T> ReadSelected();

        T Read(int index);
    }
}