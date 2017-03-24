// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Network;
    using Microsoft.Azure.Management.Network.Fluent;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Parameters that define the resource to query the troubleshooting
    /// result.
    /// </summary>
    public partial class QueryTroubleshootingParameters
    {
        /// <summary>
        /// Initializes a new instance of the QueryTroubleshootingParameters
        /// class.
        /// </summary>
        public QueryTroubleshootingParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QueryTroubleshootingParameters
        /// class.
        /// </summary>
        /// <param name="targetResourceId">The target resource ID to query the
        /// troubleshooting result.</param>
        public QueryTroubleshootingParameters(string targetResourceId)
        {
            TargetResourceId = targetResourceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the target resource ID to query the troubleshooting
        /// result.
        /// </summary>
        [JsonProperty(PropertyName = "targetResourceId")]
        public string TargetResourceId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TargetResourceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TargetResourceId");
            }
        }
    }
}
