﻿#region License
/*
Copyright 2012 Rustici Software

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

   http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/
#endregion
using System;

namespace RusticiSoftware.TinCanAPILibrary.Exceptions
{
    /// <summary>
    /// Exception Class for validation errors.
    /// </summary>
    class ValidationException : Exception
    {
        /// <summary>
        /// Throws a ValidationException.
        /// </summary>
        public ValidationException() : base() { }
        /// <summary>
        /// Throws a ValidationException with the provided message.
        /// </summary>
        /// <param name="message">Message explaining the exception</param>
        public ValidationException(String message) : base(message) { }
    }
}
