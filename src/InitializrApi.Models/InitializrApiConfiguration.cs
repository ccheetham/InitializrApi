// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

namespace Steeltoe.InitializrApi.Models
{
    /// <summary>
    /// A model of an InitializrApi server configuration.
    /// </summary>
    public sealed class InitializrApiConfiguration
    {
        /// <summary>
        /// Gets or sets the configuration project metadata.
        /// </summary>
        public ProjectMetadata Metadata { get; set; }
    }
}