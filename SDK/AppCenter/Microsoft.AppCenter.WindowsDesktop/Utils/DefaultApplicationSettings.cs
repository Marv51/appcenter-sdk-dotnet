// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Diagnostics.CodeAnalysis;
using Windows.Storage;

namespace Microsoft.AppCenter.Utils;

public class DefaultApplicationSettings : IApplicationSettings
{
    public T? GetValue<T>(string key, T? defaultValue = default(T))
    {
        try
        {
            var found = ApplicationData.Current.LocalSettings.Values.TryGetValue(key, out var result);

            if (found)
            {
                if (result is null)
                {
                    return default;
                }
                return (T)result;
            }
        }
        catch (InvalidOperationException)
        {

        }
        return defaultValue;
    }

    public void SetValue(string key, object? value)
    {
        try
        {
            ApplicationData.Current.LocalSettings.Values[key] = value;
        }
        catch (InvalidOperationException)
        {

        }
    }

    public bool ContainsKey(string key)
    {
        return ApplicationData.Current.LocalSettings.Values.ContainsKey(key);
    }

    public void Remove(string key)
    {
        ApplicationData.Current.LocalSettings.Values.Remove(key);
    }
}
