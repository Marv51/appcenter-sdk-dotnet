// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Microsoft.AppCenter;

public partial class WrapperSdk
{
    public string WrapperSdkVersion { get; private set; }

    public string WrapperSdkName { get; private set; }

    public string? WrapperRuntimeVersion { get; private set; }

    public string? LiveUpdateReleaseLabel { get; private set; }

    public string? LiveUpdateDeploymentKey { get; private set; }

    public string? LiveUpdatePackageHash { get; private set; }

    public WrapperSdk(string wrapperSdkName,
                      string wrapperSdkVersion,
                      string? wrapperRuntimeVersion = null,
                      string? liveUpdateReleaseLabel = null,
                      string? liveUpdateDeploymentKey = null,
                      string? liveUpdatePackageHash = null)
    {
        WrapperSdkName = wrapperSdkName;
        WrapperSdkVersion = wrapperSdkVersion;
        WrapperRuntimeVersion = wrapperRuntimeVersion;
        LiveUpdateReleaseLabel = liveUpdateReleaseLabel;
        LiveUpdateDeploymentKey = liveUpdateDeploymentKey;
        LiveUpdatePackageHash = liveUpdatePackageHash;
    }

    /// <summary>
    /// Name of SDK reported in logs.
    /// </summary>
    public const string Name = "appcenter.xamarin";

    /* We can't use reflection for assemblyInformationalVersion on iOS with "Link All" optimization. */
    internal const string Version = "5.0.4-SNAPSHOT";
}
