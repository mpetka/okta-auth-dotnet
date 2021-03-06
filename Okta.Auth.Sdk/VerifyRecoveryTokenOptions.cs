﻿// <copyright file="VerifyRecoveryTokenOptions.cs" company="Okta, Inc">
// Copyright (c) 2018 - present Okta, Inc. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.
// </copyright>

namespace Okta.Auth.Sdk
{
    /// <summary>
    /// This class contains all the request parameters for performing a verify recovery token request
    /// </summary>
    public class VerifyRecoveryTokenOptions
    {
        /// <summary>
        /// Gets or sets the recovery token
        /// </summary>
        /// <value>The recovery token</value>
        public string RecoveryToken { get; set; }
    }
}
