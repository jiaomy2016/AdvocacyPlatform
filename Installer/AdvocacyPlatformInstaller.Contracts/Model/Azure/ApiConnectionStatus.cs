﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
namespace AdvocacyPlatformInstaller.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Model representing an API connection resource's connection status.
    /// </summary>
    public class ApiConnectionStatus
    {
        /// <summary>
        /// Gets or sets the connection status.
        /// </summary>
        public string Status { get; set; }
    }
}
