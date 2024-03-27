// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Microsoft.AppCenter.Ingestion.Models.Serialization;


[JsonSourceGenerationOptions(WriteIndented = true, 
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
[JsonSerializable(typeof(LogContainer))]
[JsonSerializable(typeof(Log))]
internal partial class SourceGenerationContext : JsonSerializerContext
{
}


public static class STJLogSerializer
{
    //internal static readonly JsonSerializerSettings SerializationSettings;
    private static readonly LogJsonConverter Converter = new LogJsonConverter();

    static STJLogSerializer()
    {
        /*SerializationSettings = new JsonSerializerSettings
        {
            Formatting = Formatting.Indented,
            DateFormatHandling = DateFormatHandling.IsoDateFormat,
            DateTimeZoneHandling = DateTimeZoneHandling.Utc,
            NullValueHandling = NullValueHandling.Ignore,
            ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            Converters = { Converter }
        };*/
    }

    public static void AddLogType(string typeName, Type type)
    {
        Converter.AddLogType(typeName, type);
    }

    public static string Serialize(LogContainer logContainer)
    {
        return JsonSerializer.Serialize(logContainer, SourceGenerationContext.Default.LogContainer);
    }

    public static string Serialize(Log log)
    {
        return JsonSerializer.Serialize(log, SourceGenerationContext.Default.Log);
    }

    public static Log? DeserializeLog(string json)
    {
        return JsonSerializer.Deserialize(json, SourceGenerationContext.Default.Log);
    }
}
