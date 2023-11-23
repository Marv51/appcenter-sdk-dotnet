// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.


namespace Microsoft.AppCenter.Utils;

public static class WindowsHelper
{
    public static bool IsRunningAsWpf => false;

    public static bool IsRunningAsUwp => false;

    public static bool IsRunningAsWinUI => true;


    public static void GetScreenSize(out int width, out int height)
    {
        /*using (var graphics = Graphics.FromHwnd(IntPtr.Zero))
        {
            var desktop = graphics.GetHdc();
            width = GetDeviceCaps(desktop, DESKTOPHORZRES);
            height = GetDeviceCaps(desktop, DESKTOPVERTRES);
        }
        */
        width = 0;
        height = 0;
    }
}
