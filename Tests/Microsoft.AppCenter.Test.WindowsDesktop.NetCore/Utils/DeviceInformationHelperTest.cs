// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using Microsoft.AppCenter.Utils;
using Xunit;

namespace Microsoft.AppCenter.Test.WindowsDesktop.Utils;

public partial class DeviceInformationHelperTesting
{
    /// <summary>
    /// Verify device oem name in device information
    /// </summary>
    [Fact]
    public async Task VerifyDeviceOemName()
    {
        var device = await Task.Run(() => new DeviceInformationHelper().GetDeviceInformationAsync());
        Assert.NotEqual(device.OemName, AbstractDeviceInformationHelper.DefaultSystemManufacturer);
    }

    /// <summary>
    /// Verify device model in device model.
    /// </summary>
    [Fact]
    public async Task VerifyDeviceModel()
    {
        var device = await Task.Run(() => new DeviceInformationHelper().GetDeviceInformationAsync());
        Assert.NotEqual(device.Model, AbstractDeviceInformationHelper.DefaultSystemProductName);
    }
}
