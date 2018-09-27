﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Text;

namespace ReactiveUI.Fody.Helpers
{
    /// <summary>
    /// Attribute that marks a property as a Reactive Dependency.
    /// </summary>
    /// <seealso cref="System.Attribute" />
    [AttributeUsage(AttributeTargets.Property)]
    public class ReactiveDependencyAttribute : Attribute
    {
        private readonly string _targetName;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReactiveDependencyAttribute"/> class.
        /// </summary>
        /// <param name="targetName">Name of the target.</param>
        public ReactiveDependencyAttribute(string targetName)
        {
            _targetName = targetName;
        }

        /// <summary>
        /// The name of the backing property.
        /// </summary>
        public string Target => _targetName;

        /// <summary>
        /// Target property on the backing property.
        /// </summary>
        public string TargetProperty { get; set; }
    }
}
