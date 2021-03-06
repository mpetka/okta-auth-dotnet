﻿// <copyright file="UserAgentHelper.cs" company="Okta, Inc">
// Copyright (c) 2018 - present Okta, Inc. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.
// </copyright>

using System;
using System.Reflection;

namespace Okta.Sdk.Abstractions
{
    public static class UserAgentHelper
    {
        public static Version SdkVersion
        {
            get { return typeof(BaseOktaClient).GetTypeInfo().Assembly.GetName().Version; }
        }
    }
}
