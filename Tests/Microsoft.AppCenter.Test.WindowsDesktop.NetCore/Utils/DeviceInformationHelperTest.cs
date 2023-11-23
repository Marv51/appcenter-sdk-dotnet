// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Management;
using System.Threading.Tasks;
using Microsoft.AppCenter.Utils;
using Xunit;

namespace Microsoft.AppCenter.Test.WindowsDesktop.Utils;

public partial class DeviceInformationHelperTest
{
    /// <summary>
    /// Verify sdk name in device information.
    /// </summary>
    [Fact]
    public async Task VerifySdkName()
    {
        var device = await Task.Run(() => new DeviceInformationHelper().GetDeviceInformationAsync());
        Assert.Equal("appcenter.winui", device.SdkName);
    }

    /// <summary>
    /// Verify that sdk is not crashed during getting device info when management class is not available.
    /// </summary>
    [Fact]
    public async Task VerifyDeviceInfoWhenManagementClassNotAvailable()
    {
        var deviceInformation = new DeviceInformationHelper();
        var factory = new MockManagementClassFactory();
        deviceInformation.SetManagementClassFactory(factory);
        var device = await Task.Run(deviceInformation.GetDeviceInformationAsync);
    }
}

/// <summary>
/// Fake class for ManagementClassFactory.
/// </summary>
class MockManagementClassFactory : IManagmentClassFactory
{
    public ManagementClass GetComputerSystemClass()
    {
        throw new UnauthorizedAccessException();
    }

    public ManagementClass GetOperatingSystemClass()
    {
        throw new UnauthorizedAccessException();
    }
}
