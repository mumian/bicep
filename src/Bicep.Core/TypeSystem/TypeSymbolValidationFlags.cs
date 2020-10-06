// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;

namespace Bicep.Core.TypeSystem
{
    /// <summary>
    /// Flags that may be placed on type symbols to modify their behavior.
    /// </summary>
    [Flags]
    public enum TypeSymbolValidationFlags
    {
        /// <summary>
        /// The default.
        /// </summary>
        Default = 0,

        /// <summary>
        /// Display warning diagnostics instead of errors if there is a type mismatch.
        /// </summary>
        WarnOnTypeMismatch = 1 << 0,
    }
}