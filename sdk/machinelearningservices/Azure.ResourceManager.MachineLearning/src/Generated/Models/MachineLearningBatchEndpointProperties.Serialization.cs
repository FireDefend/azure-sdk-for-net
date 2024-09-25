// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningBatchEndpointProperties : IUtf8JsonSerializable, IJsonModel<MachineLearningBatchEndpointProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningBatchEndpointProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningBatchEndpointProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningBatchEndpointProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningBatchEndpointProperties)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Defaults))
            {
                if (Defaults != null)
                {
                    writer.WritePropertyName("defaults"u8);
                    writer.WriteObjectValue(Defaults, options);
                }
                else
                {
                    writer.WriteNull("defaults");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
        }

        MachineLearningBatchEndpointProperties IJsonModel<MachineLearningBatchEndpointProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningBatchEndpointProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningBatchEndpointProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningBatchEndpointProperties(document.RootElement, options);
        }

        internal static MachineLearningBatchEndpointProperties DeserializeMachineLearningBatchEndpointProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BatchEndpointDefaults defaults = default;
            MachineLearningEndpointProvisioningState? provisioningState = default;
            string description = default;
            IDictionary<string, string> properties = default;
            Uri scoringUri = default;
            Uri swaggerUri = default;
            MachineLearningEndpointAuthMode authMode = default;
            MachineLearningEndpointAuthKeys keys = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defaults"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        defaults = null;
                        continue;
                    }
                    defaults = BatchEndpointDefaults.DeserializeBatchEndpointDefaults(property.Value, options);
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new MachineLearningEndpointProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        description = null;
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        properties = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("scoringUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        scoringUri = null;
                        continue;
                    }
                    scoringUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("swaggerUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        swaggerUri = null;
                        continue;
                    }
                    swaggerUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("authMode"u8))
                {
                    authMode = new MachineLearningEndpointAuthMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("keys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        keys = null;
                        continue;
                    }
                    keys = MachineLearningEndpointAuthKeys.DeserializeMachineLearningEndpointAuthKeys(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MachineLearningBatchEndpointProperties(
                description,
                properties ?? new ChangeTrackingDictionary<string, string>(),
                scoringUri,
                swaggerUri,
                authMode,
                keys,
                serializedAdditionalRawData,
                defaults,
                provisioningState);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("DefaultsDeploymentName", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  defaults: ");
                builder.AppendLine("{");
                builder.Append("    deploymentName: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(Defaults))
                {
                    builder.Append("  defaults: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Defaults, options, 2, false, "  defaults: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProvisioningState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  provisioningState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    builder.Append("  provisioningState: ");
                    builder.AppendLine($"'{ProvisioningState.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Description), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  description: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Description))
                {
                    builder.Append("  description: ");
                    if (Description.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Description}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Description}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Properties), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  properties: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Properties))
                {
                    if (Properties.Any())
                    {
                        builder.Append("  properties: ");
                        builder.AppendLine("{");
                        foreach (var item in Properties)
                        {
                            builder.Append($"    '{item.Key}': ");
                            if (item.Value == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Value.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("'''");
                                builder.AppendLine($"{item.Value}'''");
                            }
                            else
                            {
                                builder.AppendLine($"'{item.Value}'");
                            }
                        }
                        builder.AppendLine("  }");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ScoringUri), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  scoringUri: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ScoringUri))
                {
                    builder.Append("  scoringUri: ");
                    builder.AppendLine($"'{ScoringUri.AbsoluteUri}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SwaggerUri), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  swaggerUri: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SwaggerUri))
                {
                    builder.Append("  swaggerUri: ");
                    builder.AppendLine($"'{SwaggerUri.AbsoluteUri}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AuthMode), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  authMode: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  authMode: ");
                builder.AppendLine($"'{AuthMode.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Keys), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  keys: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Keys))
                {
                    builder.Append("  keys: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Keys, options, 2, false, "  keys: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<MachineLearningBatchEndpointProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningBatchEndpointProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningBatchEndpointProperties)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningBatchEndpointProperties IPersistableModel<MachineLearningBatchEndpointProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningBatchEndpointProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningBatchEndpointProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningBatchEndpointProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningBatchEndpointProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
