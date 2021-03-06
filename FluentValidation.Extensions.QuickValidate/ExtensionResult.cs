﻿using System.Collections.Generic;
using FluentValidation.Results;

//Copyright 2017 Baldric Lothbrok

//Licensed under the Apache License, Version 2.0 (the "License");
//you may not use this file except in compliance with the License.
//You may obtain a copy of the License at

//http://www.apache.org/licenses/LICENSE-2.0

//Unless required by applicable law or agreed to in writing, software
//distributed under the License is distributed on an "AS IS" BASIS,
//WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//See the License for the specific language governing permissions and
//limitations under the License.

namespace FluentValidation.Extensions.QuickValidate
{
    /// <summary>
    /// Class that contains the result from the validation
    /// Inherited from FluentValidation framework
    /// </summary>
    public class ExtensionResult
    {
        /// <summary>
        /// Indicates is the result from the validation is valid
        /// </summary>
        public bool IsValid { get; set; }

        /// <summary>
        /// Contais the result of the validation
        /// </summary>
        public ValidationResult ValidationResult { get; set; }

        /// <summary>
        /// Contains the error from the Validarion
        /// </summary>
        public IList<ValidationFailure> ValidationFailures { get; set; }
    }
}