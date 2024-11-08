// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Extensions;

    /// <summary>
    /// Properties of an environment type. These properties can be updated after the resource has been created.
    /// </summary>
    public partial class EnvironmentTypeUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IEnvironmentTypeUpdateProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IEnvironmentTypeUpdatePropertiesInternal
    {

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>The display name of the environment type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Creates an new <see cref="EnvironmentTypeUpdateProperties" /> instance.</summary>
        public EnvironmentTypeUpdateProperties()
        {

        }
    }
    /// Properties of an environment type. These properties can be updated after the resource has been created.
    public partial interface IEnvironmentTypeUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.IJsonSerializable
    {
        /// <summary>The display name of the environment type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The display name of the environment type.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }

    }
    /// Properties of an environment type. These properties can be updated after the resource has been created.
    internal partial interface IEnvironmentTypeUpdatePropertiesInternal

    {
        /// <summary>The display name of the environment type.</summary>
        string DisplayName { get; set; }

    }
}