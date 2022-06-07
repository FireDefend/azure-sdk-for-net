// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class CentralServerVmDetails
    {
        internal static CentralServerVmDetails DeserializeCentralServerVmDetails(JsonElement element)
        {
            Optional<CentralServerVirtualMachineType> type = default;
            Optional<ResourceIdentifier> virtualMachineId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new CentralServerVirtualMachineType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("virtualMachineId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    virtualMachineId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new CentralServerVmDetails(Optional.ToNullable(type), virtualMachineId.Value);
        }
    }
}
