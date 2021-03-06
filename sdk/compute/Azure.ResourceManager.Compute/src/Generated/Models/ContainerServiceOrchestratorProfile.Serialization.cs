// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class ContainerServiceOrchestratorProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("orchestratorType");
            writer.WriteStringValue(OrchestratorType.ToSerialString());
            writer.WriteEndObject();
        }

        internal static ContainerServiceOrchestratorProfile DeserializeContainerServiceOrchestratorProfile(JsonElement element)
        {
            ContainerServiceOrchestratorTypes orchestratorType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("orchestratorType"))
                {
                    orchestratorType = property.Value.GetString().ToContainerServiceOrchestratorTypes();
                    continue;
                }
            }
            return new ContainerServiceOrchestratorProfile(orchestratorType);
        }
    }
}
