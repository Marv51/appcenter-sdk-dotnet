// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.

using Microsoft.AppCenter.Ingestion.Models;
using Newtonsoft.Json;

namespace Microsoft.AppCenter.Crashes.Ingestion.Models;

/// <summary>
/// Binary (library) definition for any platform.
/// </summary>
public partial class Binary
{
    /// <summary>
    /// Initializes a new instance of the Binary class.
    /// </summary>
    public Binary()
    {
        CustomInit();
    }

    /// <summary>
    /// Initializes a new instance of the Binary class.
    /// </summary>
    /// <param name="primaryArchitectureId">CPU primary
    /// architecture.</param>
    /// <param name="architectureVariantId">CPU architecture
    /// variant.</param>
    public Binary(string id, string startAddress, string endAddress, string name, string path, string? architecture = default(string), long? primaryArchitectureId = default(long?), long? architectureVariantId = default(long?))
    {
        Id = id;
        StartAddress = startAddress;
        EndAddress = endAddress;
        Name = name;
        Path = path;
        Architecture = architecture;
        PrimaryArchitectureId = primaryArchitectureId;
        ArchitectureVariantId = architectureVariantId;
        CustomInit();
    }

    /// <summary>
    /// An initialization method that performs custom operations like setting defaults
    /// </summary>
    partial void CustomInit();

    /// <summary>
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    [System.Text.Json.Serialization.JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// </summary>
    [JsonProperty(PropertyName = "startAddress")]
    [System.Text.Json.Serialization.JsonPropertyName("startAddress")]
    public string? StartAddress { get; set; }

    /// <summary>
    /// </summary>
    [JsonProperty(PropertyName = "endAddress")]
    [System.Text.Json.Serialization.JsonPropertyName("endAddress")]
    public string? EndAddress { get; set; }

    /// <summary>
    /// </summary>
    [JsonProperty(PropertyName = "name")]
    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// </summary>
    [JsonProperty(PropertyName = "path")]
    [System.Text.Json.Serialization.JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// </summary>
    [JsonProperty(PropertyName = "architecture")]
    [System.Text.Json.Serialization.JsonPropertyName("architecture")]
    public string? Architecture { get; set; }

    /// <summary>
    /// Gets or sets CPU primary architecture.
    /// </summary>
    [JsonProperty(PropertyName = "primaryArchitectureId")]
    [System.Text.Json.Serialization.JsonPropertyName("primaryArchitectureId")]
    public long? PrimaryArchitectureId { get; set; }

    /// <summary>
    /// Gets or sets CPU architecture variant.
    /// </summary>
    [JsonProperty(PropertyName = "architectureVariantId")]
    [System.Text.Json.Serialization.JsonPropertyName("architectureVariantId")]
    public long? ArchitectureVariantId { get; set; }

    /// <summary>
    /// Validate the object.
    /// </summary>
    /// <exception cref="ValidationException">
    /// Thrown if validation fails
    /// </exception>
    public virtual void Validate()
    {
        if (Id == null)
        {
            throw new ValidationException(ValidationException.Rule.CannotBeNull, "Id");
        }
        if (StartAddress == null)
        {
            throw new ValidationException(ValidationException.Rule.CannotBeNull, "StartAddress");
        }
        if (EndAddress == null)
        {
            throw new ValidationException(ValidationException.Rule.CannotBeNull, "EndAddress");
        }
        if (Name == null)
        {
            throw new ValidationException(ValidationException.Rule.CannotBeNull, "Name");
        }
        if (Path == null)
        {
            throw new ValidationException(ValidationException.Rule.CannotBeNull, "Path");
        }
    }
}
