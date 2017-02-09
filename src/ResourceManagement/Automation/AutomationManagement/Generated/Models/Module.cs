// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// Definition of the module type.
    /// </summary>
    public partial class Module : ResourceBase
    {
        private ModuleProperties _properties;
        
        /// <summary>
        /// Optional. Gets or sets the module properties.
        /// </summary>
        public ModuleProperties Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Module class.
        /// </summary>
        public Module()
        {
        }
    }
}
